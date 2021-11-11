using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;
using ListEditor.Models.Part;
using WcApi.Ini;

namespace ListEditor.Models.RTM
{
    public class Rtm1317
    {
        private readonly IniParser _ini = new IniParser();
        private readonly string _version = "RTM0003-13-17";
        private readonly string _header = "Barcode|Mass|MassRate|Payment|Value|InsrRate|AirRate|Rcpn|AddressTypeTo|NumAddressTypeTo|IndexTo|RegionTo|AreaTo|PlaceTo|LocationTo|StreetTo|HouseTo|LetterTo|SlashTo|CorpusTo|BuildingTo|HotelTo|RoomTo|Comment|MailDirect|TelAddress|Length|Width|Height|VolumeWeight|SMSNoticeR|MPODeclaration|PaymentCurrency|SndrFact|ApoNum|MailType\r\n";
        private readonly List<RtmRow> _rtmRows = new List<RtmRow>();
        private readonly bool _recount;
        private readonly double _nds;

        #region Данные для расчета
        // Общее количество РПО
        private int _count;
        // Общая сумма платы за пересылку (не включая НДС)
        private double _deliveryRateSum;
        // НДС от общей суммы платы за пересылку в копейках
        // ReSharper disable once InconsistentNaming
        private double _deliveryRateVAT;
        // Общая сумма платы за пересылку (включая НДС)
        private double _deliveryRateTotal;
        // Всего к оплате (в том числе НДС), в копейках.
        private double _totalRate;
        // НДС от общей суммы к оплате в копейках.
        // ReSharper disable once InconsistentNaming
        private double _totalRateVAT;
        #endregion

        // ReSharper disable once UnusedMember.Global
        public string Version => _version;

        #region Данные формата
        // Main
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string DepCode { get; set; }
        public string SndrTel { get; set; }
        public string SendCtg { get; set; }
        public DateTime SendDate { get; set; }
        public string ListNum { get; set; }
        public string IndexFrom { get; set; }
        public string MailType { get; set; }
        public string MailCtg { get; set; }
        public string DirectCtg { get; set; }
        public string PayType { get; set; }
        public string PayTypeNot { get; set; }
        public string TransType { get; set; }
        public string PostMark { get; set; }
        public string MailRank { get; set; }
        public string NumContract { get; set; }
        // ReSharper disable once InconsistentNaming
        public string SMSNoticeS { get; set; }
        public string KindJurPers { get; set; }
        public string SndrFact { get; set; }
        public string InnFact { get; set; }
        public string KppFact { get; set; }
        public string DepcodeFact { get; set; }
        // Sender
        public string Sndr { get; set; }
        public string AddressTypeSndr { get; set; }
        public string NumAddressTypeSndr { get; set; }
        public string IndexSndr { get; set; }
        public string RegionSndr { get; set; }
        public string AreaSndr { get; set; }
        public string PlaceSndr { get; set; }
        public string LocationSndr { get; set; }
        public string StreetSndr { get; set; }
        public string HouseSndr { get; set; }
        public string LetterSndr { get; set; }
        public string SlashSndr { get; set; }
        public string CorpusSndr { get; set; }
        public string BuildingSndr { get; set; }
        public string HotelSndr { get; set; }
        public string RoomSndr { get; set; }
        // Summary
        public string MailCount { get; set; }
        public string MailWeight { get; set; }
        public string ValueSum { get; set; }
        public string DeliveryRateSum { get; set; }
        // ReSharper disable once InconsistentNaming
        public string DeliveryRateVAT { get; set; }
        public string DeliveryRateTotal { get; set; }
        public string ValueSumRateTotal { get; set; }
        // ReSharper disable once InconsistentNaming
        public string ValueSumRateVAT { get; set; }
        public string NoticeRateTotal { get; set; }
        // ReSharper disable once InconsistentNaming
        public string NoticeRateVAT { get; set; }
        // ReSharper disable once InconsistentNaming
        public string SMSNoticeTotal { get; set; }
        // ReSharper disable once InconsistentNaming
        public string SMSNoticeVAT { get; set; }
        public string TotalRate { get; set; }
        // ReSharper disable once InconsistentNaming
        public string TotalRateVAT { get; set; }
        #endregion

