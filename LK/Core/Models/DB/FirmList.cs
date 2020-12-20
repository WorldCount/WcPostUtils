using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Models.Types;
using LK.Core.Store;
using SQLite;
using SQLiteNetExtensions.Attributes;
using WcApi.Finance;

namespace LK.Core.Models.DB
{
    public class FirmList
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Ignore] public virtual bool Check { get; set; } = true;

        [Indexed]
        public DateTime Date { get; set; }

        [Indexed]
        public int Num { get; set; }

        public int MailCategory { get; set; }
        public int MailType { get; set; }

        public long Notice { get; set; }
        public bool Inventory { get; set; }

        public MailClass MailClass { get; set; }

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

        public string Ops { get; set; }

        #region Отношения

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public virtual List<Rpo> Rpos { get; set; } = new List<Rpo>();

        [ForeignKey(typeof(Firm)), Indexed]
        public int FirmId { get; set; }

        //[OneToOne(CascadeOperations = CascadeOperation.All)]
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public virtual Firm Firm { get; set; }

        [ForeignKey(typeof(Operator))]
        public int OperatorId { get; set; }

        //[OneToOne(CascadeOperations = CascadeOperation.All)]
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
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

        [Ignore]
        public string OperatorName
        {
            get
            {
                if (Operator != null)
                    return Operator.ShortName;
                return $"{OperatorId}";
            }
        }

        [Ignore]
        public string FirmName
        {
            get
            {
                if (Firm != null)
                    return Firm.ShortName;
                return $"{FirmId}";
            }
        }

        #region Методы

        public void Recount(int nds, int value)
        {
            if (Id > 0 && Rpos != null)
            {
                CountFact = 0;
                Value = 0;

                ValueRate = 0;
                MassRate = 0;
                MassRateNds = 0;

                foreach (Rpo rpo in Rpos)
                {

                    if (MailClass == MailClass.ВСЕ)
                        MailClass = rpo.MailClass;

                    if (rpo.StatusId == 2)
                    {
                        CountFact += 1;
                        Value += rpo.Value;
                        ValueRate += rpo.ValueRate;
                        MassRate += rpo.MassRate;
                    }
                }
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

    #endregion

}
