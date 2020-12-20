using System;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Models.Types;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace LK.Core.Models.DB
{
    public class Rpo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Barcode { get; set; }
        public string Index { get; set; }
        public double MassRate { get; set; }
        public double AviaRate { get; set; }
        public double ValueRate { get; set; }
        public double Value { get; set; }

        public int MailCategory { get; set; }
        public int MailType { get; set; }
        public MailClass MailClass { get; set; }

        public long Notice { get; set; }
        public bool Inventory { get; set; }

        public DateTime ReceptionDate { get; set; }

        public string Ops { get; set; }
        
        public string Address { get; set; }

        public string Reason { get; set; }


        #region Отношения

        [ForeignKey(typeof(FirmList))]
        public int FirmListId { get; set; }

        [ForeignKey(typeof(Status))]
        public int StatusId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public virtual Status Status { get; set; }

        [ForeignKey(typeof(Operator))]
        public int OperatorId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public virtual Operator Operator { get; set; }

        #endregion

        [Ignore]
        public string MailClassName
        {
            get
            {
                if (MailClass == MailClass.Международное)
                    return "МЖД";
                return "Внут";
            }
        }

        [Ignore]
        public string DateName => ReceptionDate.ToShortDateString();

        [Ignore]
        public DateTime ReceptionDateTrim => new DateTime(ReceptionDate.Year, ReceptionDate.Month, ReceptionDate.Day);

        #region Методы

        public bool IsInter()
        {
            return Barcode.ToUpper().Contains("R");
        }

        public bool IsAvia()
        {
            return AviaRate > 0;
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

        #endregion
    }
}
