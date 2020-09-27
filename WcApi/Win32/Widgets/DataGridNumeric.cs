using System;
using System.Windows.Forms;

namespace WcApi.Win32.Widgets
{

    public class NumericColumn : DataGridViewColumn
    {
        public NumericColumn() : base(new NumericCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate;}
            set
            {
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(NumericCell)))
                {
                    throw new InvalidCastException("Must be a NumericCell");
                }
                base.CellTemplate = value;
            }
        }
    }


    public class NumericCell : DataGridViewTextBoxCell
    {
        public NumericCell()
        {
            Style.Format = "#";
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            NumericEditingControl ctl = DataGridView.EditingControl as NumericEditingControl;
            if (Value == null)
            {
                if (ctl != null)
                    if (DefaultNewRowValue != null)
                        ctl.Value = (decimal) DefaultNewRowValue;
            }
            else
            {
                if (ctl != null) ctl.Value = decimal.Parse(Value.ToString());
            }
        }

        public override Type EditType => typeof(NumericEditingControl);

        public override Type ValueType => typeof(decimal);

        public override object DefaultNewRowValue => 1;
    }


    public class NumericEditingControl : NumericUpDown, IDataGridViewEditingControl
    {
        private bool _valueChanged;

        public NumericEditingControl()
        {
            DecimalPlaces = 0;
            Minimum = 1;
            Maximum = 99999;
        }

        public object EditingControlFormattedValue
        {
            get
            {
                return Value.ToString("#");
            }
            set
            {
                string s = value as string;
                if (s != null)
                {
                    try
                    {
                        Value = decimal.Parse(s);
                    }
                    catch
                    {
                        Value = 1;
                    }
                }
            }
        }

        public object GetEditingControlFormattedValue(
            DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            ForeColor = dataGridViewCellStyle.ForeColor;
            BackColor = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex { get; set; }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }

        public bool RepositionEditingControlOnValueChange => false;

        public DataGridView EditingControlDataGridView { get; set; }

        public bool EditingControlValueChanged
        {
            get
            {
                return _valueChanged;
            }
            set
            {
                _valueChanged = value;
            }
        }

        public Cursor EditingPanelCursor => Cursor;

        protected override void OnValueChanged(EventArgs eventargs)
        {
            _valueChanged = true;
            EditingControlDataGridView?.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
