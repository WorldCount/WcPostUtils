using System;
using System.Collections.Generic;
using PartStat.Core.Libs.DataBase;
using PartStat.Core.Libs.DataBase.Queries;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models.PostTypes;
using PartStat.Core;

namespace PartStat.Core.Models.DB
{
    public class FirmList
    {

        public DateTime Date { get; set; }
        public string FirmName { get; set; }
        public int Num { get; set; }
        public int MailType { get; set; }
        public int MailCategory { get; set; }
        public long PostMark { get; set; }
        public int Count { get; set; }
        public int WarnCount { get; set; }
        public int ErrCount { get; set; }

        // Доп.инфа
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string DepCode { get; set; }

        // Стоимость и вес
        public double MassRate { get; set; }
        public double Value { get; set; }
        public int PayType { get; set; }
        public int SubPayType { get; set; }
        
        // Информация о МЖД, ручке и т.д
        public int TransType { get; set; }
        public int CodeCountry { get; set; }
        public char Status { get; set; }
        public bool Manual { get; set; }
        public bool Check { get; set; } = true;

        public string MailTypeName
        {
            get
            {
                MailType mailType = MailTypeManager.GetById(MailType);
                if (mailType == null)
                    return MailType.ToString();
                return mailType.ShortName;
            }
        }

        public string MailCategoryName
        {
            get
            {
                MailCategory mailCategory = MailCategoryManager.GetById(MailCategory);
                if (mailCategory == null)
                    return MailCategory.ToString();
                return mailCategory.ShortName;
            }
        }

        public string InterName
        {
            get
            {
                if (CodeCountry == 643)
                    return "Внут";
                return "МЖД";
            }
        }

        public string PostMarkName
        {
            get
            {
                List<string> data = new List<string>();

                if (IsSimpleNotice())
                    data.Add("Пр.Ув");

                if (IsCustomNotice())
                    data.Add("Зак.Ув");

                if(IsElectronicNotice())
                    data.Add("Эл.Ув");

                if(IsInventory())
                    data.Add("Опись");

                if (data.Count > 0)
                    return string.Join("; ", data);
                return "Без отметки";
            }
        }

        public string PostMarkNamePrint
        {
            get
            {
                List<string> data = new List<string>();

                if (IsSimpleNotice())
                    data.Add("Пр.Ув");

                if (IsCustomNotice())
                    data.Add("Зак.Ув");

                if (IsElectronicNotice())
                    data.Add("Эл.Ув");

                if (IsInventory())
                    data.Add("Опись");

                if (data.Count > 0)
                    return string.Join("; ", data);
                return "";
            }
        }

        public string PayName => Utils.GetPayName(PayType, SubPayType);

        public string ManualName
        {
            get
            {
                if (Manual)
                    return "Да";
                return "Нет";
            }
        }

        #region Методы

        public bool IsInter()
        {
            return CodeCountry == 0;
        }

        public bool IsSimpleNotice()
        {
            return PostMarkParser.IsSimpleNotice(PostMark);
        }

        public bool IsCustomNotice()
        {
            return PostMarkParser.IsCustomNotice(PostMark);
        }

        public bool IsElectronicNotice()
        {
            return PostMarkParser.IsElectronicNotice(PostMark);
        }

        public bool IsInventory()
        {
            return PostMarkParser.IsInventory(PostMark);
        }

        public bool IsPayMark()
        {
            if (PayType == 16 && SubPayType == 1)
                return true;
            return false;
        }

        public bool SetManual(bool value, Connect connect)
        {
            string res = "";

            if (!value)
                res = $"C:\\PartPost131\\OUT\\INN_{Inn}\\{Inn.PadLeft(12, '0')}0666{Num.ToString().PadLeft(5, '0')}h.txt";

            UpdateFirmListManualQuery updateFirmListManualQuery = new UpdateFirmListManualQuery(connect, this, res);
            return updateFirmListManualQuery.Run();
        }

        #endregion

    }
}
