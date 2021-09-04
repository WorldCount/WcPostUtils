using System;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Models.Types;
using LK.Core.Store.ExportFile;
using SQLiteNetExtensions.Attributes;

namespace LK.Core.Models.DB
{
    public class Rpo
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
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
        public Status Status { get; set; }

        [ForeignKey(typeof(Operator))]
        public int OperatorId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public Operator Operator { get; set; }

        #endregion

        [SQLite.Ignore]
        public string MailClassName
        {
            get
            {
                if (MailClass == MailClass.Международное)
                    return "МЖД";
                return "Внут";
            }
        }

        [SQLite.Ignore]
        public string DateName => ReceptionDate.ToShortDateString();

        [SQLite.Ignore]
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
        }ние 

        public bool IsElectronicNotice()
        {
            return PostMarkParser.IsElectronicNotice(Notice);
        }

        public bool IsInventory()
        {
            return Inventory;
        }

        public ExportFileString ToExportFileString()
        {
            ExportFileString e = new ExportFileString
            {
                OperDate = ReceptionDate.ToString("yyyyMMdd"), Barcode = Barcode, IndexTo = Index, Mass = "20",
                MassRate = ((int)MassRate).ToString()
            };

            if (MailClass == MailClass.Международное)
                e.MailDirect = "840";

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (AviaRate != 0)
                e.TransType = "2";

            if (IsSimpleNotice())
                e.PostMark = "1";
            if (IsCustomNotice())
                e.PostMark = "2";

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (Value != 0)
                e.Value = ((int) Value).ToString();

            return e;
        }

        #endregion

        #endregion
    }
}
