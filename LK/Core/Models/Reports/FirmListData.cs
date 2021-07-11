using System;
using LK.Core.Models.Types;
using LK.Core.Libs.TarifManager.PostTypes;

namespace LK.Core.Models.Reports
{
    public class FirmListData
    {
        public int Id { get; set; }
        public virtual bool Check { get; set; } = true;
        public DateTime Date { get; set; }
        
        public string FirmName { get; set; }

        public int Num { get; set; }
        public int MailCategory { get; set; }
        public int MailType { get; set; }
        public MailClass MailClass { get; set; }

        public long Notice { get; set; }
        public bool Inventory { get; set; }
        
        public int Count { get; set; }
        public int CountFact { get; set; }
        public int CountReturn { get; set; }
        public int CountMiss { get; set; }
        public double MassRate { get; set; }
        public double MassRateNds { get; set; }
        public double AviaRate { get; set; }
        public double Value { get; set; }
        public double ValueRate { get; set; }

        public DateTime ReceptionDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string MailClassName
        {
            get
            {
                if (MailClass == MailClass.Международное)
                    return "МЖД";
                return "Внут";
            }
        }

        public string PostMarkName
        {
            get
            {
                string s = "";

                if (IsSimpleNotice())
                    s += "Пр.ув; ";
                if (IsCustomNotice())
                    s += "Зак.ув; ";
                if (IsElectronicNotice())
                    s += "Эл.ув; ";

                if (IsInventory())
                    s += "Опись";

                return s.Trim();
            }
        }

        public string OperatorName
        {
            get
            {
                if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
                    return $"{LastName} {FirstName[0]}. {MiddleName[0]}.";
                return LastName;
            }
        }

        #region Доп.Услуги

        public bool IsSimpleNotice()
        {
            return PostMarkParser.IsSimpleNotice(Notice);
        }

        public bool IsCustomNotice()
        {
            return PostMarkParser.IsCustomNotice(Notice);
        }

        public bool IsElectronicNotice()
        {
            return PostMarkParser.IsElectronicNotice(Notice);
        }

        public bool IsInventory()
        {
            return Inventory;
        }

        #endregion
    }
}
