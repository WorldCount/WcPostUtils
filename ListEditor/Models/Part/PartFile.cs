using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;
using ListEditor.Libs;
using ListEditor.Models.Part.Types;
using ListEditor.Models.RTM;
using SQLite;
using WcApi.Ini;
using WcApi.Win32.Forms;

namespace ListEditor.Models.Part
{
    public class PartFile
    {
        private readonly string _path;
        private int _errorCount;
        private int _validateErrorCount;
        private List<Error> _errorMessage;
        private TxtHeader _header;
        private List<RtmRow> _rows;
        private IniParser _ini;
        private readonly bool _debug = Properties.Settings.Default.Debug;
        private SQLiteConnection _db;

        private bool _checkIndex;
        private bool _checkAllIndex;
        private readonly Image _succesImage = new Bitmap(Properties.Resources.Ok_small, 16, 16);
        private readonly Image _errorImage = new Bitmap(Properties.Resources.Remove_small, 16, 16);
        private readonly string _database = Path.Combine(Properties.Settings.Default.DataDir, Properties.Settings.Default.DB);

        public string Name { get; set; }

        [Browsable(false)]
        public TxtHeader Header => _header;
        [Browsable(false)]
        public List<RtmRow> Rows => _rows;
        [Browsable(false)]
        public IniParser Ini => _ini;

        [DisplayName(@"Ошибок")]
        public int ErrorCount => _errorCount;
        [Browsable(false)]
        public List<Error> ErrorMessage => _errorMessage;
        [DisplayName(@"Строк")]
        public int Count => _rows.Count;

        [DisplayName(@"ИНН")]
        public string Inn { get; set; }
        [DisplayName(@"КПП")] 
        public string Kpp { get; set; } = "000000000";
        // Имя организации
        [DisplayName(@"Отправитель")]
        public string Sender { get; set; }
        // Вид пересылки: Внутренняя, Международная
        [DisplayName(@"Пересылка")]
        public string DirectCtg { get; set; }
        // Категория отправителя
        [DisplayName(@"Категория")]
        public string SendCtg { get; set; }
        // ДипКод
        [DisplayName(@"DepCode")]
        public string DepCode { get; set; }
        // Номер списка
        [DisplayName(@"Список")]
        public string ListNum { get; set; }
        // Тип отправления
        [DisplayName(@"Тип")]
        public string MailType { get; set; }
        // Категория отправления
        [DisplayName(@"Категория")]
        public string MailCtg { get; set; }
        // Разряд отправления
        [DisplayName(@"Разряд")]
        public string MailRank { get; set; }
        // Тип оплаты
        [DisplayName(@"Оплата")]
        public string PayType { get; set; }
        // Сумма оплаты
        [DisplayName(@"Сумма")]
        public double PaySum { get; set; }
        // НДС от суммы
        [DisplayName(@"НДС")]
        public double Nds { get; set; }
        // Отметки
        [DisplayName(@"Отметки")]
        public string PostMark { get; set; }
        // Дата списка
        [DisplayName(@"Дата")]
        public DateTime SendDate { get; set; }
        // Минимальный вес
        [DisplayName(@"Минимальный вес")]
        public int MinWeight { get; set; }
        // Максимальный вес
        [DisplayName(@"Максимальный вес")]
        public int MaxWeight { get; set; }
        [DisplayName(@"Вес валиден")]
        public bool WeightValid { get; set; }
        public Image ValidImage { get; set; }

        private string TxtName => $"{Name}.txt";
        private string IniName => $"{Name}h.ini";
        private string ZipName => $"F{Name}.zip";

        public string Dir => Path.GetDirectoryName(_path);
        private string PathIni => Path.Combine(Dir, IniName);
        private string PathTxt => Path.Combine(Dir, TxtName);
        private string PathZip => Path.Combine(Dir, ZipName);

        public PartFile(string path)
        {
            _path = path;

            string name = Path.GetFileName(_path);

            if (!string.IsNullOrEmpty(name))
            {
                Name = name.Split('.')[0].Replace("F", "").Replace("h", "");
            }
        }

        public bool IsZip()
        {
            if (string.IsNullOrEmpty(_path))
                return false;
            return _path.Contains(".zip");
        }

