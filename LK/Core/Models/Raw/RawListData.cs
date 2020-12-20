using System;
using System.Text.RegularExpressions;
using LK.Core.Models.DB;
using LK.Core.Models.Types;
using NPOI.SS.UserModel;

namespace LK.Core.Models.Raw
{
    public class RawListData : IDisposable
    {
        private IRow _row;
        public Exception Exception { get; set; }

        #region Public

        public string Name { get; private set; }
        public string Inn { get; private set; }
        public string Kpp { get; private set; }
        public string Contract { get; private set; }
        public int Num { get; private set; }

        public DateTime Date { get; private set; }
        public DateTime ReceptDate { get; private set; }

        public string Type { get; private set; }
        public string Category { get; private set; }

        public string OpsIndex { get; private set; }
        public string Operator { get; private set; }

        public int AllCount { get; private set; }
        public int FactCount { get; private set; }
        public int ReturnCount { get; private set; }
        public int MissCount { get; private set; }

        public double MassRate { get; private set; }
        public double AviaRate { get; private set; }
        public double ValueRate { get; private set; }
        public double Value { get; private set; }

        public string O { get; set; }

        #endregion

        public RawListData(IRow row)
        {
            _row = row;
        }

        public bool Parse()
        {
            try
            {
                Name = _row.GetCell(2, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim().ToUpper();
                TrimName();

                Inn = _row.GetCell(3, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Kpp = _row.GetCell(4, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Contract = _row.GetCell(5, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Date = _row.GetCell(0, MissingCellPolicy.RETURN_BLANK_AS_NULL).DateCellValue;
                Num = (int) _row.GetCell(1, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue;
            }
            catch (Exception e)
            {
                Exception = e;
                return false;
            }

            return true;
        }

        public bool ParseNext()
        {
            try
            {
                Type = _row.GetCell(6, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Category = _row.GetCell(7, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();

                AllCount = (int) _row.GetCell(8, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue;
                FactCount = (int) _row.GetCell(9, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue;
                ReturnCount = (int) _row.GetCell(10, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue;
                MissCount = (int) _row.GetCell(11, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue;

                MassRate = _row.GetCell(12, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                AviaRate = _row.GetCell(13, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                Value = _row.GetCell(14, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                ValueRate = _row.GetCell(15, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;

                ReceptDate = _row.GetCell(16, MissingCellPolicy.RETURN_BLANK_AS_NULL).DateCellValue;

                string o = _row.GetCell(17, MissingCellPolicy.RETURN_BLANK_AS_NULL).StringCellValue.Trim();
                Operator = o.Contains("  ") ? Regex.Replace(o, "[ ]+", " ") : o;
                OpsIndex = _row.GetCell(18, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
            }
            catch (Exception e)
            {
                Exception = e;
                return false;
            }

            return true;
        }

        public FirmList ToFirmList()
        {
            FirmList f = new FirmList
            {
                Date = Date,
                Num = Num,
                AviaRate = AviaRate,
                MassRate = MassRate,
                Value = Value,
                ValueRate = ValueRate,
                Count = AllCount,
                CountFact = FactCount,
                CountReturn = ReturnCount,
                CountMiss = MissCount,
                ReceptionDate = ReceptDate,
                Ops = OpsIndex,
                Inventory = Value > 0,
                MailClass = MailClass.ВСЕ
            };


            return f;
        }

        private void TrimName()
        {
            if(Name.Contains("\""))
                Name = Name.Replace("\"", "");

            if (Name.Contains("ООО"))
                Name = Name.Replace("ООО", "");

            if (Name.Contains("“"))
                Name = Name.Replace("“", "");

            if (Name.Contains("”"))
                Name = Name.Replace("”", "");

            if (Name.Contains("«"))
                Name = Name.Replace("«", "");

            if (Name.Contains("»"))
                Name = Name.Replace("»", "");

            if (Name.Contains("АКЦИОНЕРНОЕ ОБЩЕСТВО"))
                Name = Name.Replace("АКЦИОНЕРНОЕ ОБЩЕСТВО", "");

            if (Name.Contains("ФГБУ"))
                Name = Name.Replace("ФГБУ", "");

            if (Name.Contains("ФКУ"))
                Name = Name.Replace("ФКУ", "");

            if (Name.Contains("ФГБОУ"))
                Name = Name.Replace("ФГБОУ", "");

            if (Name.Contains("ГБОУ"))
                Name = Name.Replace("ГБОУ", "");

            Name = Name.Trim();
        }

        public void Dispose()
        {
            _row = null;
            Exception = null;
        }
    }
}
