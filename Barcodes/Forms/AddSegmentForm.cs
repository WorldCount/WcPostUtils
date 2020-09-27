using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Barcodes.Libs;
using Barcodes.Libs.Models;
using WcApi.Post;
using WcApi.Post.Barcodes;
using WcApi.Post.Ranges;

namespace Barcodes.Forms
{
    public partial class AddSegmentForm : Form
    {
        private string _mailTypePref;
        private StateRange _stateRange;
        private readonly Segment _segment = new Segment();
        private readonly List<InternalType> _internalTypes;

        public Segment Segment => _segment;

        private readonly List<StateSegment> _stateSegments = new List<StateSegment>
        {
            new StateSegment(1, "Свободен"),
            new StateSegment(2, "Занят"),
            new StateSegment(3, "Использован")
        };

        public AddSegmentForm(string internalTypePath)
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Today;

            _mailTypePref = "RA";
            _stateRange = StateRange.Free;

            _internalTypes = InternalTypeManager.Load(internalTypePath);

            // Устанавливаем язык ввода
            WcApi.Keyboard.Keyboard.SetEnglishLanguage();

            tbStartNum.Focus();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown.ValueChanged -= numericUpDown_ValueChanged;
            numericUpDown.Value = Month.GetMonthRange(dateTimePicker.Value);
            tbNumBarcode.Text = Month.GetMonthBarcode(dateTimePicker.Value).ToString();
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.ValueChanged -= dateTimePicker_ValueChanged;
            dateTimePicker.Value = Month.GetRangeDate((int)numericUpDown.Value);
            tbNumBarcode.Text = Month.GetMonthBarcode((int)numericUpDown.Value).ToString();
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
        }

        private void AddSegmentForm_Load(object sender, EventArgs e)
        {

            cbState.DataSource = _stateSegments;
            cbState.DisplayMember = "Name";
            cbState.ValueMember = "Value";
            cbState.SelectedItem = _stateSegments[0];

            internalTypeBindingSource.DataSource = _internalTypes;
        }

        private void StartNumLeave(object sender)
        {
            try
            {
                string start = ((TextBox)sender).Text.Substring(0, 2);
                int index = cbType.FindString(start);

                if (index != -1)
                    cbType.SelectedIndex = index;
                tbEndNum.Focus();
            }
            catch
            {
                // ignored
            }
        }

        private void tbStartNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartNumLeave(sender);
            }
        }

        private void tbStartNum_Leave(object sender, EventArgs e)
        {
            StartNumLeave(sender);
        }

        private void EndNumLeave(object sender)
        {
            try
            {
                string start = ((TextBox)sender).Text.Substring(0, 2);
                int index = cbType.FindString(start);

                if (index != -1)
                    cbType.SelectedIndex = index;
                btnAdd.Focus();
            }
            catch
            {
                // ignored
            }
        }

        private void tbEndNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EndNumLeave(sender);
            }
        }

        private void tbEndNum_Leave(object sender, EventArgs e)
        {
            EndNumLeave(sender);
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InternalType internalType = (InternalType) cbType.SelectedItem;

            if(internalType != null)
                _mailTypePref = internalType.Name;
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateSegment s = (StateSegment) cbState.SelectedItem;
            Enum.TryParse(s.Value.ToString(), out _stateRange);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (string.IsNullOrEmpty(tbStartNum.Text) || string.IsNullOrEmpty(tbEndNum.Text))
            {
                DialogResult = DialogResult.Abort;
                return;
            }

            _segment.NumBeg = ParseBarcode(tbStartNum.Text);
            _segment.NumEnd = ParseBarcode(tbEndNum.Text);
            _segment.MailTypePref = _mailTypePref;
            _segment.NumMonth = (int) numericUpDown.Value;
            _segment.State = _stateRange;

            Close();
        }

        private int ParseBarcode(string barcode)
        {
            if (barcode.Length >= 13)
            {
                if (char.IsLetter(barcode[0]))
                {
                    try
                    {
                        string num = barcode.Substring(2, 8);
                        return int.Parse(num);
                    }
                    catch
                    {
                        return 0;
                    }      
                }
                else
                {
                    try
                    {
                        Barcode b = new Barcode(barcode);
                        return int.Parse(b.Number);
                    }
                    catch
                    {
                        return 0;
                    }      
                }
            }

            try
            {
                int num = int.Parse(barcode);
                if(num > 99999) 
                    return int.Parse(barcode.Substring(0, 8));
                return num;
            }
            catch
            {
                return 0;
            }
        }

        private void AddSegmentForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
            {
                btnAdd.PerformClick();
            }

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }
    }
}