        public void Parse()
        {
            _errorCount = 0;
            _errorMessage = new List<Error>();
            _checkIndex = Properties.Settings.Default.CheckIndex;
            _checkAllIndex = Properties.Settings.Default.CheckAllIndex;

            ParseIni();
            ParseTxt();

            WeightValid = true;

            MailType = _ini.GetSetting("Main", "MailType");
            Sender = _ini.GetSetting("Sender", "Sndr");
            ListNum = _ini.GetSetting("Main", "ListNum");
            SendCtg = _ini.GetSetting("Main", "SendCtg");
            DepCode = _ini.GetSetting("Main", "DepCode");
            Inn = _ini.GetSetting("Main", "Inn");
            Kpp = _ini.GetSetting("Main", "Kpp");
            DirectCtg = _ini.GetSetting("Main", "DirectCtg");

            if (Kpp == null || Kpp.Length < 9)
                Kpp = "000000000";

            string sendDate = _ini.GetSetting("Main", "SendDate");
            SendDate = DateTime.ParseExact(sendDate, "yyyyMMdd", CultureInfo.CurrentCulture);
            MailCtg = _ini.GetSetting("Main", "MailCtg");
            MailRank = _ini.GetSetting("Main", "MailRank");
            PayType = _ini.GetSetting("Main", "PayType");
            PostMark = _ini.GetSetting("Main", "PostMark");

            #region Проверка уведомлений

            if (Properties.Settings.Default.CheckPostMark)
            {
                if (MailCtg == "1")
                {
                    if (PostMark != "0" || PostMark != "1")
                    {
                        long idPostMark = 0;
                        try
                        {
                            idPostMark = long.Parse(PostMark);
                        }
                        catch (Exception e)
                        {
                            _errorCount += 1;
                            _errorMessage.Add(new Error() { Message =$"Ошибка парсинга PostMark, cписок '{ListNum}', Отметка '{PostMark}':\n{e.Message }"});
                        }

                        PostMarkFlags flags = PostMarks.GetPostMarkFlags(idPostMark);
                        if (flags.HasFlag(PostMarkFlags.SimpleNotify))
                            PostMark = PostMarkFlags.SimpleNotify.ToString("D");
                        else if (flags.HasFlag(PostMarkFlags.CustomNotify))
                            PostMark = PostMarkFlags.CustomNotify.ToString("D");
                        else
                            PostMark = PostMarkFlags.None.ToString("D");
                    }
                }
            }

            #endregion

            try
            {
                PaySum = double.Parse(_ini.GetSetting("Summary", "DeliveryRateSum")) / 100;
            }
            catch (Exception e)
            {
                _errorCount += 1;
                _errorMessage.Add(new Error() {Message = $"Ошибка парсинга платы за пересылку '{_ini.GetSetting("Summary", "DeliveryRateSum")}': {e.Message}"});
                PaySum = 0.00;
            }

            try
            {
                Nds = double.Parse(_ini.GetSetting("Summary", "DeliveryRateVAT")) / 100;
            }
            catch (Exception e)
            {
                _errorCount += 1;
                _errorMessage.Add(new Error() { Message = $"Ошибка парсинга НДС за пересылку '{_ini.GetSetting("Summary", "DeliveryRateVAT")}': {e.Message}" });
                Nds = 0.00;
            }

            if (MailType == "2")
                if (MaxWeight > 100)
                    WeightValid = false;

            ValidImage = WeightValid ? _succesImage : _errorImage;
            if (_validateErrorCount > 0)
                ValidImage = _errorImage;
        }

