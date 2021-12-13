using System;
using System.Text.RegularExpressions;
using LK.Core.Models.DB;
using LK.Core.Models.Types;
using LK.Core.Store.Manager.FileManager;
using NPOI.SS.UserModel;

namespace LK.Core.Models.Raw
{
    public class RawData : IDisposable
    {
        #region Private Fields

        private IRow _row;
        private readonly ConfigDataFieldManager _cm;
        public Exception Exception { get; private set; }

        #endregion

        #region Public Properties

        // ДАННЫЕ ПО ОРГАНИЗАЦИИ
        public string Inn { get; private set; }
        public string Kpp { get; private set; }
        public string Contract { get; private set; }
        public string FirmName { get; private set; }

        // ДАННЫЕ ПО СПИСКУ
        public int ListNum { get; private set; }
        public string Type { get; private set; }
        public string Category { get; private set; }
        public string TransType { get; private set; }

        // ДАННЫЕ ПО ДАТЕ
        public DateTime Date { get; private set; }
        public DateTime ReceptDate { get; private set; }

        // ДАННЫЕ ПО РПО
        public string Barcode { get; private set; }
        public string OpsIndex { get; private set; }
        public string IndexTo { get; private set; }
        public string Address { get; private set; }
        public double MassRate { get; private set; }
        public double AviaRate { get; private set; }
        public double ValueRate { get; private set; }
        public double ServiceRate { get; private set; }
        public double Value { get; private set; }

        // ДАННЫЕ ПО СТАТУСУ РПО
        public string Status { get; private set; }
        public string Reason { get; private set; }

        // ДАННЫЕ ПО ОПЕРАТОРУ
        public string Operator { get; private set; }

        #endregion

        public RawData(IRow row, ConfigDataFieldManager cm)
        {
            _row = row;
            _cm = cm;
        }

        #region Private Methods

        private void ParseFirm()
        {
            try
            {
                Inn = _row.GetCell(_cm.Inn.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Kpp = _row.GetCell(_cm.Kpp.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                FirmName = _row.GetCell(_cm.FirmName.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                FirmName = Utils.TrimName(FirmName);
                Contract = _row.GetCell(_cm.Contract.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
            }
            catch (Exception e)
            {
                Exception = e;
                throw;
            }
        }

        private void ParseDate()
        {
            try
            {
                DateTime? rawDate = GetCellDateValue(_row.GetCell(_cm.ListDate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL));
                DateTime? rawReceptDate = GetCellDateValue(_row.GetCell(_cm.ReceptDate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL));

                if (rawDate == null || rawReceptDate == null)
                {
                    throw new NullReferenceException("Ошибка парсинга даты");
                }

                Date = (DateTime) rawDate;
                ReceptDate = (DateTime) rawReceptDate;
            }
            catch (Exception e)
            {
                Exception = e;
                throw;
            }
        }

        private void ParseList()
        {
            try
            {
                ListNum = (int)_row.GetCell(_cm.ListNum.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue;
                Type = _row.GetCell(_cm.Type.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Category = _row.GetCell(_cm.Category.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                TransType = _row.GetCell(_cm.TransType.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
            }
            catch (Exception e)
            {
                Exception = e;
                throw;
            }
        }

        private void ParseRpo()
        {
            try
            {
                Barcode = _row.GetCell(_cm.Barcode.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                MassRate = _row.GetCell(_cm.MassRate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                ServiceRate = _row.GetCell(_cm.NoticeRate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                AviaRate = _row.GetCell(_cm.AviaRate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                Value = _row.GetCell(_cm.Value.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                ValueRate = _row.GetCell(_cm.ValueRate.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;
                Value = _row.GetCell(_cm.Value.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).NumericCellValue / 100;

                OpsIndex = _row.GetCell(_cm.Ops.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                IndexTo = _row.GetCell(_cm.Index.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Address = _row.GetCell(_cm.Address.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();

                Status = _row.GetCell(_cm.Status.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Reason = _row.GetCell(_cm.StatusMessage.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
            }
            catch (Exception e)
            {
                Exception = e;
                throw;
            }
        }

        private void ParseOperator()
        {
            try
            {
                string o = _row.GetCell(_cm.Oper.NumColumn, MissingCellPolicy.RETURN_BLANK_AS_NULL).ToString().Trim();
                Operator = o.Contains("  ") ? Regex.Replace(o, "[ ]+", " ") : o;
            }
            catch (Exception e)
            {
                Exception = e;
                throw;
            }
        }

        private DateTime? GetCellDateValue(ICell cellValue)
        {
            if (cellValue == null)
            {
                // Cell doesn't have any value
                return null;
            }

            if (cellValue.CellType == CellType.Numeric)
            {
                return DateTime.FromOADate(cellValue.NumericCellValue);
            }

            return cellValue.DateCellValue;
        }

        #endregion

        #region Public Methods

        public bool Parse()
        {
            try
            {
                ParseFirm();
                ParseDate();
                ParseList();
                ParseOperator();
                ParseRpo();
            }
            catch (Exception e)
            {
                Exception = e;
                throw;
            }

            return true;
        }

        public Rpo ToRpo()
        {
            return new Rpo
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
                Inventory = IsInventory(),
                MailClass = GetMailClass()
            };
        }

        public MailClass GetMailClass()
        {
            return TransType.ToUpper() == "МЕЖДУНАРОДНОЕ" ? MailClass.Международное : MailClass.Внутреннее;
        }

        public bool IsInventory()
        {
            return Value > 0;
        }

        #endregion

        #region Ovverrides Methods

        public void Dispose()
        {
            _row = null;
            Exception = null;
        }

        public override string ToString()
        {
            return $"{Date}: [{FirmName} сп {ListNum}][{Barcode}]";
        }

        #endregion
    }
}
