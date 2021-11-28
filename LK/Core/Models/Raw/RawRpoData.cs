using System;
using System.Text.RegularExpressions;
using LK.Core.Models.DB;
using LK.Core.Models.Types;
using LK.Core.Store.Manager;
using NPOI.SS.UserModel;

namespace LK.Core.Models.Raw
{
    public class RawRpoData : IDisposable
    {
        private IRow _row;
        private ConfigRpoFieldManager _cm;
        public Exception Exception { get; set; }

        #region Public

        public int Num { get; private set; }
        public string Inn { get; private set; }
        public string Kpp { get; private set; }
        public string Contract { get; private set; }
        public string FirmName { get; private set; }

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

        public RawRpoData(IRow row, ConfigRpoFieldManager cm)
        {
            _row = row;
            _cm = cm;
        }

        public bool Parse()
        {
            try
            {
                // Список
                Date = _row.GetCell(_cm.ListDate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).DateCellValue;
                Num = (int) _row.GetCell(_cm.ListNum.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue;

                // Организация
                Inn = _row.GetCell(_cm.Inn.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Kpp = _row.GetCell(_cm.Kpp.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                FirmName = _row.GetCell(_cm.FirmName.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Contract = _row.GetCell(_cm.Contract.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                ReceptDate = _row.GetCell(_cm.ReceptDate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).DateCellValue;
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
                Barcode = _row.GetCell(_cm.Barcode.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Type = _row.GetCell(_cm.Type.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Category = _row.GetCell(_cm.Category.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();

                MassRate = _row.GetCell(_cm.MassRate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                NoticeRate = _row.GetCell(_cm.NoticeRate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                AviaRate = _row.GetCell(_cm.AviaRate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                Value = _row.GetCell(_cm.Value.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                ValueRate = _row.GetCell(_cm.ValueRate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;

                Status = _row.GetCell(_cm.Status.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Reason = _row.GetCell(_cm.StatusMessage.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();

                string o = _row.GetCell(_cm.Oper.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Operator = o.Contains("  ") ? Regex.Replace(o, "[ ]+", " ") : o;

                OpsIndex = _row.GetCell(_cm.Ops.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                IndexTo = _row.GetCell(_cm.Index.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Address = _row.GetCell(_cm.Address.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
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