        public void SaveToRtm(string dir)
        {
            string payTypeNot = _ini.GetSetting("Main", "PayTypeNot");

            if (string.IsNullOrEmpty(payTypeNot))
                payTypeNot = "2";

            try
            {
                Rtm1317 rtm = new Rtm1317(Properties.Settings.Default.IndexOps, Properties.Settings.Default.RecountValue, Properties.Settings.Default.NDS)
                {
                    Inn = Inn,
                    Kpp = Kpp,
                    DepCode = DepCode,
                    DirectCtg = DirectCtg,
                    SendCtg = SendCtg,
                    SendDate = SendDate,
                    ListNum = ListNum,
                    MailType = MailType,
                    MailCtg = MailCtg,
                    PayType = PayType,
                    PayTypeNot = payTypeNot,
                    TransType = _ini.GetSetting("Main", "TransType"),
                    PostMark = PostMark,
                    MailRank = MailRank,
                    Sndr = Sender,
                    MailCount = _ini.GetSetting("Summary", "MailCount"),
                    MailWeight = _ini.GetSetting("Summary", "MailWeight"),
                    ValueSum = _ini.GetSetting("Summary", "ValueSum"),
                    DeliveryRateSum = _ini.GetSetting("Summary", "DeliveryRateSum"),
                    DeliveryRateVAT = _ini.GetSetting("Summary", "DeliveryRateVAT"),
                    DeliveryRateTotal = _ini.GetSetting("Summary", "DeliveryRateTotal"),
                    ValueSumRateTotal = _ini.GetSetting("Summary", "ValueSumRateTotal"),
                    ValueSumRateVAT = _ini.GetSetting("Summary", "ValueSumRateVAT"),
                    NoticeRateTotal = _ini.GetSetting("Summary", "NoticeRateTotal"),
                    NoticeRateVAT = _ini.GetSetting("Summary", "NoticeRateVAT"),
                    SMSNoticeTotal = _ini.GetSetting("Summary", "SMSNoticeTotal"),
                    SMSNoticeVAT = _ini.GetSetting("Summary", "SMSNoticeVAT"),
                    TotalRate = _ini.GetSetting("Summary", "TotalRate"),
                    TotalRateVAT = _ini.GetSetting("Summary", "TotalRateVAT")
                };

                foreach (RtmRow rtmRow in Rows)
                {
                    rtm.Add(rtmRow);
                }
                rtm.Save(dir);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Save: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddRow(int num, string rawRow)
        {
            int mass = 0;

            TxtRow row = new TxtRow(_header, rawRow);
            RtmRow rtmRow = new RtmRow(row);

            if (_header.Count != row.Count)
            {
                _errorCount += 1;
                _errorMessage.Add(new Error() { Message = $"Несоответствие количество столбцов заголовка({_header.Count}) и столбцов строки({row.Count}) в строке {num}" });
            }

            try
            {
                mass = int.Parse(rtmRow.Mass);
            }
            catch (Exception e)
            {
                _errorCount += 1;
                _errorMessage.Add(new Error() {Message = $"ШПИ: {rtmRow.Barcode} -> Ошибка парсинга веса ['{rtmRow.Mass}']: {e.Message}"});   
            }

            if(MinWeight == 0)
                MinWeight = mass;

            if(MaxWeight == 0)
                MaxWeight = mass;

            if (mass < MinWeight)
                MinWeight = mass;

            if (mass > MaxWeight)
                MaxWeight = mass;

            bool validate = CheckRegionCity.Validate(rtmRow.PlaceTo.ToUpper(), rtmRow.RegionTo.ToUpper());
            if (!validate)
            {
                _validateErrorCount += 1;
                _errorCount += 1;
                _errorMessage.Add(new Error($"ШПИ: {rtmRow.Barcode} -> Признак международного отправления: '{rtmRow.PlaceTo}' - '{rtmRow.RegionTo}'"));
            }

            // Если надо проверить индексы
            if (_checkIndex && validate && !_checkAllIndex)
            {
                try
                {
                    rtmRow = CheckIndex(rtmRow);
                }
                catch (Exception e)
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error($"ШПИ: {rtmRow.Barcode}, исправление индекса ['{rtmRow.IndexTo}', '{rtmRow.PlaceTo}'] пропущено -> {e.Message}"));
                }      
            }

            // Если надо проверить все индексы
            if (_checkAllIndex && validate)
            {
                try
                {
                    rtmRow = CheckAllIndex(rtmRow);
                }
                catch (Exception e)
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error($"ШПИ: {rtmRow.Barcode}, исправление индекса ['{rtmRow.IndexTo}', '{rtmRow.PlaceTo}'] пропущено -> {e.Message}"));
                }
            }

