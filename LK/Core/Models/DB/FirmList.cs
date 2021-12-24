using System;
using System.Collections.Generic;
using LK.Core.Libs.TarifManager.PostTypes;
using LK.Core.Models.Types;
using SQLiteNetExtensions.Attributes;
using WcApi.Finance;

namespace LK.Core.Models.DB
{
    public class FirmList
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }

        [SQLite.Ignore] public virtual bool Check { get; set; } = true;

        [SQLite.Indexed]
        public DateTime Date { get; set; }

        [SQLite.Indexed]
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

        [SQLite.Indexed]
        public DateTime ReceptionDate { get; set; }

        public string Ops { get; set; }

        #region Отношения

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Rpo> Rpos { get; set; } = new List<Rpo>();

        [ForeignKey(typeof(PayType)), SQLite.Indexed]
        public int PayTypeId { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public PayType PayType { get; set; }

        [ForeignKey(typeof(Firm)), SQLite.Indexed]
        public int FirmId { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Firm Firm { get; set; }

        [ForeignKey(typeof(Operator))]
        public int OperatorId { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.All)]
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

        [SQLite.Ignore]
        public string OperatorName
        {
            get
            {
                if (Operator != null)
                    return Operator.ShortName;
                return $"{OperatorId}";
            }
        }

        [SQLite.Ignore]
        public string FirmName
        {
            get
            {
                if (Firm != null)
                    return Firm.ShortName;
                return $"{FirmId}";
            }
        }

        [SQLite.Ignore]
        public string GroupName
        {
            get
            {
                if (Firm?.Group != null)
                    return Firm.Group.Name;
                return "";
            }
        }

        #region Методы

        public void Recount(int nds, int value)
        {
            if (Id > 0 && Rpos != null)
            {
                Count = 0;
                CountFact = 0;
                CountReturn = 0;
                CountMiss = 0;

                Value = 0;

                ValueRate = 0;
                MassRate = 0;
                MassRateNds = 0;

                Nds ndsCalc = new Nds(nds);

                foreach (Rpo rpo in Rpos)
                {

                    if (MailClass == MailClass.ВСЕ)
                        MailClass = rpo.MailClass;

                    Count += 1;

                    if (rpo.StatusId == 2)
                    {
                        CountFact += 1;
                        Value += rpo.Value;
                        ValueRate += rpo.ValueRate;
                        MassRate += rpo.MassRate;
                    }

                    if (rpo.StatusId == 3)
                        CountReturn += 1;

                    if (rpo.StatusId == 4)
                        CountMiss += 1;
                }

                MassRateNds = ndsCalc.Plus(MassRate);
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

        public bool IsInter()
        {
            return MailClass == MailClass.Международное;
        }
        #endregion
    }

    #endregion

}
