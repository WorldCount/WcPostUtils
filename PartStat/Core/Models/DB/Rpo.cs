using System.Collections.Generic;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models.PostTypes;

namespace PartStat.Core.Models.DB
{
    public class Rpo
    {
        public string Index { get; set; }
        public double MassRate { get; set; }
        public double Value { get; set; }
        public int Count { get; set; }
        public int MailType { get; set; }
        public int MailCategory { get; set; }
        public long PostMark { get; set; }
        public int PayType { get; set; }
        public int SubPayType { get; set; }
        public int CodeCountry { get; set; }
        public string Res { get; set; }

        // Доп.инфа
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string DepCode { get; set; }

        #region Публичные высчитываемы свойства

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

                if (IsElectronicNotice())
                    data.Add("Эл.Ув");

                if (IsInventory())
                    data.Add("Опись");

                if (data.Count > 0)
                    return string.Join("; ", data);
                return "Без отметки";
            }
        }

        public string PayName
        {
            get
            {
                if (PayType == 16)
                {
                    if (SubPayType == 1)
                        return "Марки";
                    if (SubPayType == 2)
                        return "Франк";
                    return $"{PayType}-{SubPayType}";
                }

                if (PayType == 2)
                {
                    if (SubPayType == 1)
                        return "Безнал";
                    return $"{PayType}-{SubPayType}";
                }
                return $"{PayType}-{SubPayType}";
            }
        }

        #endregion

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
            return PayType == 16 && SubPayType == 1;
        }

        public bool IsManual()
        {
            return string.IsNullOrEmpty(Res);
        }

        #endregion


    }
}