        public Rtm1317(string opsIndex, bool recount = false, double nds = 0.20)
        {
            _recount = recount;
            _nds = 1 + nds;

            IndexFrom = opsIndex;
            IndexSndr = opsIndex;
            DirectCtg = "1";
            KindJurPers = "0";
            AddressTypeSndr = "1";
            RegionSndr = "МОСКВА";
            PlaceSndr = "МОСКВА";
            MailCount = "0";
            MailWeight = "0";
            ValueSum = "0";
            DeliveryRateSum = "0";
            DeliveryRateVAT = "0";
            DeliveryRateTotal = "0";
            ValueSumRateTotal = "0";
            ValueSumRateVAT = "0";
            NoticeRateTotal = "0";
            NoticeRateVAT = "0";
            SMSNoticeTotal = "0";
            SMSNoticeVAT = "0";
            TotalRate = "0";
            TotalRateVAT = "0";
            NumContract = "1";
        }

        public void Compile()
        {
            CreateMain();
            CreateSender();
            CreateSummary();
            CreateDocVersion();
        }

        public string GetName()
        {
            string year = SendDate.ToString(CultureInfo.InvariantCulture);
            char y = year[year.Length - 1];
            int days = SendDate.DayOfYear;

            return $"{Inn.PadLeft(12, '0')}{y}{days.ToString().PadLeft(3, '0')}{ListNum.PadLeft(5, '0')}";
        }

        public void Save(string dir, Encoding encoding = null)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (encoding == null)
                encoding = Encoding.GetEncoding("cp866");