            _rows.Add(rtmRow);
        }

        private RtmRow CheckAllIndex(RtmRow rtmRow)
        {
            RtmRow newRtmRow = CheckIndex(rtmRow);
            int index;

            try
            {
                index = Convert.ToInt32(newRtmRow.IndexTo);
            }
            catch
            {
                index = 0;
            }

            string q = "select * from [Index] where num like ? order by num limit 1";
            var result = _db.Query<Index>(q, new object[] { $"{newRtmRow.IndexTo}%" });

            if (result.Count == 0)
            {        

                if (index > 140000)
                {
                    if (newRtmRow.RawRegion == "САНКТ ПЕТЕРБУРГ")
                    {
                        q = "select * from [Index] where (name like ? or name like ?) and num like ? order by num limit 1";
                        result = _db.Query<Index>(q, new object[] { $"{newRtmRow.PlaceTo.ToUpper()}%", $"{newRtmRow.PlaceTo.ToUpper()}", $"%{newRtmRow.IndexTo.Substring(3)}" });
                        if(_debug) ErrorMessageBox.Show($"select * from [Index] where (name like '{newRtmRow.PlaceTo.ToUpper()}%' or name like '{newRtmRow.PlaceTo.ToUpper()}') and num like '%{newRtmRow.IndexTo.Substring(3)}' order by num limit 1", $"CheckAllIndex: {result.Count}");

                        if (result.Count == 0)
                        {
                            q = "select * from [Index] where name like ? or name like ? order by num limit 1";
                            result = _db.Query<Index>(q, new object[] { $"{newRtmRow.PlaceTo.ToUpper()}%", $"{newRtmRow.PlaceTo.ToUpper()}", $"%{newRtmRow.IndexTo.Substring(3)}" });
                            if (_debug) ErrorMessageBox.Show($"select * from [Index] where name like '{newRtmRow.PlaceTo.ToUpper()}%' or name like '{newRtmRow.PlaceTo.ToUpper()}' order by num limit 1", $"CheckAllIndex: {result.Count}");
                        }
                    }
                    else
                    {
                        q = "select * from [Index] where name like ? and num like ? and (type = 'О' or type = 'ГСП') order by num limit 1";
                        result = _db.Query<Index>(q, new object[] { $"{newRtmRow.PlaceTo.ToUpper()}%", $"{newRtmRow.IndexTo.Substring(0, 2)}%" });
                        if (_debug) ErrorMessageBox.Show($"select * from [Index] where name like '{newRtmRow.PlaceTo.ToUpper()}%' and num like '{ newRtmRow.IndexTo.Substring(0, 2)}%' and (type = 'О' or type = 'ГСП') order by num limit 1", $"CheckAllIndex: {result.Count}");

                        if (result.Count == 0)
                        {
                            q = "select * from [Index] where (name like ? or name like ?) and region like ? order by num limit 1";
                            result = _db.Query<Index>(q, new object[] { $"{newRtmRow.PlaceTo.ToUpper()}%", $"{newRtmRow.PlaceTo.ToUpper()}", $"%{newRtmRow.RawRegion}%" });
                            if (_debug) ErrorMessageBox.Show($"select * from [Index] where (name like '{newRtmRow.PlaceTo.ToUpper()}%' or name like '{newRtmRow.PlaceTo.ToUpper()}') and region like '%{newRtmRow.RawRegion}%' order by num limit 1", $"CheckAllIndex: {result.Count}");
                        }
                    }
                }
                else
                {
                    q = "select * from [Index] where num like ? and name like 'МОСКВА%' and (type = 'О' or type = 'ГСП') order by num limit 1";
                    result = _db.Query<Index>(q, new object[] { $"%{newRtmRow.IndexTo.Substring(3)}" });
                    if (_debug) ErrorMessageBox.Show($"select * from [Index] where num like '%{newRtmRow.IndexTo.Substring(3)}' and name like 'МОСКВА%' and (type = 'О' or type = 'ГСП') order by num limit 1", $"CheckAllIndex: {result.Count}");
                }


                if (result.Count == 0)
                {
                    if (index < 140000)
                    {
                        q = "select * from [Index] where num < ? order by num desc limit 1";
                        result = _db.Query<Index>(q, new object[] {$"{newRtmRow.IndexTo}"});
                        if (_debug) ErrorMessageBox.Show($"select * from [Index] where num < '{newRtmRow.IndexTo}' order by num desc limit 1", $"CheckAllIndex: {result.Count}");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(newRtmRow.RawRegion))
                        {
                            q = "select * from [Index] where num like ? and region = '' order by num desc limit 1";
                            result = _db.Query<Index>(q, new object[] {$"%{newRtmRow.IndexTo.Substring(2)}"});
                            if (_debug) ErrorMessageBox.Show($"select * from [Index] where num like '%{newRtmRow.IndexTo.Substring(2)}' and region = '' order by num desc limit 1", $"CheckAllIndex: {result.Count}");
                        }
                        else
                        {
                            q = "select * from [Index] where num <> ? and region like ? order by num limit 1";
                            result = _db.Query<Index>(q, new object[] { $"%{newRtmRow.IndexTo}", $"%{newRtmRow.RawRegion}%" });
                            if (_debug) ErrorMessageBox.Show($"select * from [Index] where num <> '%{newRtmRow.IndexTo}' and region like '%{newRtmRow.RawRegion}%' order by num limit 1", $"CheckAllIndex: {result.Count}");
                        }
                    }
                }

                if (result.Count > 0)
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() { Message = $"ШПИ {newRtmRow.Barcode} -> Исправлен индекс с '{newRtmRow.IndexTo}, {newRtmRow.PlaceTo}, {newRtmRow.RegionTo}' на '{result[0].Num}, {result[0].GetName()}, {result[0].Region}'" });
                    newRtmRow.IndexTo = result[0].Num;
                    newRtmRow.PlaceTo = result[0].Name;
                }
                else
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() { Message = $"ШПИ {rtmRow.Barcode} -> Не могу исправить индекс '{rtmRow.IndexTo}, {rtmRow.PlaceTo}, {rtmRow.RegionTo}' -> мало входящих данных." });
                }
            }
            else
            {
                newRtmRow.PlaceTo = result[0].Name.Split(' ')[0];
            }

            return rtmRow;
        }

        // Исправляет ошибочные индексы
        private RtmRow CheckIndex(RtmRow rtmRow)
        {

            if (rtmRow.IndexTo == "123995")
                rtmRow.IndexTo = "125993";

            if (rtmRow.IndexTo == "123955")
                rtmRow.IndexTo = "125993";

            if (rtmRow.PlaceTo.ToUpper() == "ЗЕЛЕНОГРАД" && rtmRow.IndexTo == "")
            {
                rtmRow.PlaceTo = "Москва";
                rtmRow.IndexTo = "124365";
            }

            if (rtmRow.PlaceTo.ToUpper() == "ЖЕЛЕЗНОДОРОЖНЫЙ")
            {
                rtmRow.PlaceTo = "Балашиха";
                rtmRow.IndexTo = "143980";
            }

            if (rtmRow.PlaceTo.ToUpper() == "МОСКОВСКИЙ")
            {
                rtmRow.PlaceTo = "Московский";
                rtmRow.IndexTo = "108811";
            }

            int index;

            try
            {
                index = Convert.ToInt32(rtmRow.IndexTo);
            }
            catch
            {
                index = 0;
            }

            #region Пустой индекс

            if (string.IsNullOrEmpty(rtmRow.IndexTo) || index == 0)
            {
                if (!string.IsNullOrEmpty(rtmRow.PlaceTo))
                {
                    string q = "select * from [Index] where name like ? and (type = 'О' or type = 'ГСП') order by num limit 1";
                    List<Index> result;

                    if (rtmRow.PlaceTo.ToUpper() == "МОСКВА" || rtmRow.PlaceTo.ToUpper() == "ЗЕЛЕНОГРАД")
                        result = _db.Query<Index>(q, new object[] { $"{rtmRow.PlaceTo.ToUpper()}%" });
                    else
                        result = _db.Query<Index>(q, new object[] { $"{rtmRow.PlaceTo.ToUpper()} %" });

                    if (result.Count > 0)
                    {
                        _errorCount += 1;
                        _errorMessage.Add(new Error() { Message = $"ШПИ {rtmRow.Barcode} -> Исправлен индекс с '{rtmRow.IndexTo}, {rtmRow.PlaceTo}, {rtmRow.RegionTo}' на '{result[0].Num}, {result[0].GetName()}, {result[0].Region}'" });
                        rtmRow.IndexTo = result[0].Num;
                        return rtmRow;
                    }
                }
            }

            #endregion

            #region Индекс короче 6 символов

            if (rtmRow.IndexTo.Length < 6)
            {
                List<Index> result;

                string q = "select * from [Index] where num like ? and name like ? and (type = 'О' or type = 'ГСП') order by num limit 1";

                if (rtmRow.PlaceTo.ToUpper() == "МОСКВА" || rtmRow.PlaceTo.ToUpper() == "ЗЕЛЕНОГРАД")
                {
                    result = _db.Query<Index>(q, new object[] {$"{rtmRow.IndexTo}%", $"{rtmRow.PlaceTo.ToUpper()}%"});
                    if (_debug) ErrorMessageBox.Show($"select * from [Index] where num like '{rtmRow.IndexTo}%' and name like '{rtmRow.PlaceTo.ToUpper()}%' and (type = 'О' or type = 'ГСП') order by num limit 1", $"CheckIndex: {result.Count}");
                }
                else
                {
                    result = _db.Query<Index>(q, new object[] {$"%{rtmRow.IndexTo.Insert(3, "_")}%", $"{rtmRow.PlaceTo.ToUpper()} %"});
                    if (_debug) ErrorMessageBox.Show($"select * from [Index] where num like '%{rtmRow.IndexTo.Insert(3, "_")}%' and name like '{rtmRow.PlaceTo.ToUpper()} %' and (type = 'О' or type = 'ГСП') order by num limit 1", $"CheckIndex: {result.Count}");
                }

                if (result.Count > 0)
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() { Message = $"ШПИ {rtmRow.Barcode} -> Исправлен индекс с '{rtmRow.IndexTo}, {rtmRow.PlaceTo}, {rtmRow.RegionTo}' на '{result[0].Num}, {result[0].GetName()}, {result[0].Region}'" });
                    rtmRow.IndexTo = result[0].Num;
                    return rtmRow;
                }
                else
                {
                    result = _db.Query<Index>("select * from [Index] where num like ? and (type = 'О' or type = 'ГСП') order by num limit 1", new object[] { $"{rtmRow.IndexTo}%", $"{rtmRow.PlaceTo.ToUpper()} %" });

                    if (result.Count > 0)
                    {
                        _errorCount += 1;
                        _errorMessage.Add(new Error() { Message = $"ШПИ {rtmRow.Barcode} -> Исправлен индекс с '{rtmRow.IndexTo}, {rtmRow.PlaceTo}, {rtmRow.RegionTo}' на '{result[0].Num}, {result[0].GetName()}, {result[0].Region}'" });
                        rtmRow.IndexTo = result[0].Num;
                        return rtmRow;
                    }

                    _errorCount += 1;
                    _errorMessage.Add(new Error() { Message = $"ШПИ {rtmRow.Barcode} -> Не могу исправить индекс '{rtmRow.IndexTo}, {rtmRow.PlaceTo}, {rtmRow.RegionTo}' -> мало входящих данных." });
                    return rtmRow;
                }
            }

            #endregion

            #region Индекс Москвы или Зеленограда, но город другой или индекс города, а город указан Москва

            if ((index < 140000 && rtmRow.PlaceTo.ToUpper() != "МОСКВА") && (index < 140000 && rtmRow.PlaceTo.ToUpper() != "ЗЕЛЕНОГРАД") || (index > 140000 && rtmRow.PlaceTo.ToUpper() == "МОСКВА"))
            {
                if (rtmRow.IndexTo.StartsWith("108"))
                    return rtmRow;

                if (string.IsNullOrEmpty(rtmRow.PlaceTo))
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() { Message = $"ШПИ {rtmRow.Barcode} -> Не могу исправить индекс '{rtmRow.IndexTo}, {rtmRow.PlaceTo}, {rtmRow.RegionTo}' -> мало входящих данных." });
                    return rtmRow;
                }

                List<Index> result;
                string q = "select * from [Index] where name like ? and (type = 'О' or type = 'ГСП') order by num limit 1";

                if (rtmRow.PlaceTo.ToUpper() == "МОСКВА" || rtmRow.PlaceTo.ToUpper() == "ЗЕЛЕНОГРАД")
                {
                    result = _db.Query<Index>(q, new object[] {$"{rtmRow.PlaceTo.ToUpper()}%"});

                    if (_debug) ErrorMessageBox.Show($"select * from [Index] where name like '{rtmRow.PlaceTo.ToUpper()}%' and (type = 'О' or type = 'ГСП') order by num limit 1", $"CheckIndex: {result.Count}");
                }
                else
                {
                    result = _db.Query<Index>(q, new object[] {$"{rtmRow.PlaceTo.ToUpper()} %"});
                    if (_debug) ErrorMessageBox.Show($"select * from [Index] where name like '{rtmRow.PlaceTo.ToUpper()} %' and (type = 'О' or type = 'ГСП') order by num limit 1", $"CheckIndex: {result.Count}");
                }

                if (result.Count > 0)
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() { Message = $"ШПИ {rtmRow.Barcode} -> Исправлен индекс с '{rtmRow.IndexTo}, {rtmRow.PlaceTo}, {rtmRow.RegionTo}' на '{result[0].Num}, {result[0].GetName()}, {result[0].Region}'" });
                    rtmRow.IndexTo = result[0].Num;
                    return rtmRow;
                }
            }

            #endregion

            return rtmRow;
        }

        private void ParseTxt()
        {
            _rows = new List<RtmRow>();

            if (IsZip())
            {
                if (File.Exists(PathZip))
                {
                    try
                    {
                        using (ZipArchive archive = ZipFile.OpenRead(PathZip))
                        {
                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                if (entry.FullName.EndsWith(".txt"))
                                {
                                    using (StreamReader sr = new StreamReader(entry.Open(), Encoding.GetEncoding("cp866")))
                                    {
                                        ReadTxtFile(sr);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        _errorCount += 1;
                        _errorMessage.Add(new Error() {Message = $"ParseTxt(): {e.Message}"});
                    }     
                }
                else
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() {Message = $"Файл {PathTxt} не найден."});
                }
            }
            else
            {
                if (File.Exists(PathTxt))
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(PathTxt, Encoding.GetEncoding("cp866")))
                        {
                            ReadTxtFile(sr);
                        }
                    }
                    catch (Exception e)
                    {
                        _errorCount += 1;
                        _errorMessage.Add(new Error() { Message = $"ParseTxt(): {e.Message}" });
                    }
                }
                else
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() {Message = $"Файл {PathTxt} не найден."});
                }
            }
        }

        private void ReadTxtFile(StreamReader sr)
        {
            if(_db == null)
                _db = new SQLiteConnection(_database);

            string header = sr.ReadLine();
            string line;
            string fullLine = "";
            int counter = 2;
            _header = new TxtHeader(header);

            while ((line = sr.ReadLine()) != null)
            {
                try
                {
                    fullLine += line.Trim();

                    if (fullLine.Split('|').Length == _header.Count)
                    {
                        AddRow(counter, fullLine);
                        counter++;
                        fullLine = "";
                    }        
                }
                catch (Exception e)
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() { Message = $"ReadTxtFile(): {e.Message}: {counter} строка. Заголовок({_header.Count}), Строка({line.Split('|').Length})" }); 
                }    
            }
            _db?.Close();
        }

        private void ParseIni()
        {
            _ini = new IniParser {UpperKey = true};

            if (IsZip())
            {
                if (File.Exists(PathZip))
                {
                    try
                    {
                        using (ZipArchive archive = ZipFile.OpenRead(PathZip))
                        {
                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                if (entry.FullName.EndsWith(".ini"))
                                {
                                    using (TextReader sr = new StreamReader(entry.Open(),
                                        Encoding.GetEncoding("cp866")))
                                    {
                                        _ini.Path = PathZip;
                                        _ini.Parse(sr);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        _errorCount += 1;
                        _errorMessage.Add(new Error() {Message = e.Message });
                    }
                }
                else
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() {Message = $"Файл {PathIni} не найден."});
                }
            }
            else
            {
                if (File.Exists(PathIni))
                {
                    try
                    {
                        _ini.Path = PathIni;
                        _ini.Parse();
                    }
                    catch (Exception e)
                    {
                        _errorCount += 1;
                        _errorMessage.Add(new Error() {Message = e.Message});
                    }  
                }
                else
                {
                    _errorCount += 1;
                    _errorMessage.Add(new Error() {Message = $"Файл {PathIni} не найден."});
                }
            }
        }
    }
}
