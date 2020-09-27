using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PartStat.Core.Libs.DataManagers;
using PartStat.Core.Models;

namespace PartStat.Forms
{
    public partial class ColorForm : Form
    {
        private Color _warnBackColor;
        private Color _warnForeColor;
        private Color _errBackColor;
        private Color _errForeColor;

        private readonly ColorDialog _colorDialog;

        public ColorForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $"{Properties.Settings.Default.AppName}: Настройки цвета";

            _colorDialog = new ColorDialog();

            LoadColors();
            UpdatePicture();
            UpdateExample();
        }

        private void LoadColors()
        {
            _errBackColor = DataColorManager.GetDataColorByName(ColorName.ErrorBack).GetColor();
            _errForeColor = DataColorManager.GetDataColorByName(ColorName.ErrorFore).GetColor();
            _warnBackColor = DataColorManager.GetDataColorByName(ColorName.WarnBack).GetColor();
            _warnForeColor = DataColorManager.GetDataColorByName(ColorName.WarnFore).GetColor();
        }

        private void UpdatePicture()
        {
            pictureBoxWarnBack.BackColor = _warnBackColor;
            pictureBoxWarnFore.BackColor = _warnForeColor;
            pictureBoxErrorBack.BackColor = _errBackColor;
            pictureBoxErrorFore.BackColor = _errForeColor;
        }

        private void UpdateExample()
        {
            textBoxWarnExample.BackColor = _warnBackColor;
            textBoxWarnExample.ForeColor = _warnForeColor;
            textBoxErrorExample.BackColor = _errBackColor;
            textBoxErrorExample.ForeColor = _errForeColor;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = (PictureBox) sender;
            ControlPaint.DrawBorder(e.Graphics, pictureBox.ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void pictureBoxWarnBack_Click(object sender, EventArgs e)
        {
            _colorDialog.Color = _warnBackColor;
            if (_colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                _warnBackColor = _colorDialog.Color;
                UpdatePicture();
                UpdateExample();
            }
        }

        private void pictureBoxWarnFore_Click(object sender, EventArgs e)
        {
            _colorDialog.Color = _warnForeColor;
            if (_colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                _warnForeColor = _colorDialog.Color;
                UpdatePicture();
                UpdateExample();
            }
        }

        private void pictureBoxErrorFore_Click(object sender, EventArgs e)
        {
            _colorDialog.Color = _errForeColor;
            if (_colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                _errForeColor = _colorDialog.Color;
                UpdatePicture();
                UpdateExample();
            }
        }

        private void pictureBoxErrorBack_Click(object sender, EventArgs e)
        {
            _colorDialog.Color = _errBackColor;
            if (_colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                _errBackColor = _colorDialog.Color;
                UpdatePicture();
                UpdateExample();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataColor warnBack = new DataColor(ColorName.WarnBack, _warnBackColor);
            DataColor warnFore = new DataColor(ColorName.WarnFore, _warnForeColor);
            DataColor errorBack = new DataColor(ColorName.ErrorBack, _errBackColor);
            DataColor errorFore = new DataColor(ColorName.ErrorFore, _errForeColor);

            List<DataColor> dataColors = new List<DataColor>
            {
                warnBack, warnFore, errorBack, errorFore
            };

            DataColorManager.Save(dataColors);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ColorForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Нажатие Ctrl + S
            if (e.KeyCode == Keys.S && e.Control)
                btnSave.PerformClick();

            // Esc
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
        }
    }
}