            try
            {
                Compile();

                string zipPath = Path.Combine(dir, $"{GetName()}.zip");
                if (File.Exists(zipPath))
                    File.Delete(zipPath);

                using (FileStream zipFile = new FileStream(zipPath, FileMode.Create))
                {
                    using (ZipArchive archive = new ZipArchive(zipFile, ZipArchiveMode.Create))
                    {
                        ZipArchiveEntry ini = archive.CreateEntry(GetIniName());
                        using (StreamWriter writer = new StreamWriter(ini.Open(), encoding))
                        {
                            _ini.Save(writer);
                        }

                        ZipArchiveEntry txt = archive.CreateEntry(GetTxtName());
                        using (StreamWriter writer = new StreamWriter(txt.Open(), encoding))
                        {
                            writer.Write(_header);
                            // ReSharper disable once ForCanBeConvertedToForeach
                            for (int i = 0; i < _rtmRows.Count; i++)
                            {
                                writer.Write(_rtmRows[i]);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Rtm1317->Save: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetTxtName()
        {
            return $"{GetName()}.txt";
        }

        public string GetIniName()
        {
            return $"{GetName()}h.ini";
        }

        public void Add(RtmRow row)
        {
            _rtmRows.Add(row);

            if (_recount)
            {
                try {  _deliveryRateSum += double.Parse(row.MassRate) / 100; } catch { _deliveryRateSum += 0; }
                _count += 1;
            }
        }

        private void CreateMain()
        {
            _ini.AddSetting("Main", "Inn", Inn);
            _ini.AddSetting("Main", "Kpp", Kpp);
            _ini.AddSetting("Main", "DepCode", DepCode);
            _ini.AddSetting("Main", "SndrTel", SndrTel);
            _ini.AddSetting("Main", "SendCtg", SendCtg);
            _ini.AddSetting("Main", "SendDate", SendDate.ToString("yyyyMMdd"));
            _ini.AddSetting("Main", "ListNum", ListNum);
            _ini.AddSetting("Main", "IndexFrom", IndexFrom);
            _ini.AddSetting("Main", "MailType", MailType);
            _ini.AddSetting("Main", "MailCtg", MailCtg);
            _ini.AddSetting("Main", "DirectCtg", DirectCtg);
            _ini.AddSetting("Main", "PayType", PayType);
            _ini.AddSetting("Main", "PayTypeNot", PayTypeNot);
            _ini.AddSetting("Main", "TransType", TransType);
            _ini.AddSetting("Main", "PostMark", PostMark);
            _ini.AddSetting("Main", "MailRank", MailRank);
            _ini.AddSetting("Main", "NumContract", NumContract);
            _ini.AddSetting("Main", "SMSNoticeS", SMSNoticeS);
            _ini.AddSetting("Main", "KindJurPers", KindJurPers);
            _ini.AddSetting("Main", "SndrFact", SndrFact);
            _ini.AddSetting("Main", "InnFact", InnFact);
            _ini.AddSetting("Main", "KppFact", KppFact);
            _ini.AddSetting("Main", "DepcodeFact", DepcodeFact);
        }

        private void CreateSender()
        {
            _ini.AddSetting("Sender", "Sndr", Sndr);
            _ini.AddSetting("Sender", "AddressTypeSndr", AddressTypeSndr);
            _ini.AddSetting("Sender", "NumAddressTypeSndr", NumAddressTypeSndr);
            _ini.AddSetting("Sender", "IndexSndr", IndexSndr);
            _ini.AddSetting("Sender", "RegionSndr", RegionSndr);
            _ini.AddSetting("Sender", "AreaSndr", AreaSndr);
            _ini.AddSetting("Sender", "PlaceSndr", PlaceSndr);
            _ini.AddSetting("Sender", "LocationSndr", LocationSndr);
            _ini.AddSetting("Sender", "StreetSndr", StreetSndr);
            _ini.AddSetting("Sender", "HouseSndr", HouseSndr);
            _ini.AddSetting("Sender", "LetterSndr", LetterSndr);
            _ini.AddSetting("Sender", "SlashSndr", SlashSndr);
            _ini.AddSetting("Sender", "CorpusSndr", CorpusSndr);
            _ini.AddSetting("Sender", "BuildingSndr", BuildingSndr);
            _ini.AddSetting("Sender", "HotelSndr", HotelSndr);
            _ini.AddSetting("Sender", "RoomSndr", RoomSndr);
        }

        private void CreateSummary()
        {
            if (_recount)
            {
                
                _deliveryRateTotal = _deliveryRateSum * _nds;
                _deliveryRateVAT = _deliveryRateTotal - _deliveryRateSum;

                _totalRate = _deliveryRateTotal;
                _totalRateVAT = _deliveryRateVAT;

                MailCount = _count.ToString();
                DeliveryRateSum = (_deliveryRateSum * 100).ToString("0.##").Replace(".", "").Replace(",", "");
                DeliveryRateTotal = (_deliveryRateTotal * 100).ToString("0.##").Replace(".", "").Replace(",", "");
                DeliveryRateVAT = (_deliveryRateTotal * 100).ToString("0.##").Replace(".", "").Replace(",", "");
                TotalRate = (_totalRate * 100).ToString("0.##").Replace(".", "").Replace(",", "");
                TotalRateVAT = (_totalRateVAT * 100).ToString("0.##").Replace(".", "").Replace(",", "");
            }

            _ini.AddSetting("Summary", "MailCount", MailCount);
            _ini.AddSetting("Summary", "MailWeight", MailWeight);
            _ini.AddSetting("Summary", "ValueSum", ValueSum);
            _ini.AddSetting("Summary", "DeliveryRateSum", DeliveryRateSum);
            _ini.AddSetting("Summary", "DeliveryRateVAT", DeliveryRateVAT);
            _ini.AddSetting("Summary", "DeliveryRateTotal", DeliveryRateTotal);
            _ini.AddSetting("Summary", "ValueSumRateTotal", ValueSumRateTotal);
            _ini.AddSetting("Summary", "ValueSumRateVAT", ValueSumRateVAT);
            _ini.AddSetting("Summary", "NoticeRateTotal", NoticeRateTotal);
            _ini.AddSetting("Summary", "NoticeRateVAT", NoticeRateVAT);
            _ini.AddSetting("Summary", "SMSNoticeTotal", SMSNoticeTotal);
            _ini.AddSetting("Summary", "SMSNoticeVAT", SMSNoticeVAT);
            _ini.AddSetting("Summary", "TotalRate", TotalRate);
            _ini.AddSetting("Summary", "TotalRateVAT", TotalRateVAT);
        }

        private void CreateDocVersion()
        {
            _ini.AddSetting("DocVersion", "DocVersion", _version);
        }
    }

    public class RtmRow
    {
        #region Данные формата

        [DisplayName(@"ШПИ")]
        public string Barcode { get; set; }
        [DisplayName(@"Вес")]
        public string Mass { get; set; }
        [DisplayName(@"Плата")]
        public string MassRate { get; set; }
        [DisplayName(@"Н/ПЛ")]
        public string Payment { get; set; }
        [DisplayName(@"О/Ц")]
        public string Value { get; set; }
        [Browsable(false)]
        public string InsrRate { get; set; }
        [Browsable(false)]
        public string AirRate { get; set; }
        [DisplayName(@"Получатель")]
        public string Rcpn { get; set; }
        [Browsable(false)]
        public string AddressTypeTo { get; set; }
        [Browsable(false)]
        public string NumAddressTypeTo { get; set; }
        [DisplayName(@"Индекс")]
        public string IndexTo { get; set; }
        [DisplayName(@"Область")]
        public string RegionTo { get; set; }
        [DisplayName(@"Район")]
        public string AreaTo { get; set; }
        [DisplayName(@"Город")]
        public string PlaceTo { get; set; }
        [Browsable(false)]
        public string LocationTo { get; set; }
        [Browsable(false)]
        public string StreetTo { get; set; }
        [Browsable(false)]
        public string HouseTo { get; set; }
        [Browsable(false)]
        public string LetterTo { get; set; }
        [Browsable(false)]
        public string SlashTo { get; set; }
        [Browsable(false)]
        public string CorpusTo { get; set; }
        [Browsable(false)]
        public string BuildingTo { get; set; }
        [Browsable(false)]
        public string HotelTo { get; set; }
        [Browsable(false)]
        public string RoomTo { get; set; }
        [Browsable(false)]
        public string Comment { get; set; }
        [Browsable(false)]
        public string MailDirect { get; set; }
        [Browsable(false)]
        public string TelAddress { get; set; }
        [Browsable(false)]
        public string Length { get; set; }
        [Browsable(false)]
        public string Width { get; set; }
        [Browsable(false)]
        public string Height { get; set; }
        [Browsable(false)]
        public string VolumeWeight { get; set; }
        // ReSharper disable once InconsistentNaming
        [Browsable(false)]
        public string SMSNoticeR { get; set; }
        // ReSharper disable once InconsistentNaming
        [Browsable(false)]
        public string MPODeclaration { get; set; }
        [Browsable(false)]
        public string PaymentCurrency { get; set; }
        [Browsable(false)]
        public string SndrFact { get; set; }
        [Browsable(false)]
        public string ApoNum { get; set; }
        [Browsable(false)]
        public string MailType { get; set; }

        [Browsable(false)]
        public string RawRegion { get; set; }

        #endregion

        public RtmRow(TxtRow row)
        {
            ParseRow(row);
        }

        private void ParseRow(TxtRow row)
        {
            Dictionary<string, string> data = new Dictionary<string, string>(row.Data);
            Barcode = ParseValue("Barcode", data);
            Mass = ParseValue("Mass", data);
            MassRate = ParseValue("MassRate", data);
            Payment = ParseValue("Payment", data);
            Value = ParseValue("Value", data);
            InsrRate = ParseValue("InsrRate", data);
            AirRate = ParseValue("AirRate", data);
            Rcpn = ParseValue("Rcpn", data);
            AddressTypeTo = ParseValue("AddressTypeTo", data);
            NumAddressTypeTo = ParseValue("NumAddressTypeTo", data);
            IndexTo = ParseValue("IndexTo", data);
            RegionTo = ParseValue("RegionTo", data);
            AreaTo = ParseValue("AreaTo", data);
            PlaceTo = ParseValue("PlaceTo", data);
            LocationTo = ParseValue("LocationTo", data);
            StreetTo = ParseValue("StreetTo", data);
            HouseTo = ParseValue("HouseTo", data);
            LetterTo = ParseValue("LetterTo", data);
            SlashTo = ParseValue("SlashTo", data);
            CorpusTo = ParseValue("CorpusTo", data);
            BuildingTo = ParseValue("BuildingTo", data);
            HotelTo = ParseValue("HotelTo", data);
            RoomTo = ParseValue("RoomTo", data);
            Comment = ParseValue("Comment", data);
            TelAddress = ParseValue("TelAddress", data);
            SMSNoticeR = ParseValue("SMSNoticeR", data);
            MPODeclaration = ParseValue("MPODeclaration", data);
            PaymentCurrency = ParseValue("PaymentCurrency", data);
            SndrFact = ParseValue("SndrFact", data);
            ApoNum = ParseValue("ApoNum", data);
            MailType = ParseValue("MailType", data);

            MailDirect = ParseValue("MailDirect", data);
            PaymentCurrency = "RUB";
            Length = "0";
            Width = "0";
            Height = "0";
            VolumeWeight = "0";

            IndexTo = IndexTo.Trim();
            RegionTo = ClearString(RegionTo);
            RawRegion = ParseRegion(RegionTo);
            PlaceTo = ClearString(PlaceTo);
            if (string.IsNullOrEmpty(PlaceTo))
                PlaceTo = RegionTo;
        }

        private string ParseRegion(string regionTo)
        {
            string res = regionTo.ToUpper();

            string[] split = new[] { "РЕСПУБЛИКА", "ОБЛАСТЬ", "КРАЙ" };

            if (res.Contains("ОКРУГ") || res.Contains("ОКРУ"))
                return "";

            string[] data = res.Split(split, StringSplitOptions.None);
            foreach (string s in data)
            {
                string temp = s.Replace('-', ' ').Trim();
                if (!string.IsNullOrEmpty(temp))
                    res = temp;
            }
            return res;
        }

        private string ParseValue(string value, Dictionary<string, string> data)
        {
            string v = value.ToUpper();

            if (data.ContainsKey(v))
                return data[v];

            return "";
        }

        private string ClearString(string s)
        {
            string n = s.Replace("г.", "").Replace("Г.", "").Replace("г ", "").Replace("Г ", "").Replace("ё", "е").Replace("пос. ", "").Replace("с. ", "").Replace("п. ", "").Replace("п.т.", "").Replace("пгт ", "").Replace("о. ", "").Replace("д. ", "").Replace("ст. ", "").Replace("поселение", "").Trim();
            string[] data = n.Split(',');
            n = data[0].Trim();

            if (n.ToUpper().EndsWith(" Г"))
                n = n.Substring(0, n.Length - 2);

            if (n.ToUpper().StartsWith("C.") || n.ToUpper().StartsWith("С."))
                n = n.Substring(2, n.Length - 2);

            return n;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Barcode}|");
            sb.Append($"{Mass}|");
            sb.Append($"{MassRate}|");
            sb.Append($"{Payment}|");
            sb.Append($"{Value}|");
            sb.Append($"{InsrRate}|");
            sb.Append($"{AirRate}|");
            sb.Append($"{Rcpn}|");
            sb.Append($"{AddressTypeTo}|");
            sb.Append($"{NumAddressTypeTo}|");
            sb.Append($"{IndexTo}|");
            sb.Append($"{RegionTo}|");
            sb.Append($"{AreaTo}|");
            sb.Append($"{PlaceTo}|");
            sb.Append($"{LocationTo}|");
            sb.Append($"{StreetTo}|");
            sb.Append($"{HouseTo}|");
            sb.Append($"{LetterTo}|");
            sb.Append($"{SlashTo}|");
            sb.Append($"{CorpusTo}|");
            sb.Append($"{BuildingTo}|");
            sb.Append($"{HotelTo}|");
            sb.Append($"{RoomTo}|");
            sb.Append($"{Comment}|");
            sb.Append($"{MailDirect}|");
            sb.Append($"{TelAddress}|");
            sb.Append($"{Length}|");
            sb.Append($"{Width}|");
            sb.Append($"{Height}|");
            sb.Append($"{VolumeWeight}|");
            sb.Append($"{SMSNoticeR}|");
            sb.Append($"{MPODeclaration}|");
            sb.Append($"{PaymentCurrency}|");
            sb.Append($"{SndrFact}|");
            sb.Append($"{ApoNum}|");
            sb.Append($"{MailType}\r\n");

            return sb.ToString();
        }
    }
}
