using System;
using System.Text.RegularExpressions;
using LK.Core.Libs.DataManagers;
using LK.Core.Libs.DataManagers.Models;
using LK.Core.Models.DB;
using LK.Core.Models.Types;
using NPOI.SS.UserModel;

namespace LK.Core.Models.Raw
{
    public class RawRpoData : IDisposable
    {
        private IRow _row;

        public Exception Exception { get; set; }

        #region Public

        public int Num { get; private set; }
        public string Inn { get; private set; }
        public string Kpp { get; private set; }

        public DateTime Date { get; private set; }
        public DateTime ReceptDate { get; private set; }

        public string Barcode { get; private set; }
        public string Type { get; private set; }
        public string Category { get; private set; }
        public string Status { get; private set; }
        public string Reason { get; private set; }

        public string OpsIndex { get; private set; }
        public string Operator { get; private set; }

        public string IndexTo { get; private set; }
        public string Address { get; private set; }

        public double MassRate { get; private set; }
        public double AviaRate { get; private set; }
        public double ValueRate { get; private set; }
        public double NoticeRate { get; private set; }
        public double Value { get; private set; }

        #endregion

        public RawRpoData(IRow row)
        {
            _row = row;
        }

        public bool Parse()
        {
            try
            {
                // Список
                Date = _row.GetCell(0, MissingCellPolicy.RETURN_BLANK_AS_NULL).DateCellValue;
                Num = (int) _row.GetCell(1, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue;

                // Организация
                Inn = _row.GetCell(3, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Kpp = _row.GetCell(4, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
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
                Barcode = _row.GetCell(6, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Type = _row.GetCell(7, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Category = _row.GetCell(8, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();

                MassRate = _row.GetCell(9, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                NoticeRate = _row.GetCell(10, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                AviaRate = _row.GetCell(11, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                Value = _row.GetCell(12, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                ValueRate = _row.GetCell(13, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;

                Status = _row.GetCell(14, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Reason = _row.GetCell(15, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                ReceptDate = _row.GetCell(16, MissingCellPolicy.RETURN_BLANK_AS_NULL).DateCellValue;

                string o = _row.GetCell(17, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Operator = o.Contains("  ") ? Regex.Replace(o, "[ ]+", " ") : o;

                OpsIndex = _row.GetCell(18, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                IndexTo = _row.GetCell(19, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Address = _row.GetCell(20, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
            }
            catch (Exception e)
            {
                Exception = e;
                return false;
            }

            return true;
        }

        public Rpo ToRpo()
        {
            Rpo r = new Rpo
            {
                Barcode = Barcode,
                AviaRate = AviaRate,
                Index = IndexTo,
                Address = Address,
                MassRate = MassRate,
                Value = Value,
                ValueRate = ValueRate,
                Ops = OpsIndex,
                Reason = Reason,
                ReceptionDate = ReceptDate,
                Inventory = Value > 0,
                MailClass = Barcode.ToUpper().Contains("R") ? MailClass.Международное : MailClass.Внутреннее
        };

            return r;
        }

        public void Dispose()
        {
            _row = null;
            Exception = null;
        }
    }
}
