
namespace Barcodes.Forms
{
    partial class AddSegmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSegmentForm));
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblNumMonthRange = new System.Windows.Forms.Label();
            this.lblNumMonthBarcode = new System.Windows.Forms.Label();
            this.gbMonth = new System.Windows.Forms.GroupBox();
            this.tbNumBarcode = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gbNum = new System.Windows.Forms.GroupBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbEndNum = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblTypeSegment = new System.Windows.Forms.Label();
            this.lblEndNum = new System.Windows.Forms.Label();
            this.lblStartNum = new System.Windows.Forms.Label();
            this.tbStartNum = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.internalTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.gbMonth.SuspendLayout();
            this.gbNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.numericUpDown.Location = new System.Drawing.Point(227, 52);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(95, 29);
            this.numericUpDown.TabIndex = 0;
            this.numericUpDown.TabStop = false;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMonth.Location = new System.Drawing.Point(6, 30);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(144, 19);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Дата диапазона:";
            // 
            // lblNumMonthRange
            // 
            this.lblNumMonthRange.AutoSize = true;
            this.lblNumMonthRange.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumMonthRange.Location = new System.Drawing.Point(223, 30);
            this.lblNumMonthRange.Name = "lblNumMonthRange";
            this.lblNumMonthRange.Size = new System.Drawing.Size(63, 19);
            this.lblNumMonthRange.TabIndex = 0;
            this.lblNumMonthRange.Text = "Номер:";
            // 
            // lblNumMonthBarcode
            // 
            this.lblNumMonthBarcode.AutoSize = true;
            this.lblNumMonthBarcode.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumMonthBarcode.Location = new System.Drawing.Point(334, 30);
            this.lblNumMonthBarcode.Name = "lblNumMonthBarcode";
            this.lblNumMonthBarcode.Size = new System.Drawing.Size(45, 19);
            this.lblNumMonthBarcode.TabIndex = 0;
            this.lblNumMonthBarcode.Text = "ШПИ:";
            // 
            // gbMonth
            // 
            this.gbMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMonth.Controls.Add(this.tbNumBarcode);
            this.gbMonth.Controls.Add(this.lblNumMonthBarcode);
            this.gbMonth.Controls.Add(this.dateTimePicker);
            this.gbMonth.Controls.Add(this.lblMonth);
            this.gbMonth.Controls.Add(this.lblNumMonthRange);
            this.gbMonth.Controls.Add(this.numericUpDown);
            this.gbMonth.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMonth.ForeColor = System.Drawing.Color.DimGray;
            this.gbMonth.Location = new System.Drawing.Point(12, 12);
            this.gbMonth.Name = "gbMonth";
            this.gbMonth.Size = new System.Drawing.Size(710, 106);
            this.gbMonth.TabIndex = 0;
            this.gbMonth.TabStop = false;
            this.gbMonth.Text = "Месяц";
            // 
            // tbNumBarcode
            // 
            this.tbNumBarcode.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbNumBarcode.Location = new System.Drawing.Point(338, 52);
            this.tbNumBarcode.Name = "tbNumBarcode";
            this.tbNumBarcode.ReadOnly = true;
            this.tbNumBarcode.Size = new System.Drawing.Size(41, 29);
            this.tbNumBarcode.TabIndex = 0;
            this.tbNumBarcode.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePicker.CustomFormat = "MMMM yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.ForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(10, 52);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.TabStop = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // gbNum
            // 
            this.gbNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNum.Controls.Add(this.cbState);
            this.gbNum.Controls.Add(this.cbType);
            this.gbNum.Controls.Add(this.tbEndNum);
            this.gbNum.Controls.Add(this.lblState);
            this.gbNum.Controls.Add(this.lblTypeSegment);
            this.gbNum.Controls.Add(this.lblEndNum);
            this.gbNum.Controls.Add(this.lblStartNum);
            this.gbNum.Controls.Add(this.tbStartNum);
            this.gbNum.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbNum.ForeColor = System.Drawing.Color.DimGray;
            this.gbNum.Location = new System.Drawing.Point(12, 124);
            this.gbNum.Name = "gbNum";
            this.gbNum.Size = new System.Drawing.Size(710, 101);
            this.gbNum.TabIndex = 0;
            this.gbNum.TabStop = false;
            this.gbNum.Text = "Номер";
            // 
            // cbState
            // 
            this.cbState.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(519, 46);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(185, 30);
            this.cbState.TabIndex = 4;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // cbType
            // 
            this.cbType.DataSource = this.internalTypeBindingSource;
            this.cbType.DisplayMember = "Name";
            this.cbType.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(448, 46);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(62, 30);
            this.cbType.TabIndex = 3;
            this.cbType.ValueMember = "Name";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // tbEndNum
            // 
            this.tbEndNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEndNum.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEndNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbEndNum.Location = new System.Drawing.Point(227, 47);
            this.tbEndNum.Name = "tbEndNum";
            this.tbEndNum.Size = new System.Drawing.Size(212, 29);
            this.tbEndNum.TabIndex = 2;
            this.tbEndNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEndNum_KeyDown);
            this.tbEndNum.Leave += new System.EventHandler(this.tbEndNum_Leave);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblState.Location = new System.Drawing.Point(515, 24);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(72, 19);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "Статус:";
            // 
            // lblTypeSegment
            // 
            this.lblTypeSegment.AutoSize = true;
            this.lblTypeSegment.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeSegment.Location = new System.Drawing.Point(444, 25);
            this.lblTypeSegment.Name = "lblTypeSegment";
            this.lblTypeSegment.Size = new System.Drawing.Size(45, 19);
            this.lblTypeSegment.TabIndex = 0;
            this.lblTypeSegment.Text = "Тип:";
            // 
            // lblEndNum
            // 
            this.lblEndNum.AutoSize = true;
            this.lblEndNum.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndNum.Location = new System.Drawing.Point(223, 25);
            this.lblEndNum.Name = "lblEndNum";
            this.lblEndNum.Size = new System.Drawing.Size(90, 19);
            this.lblEndNum.TabIndex = 0;
            this.lblEndNum.Text = "По номер:";
            // 
            // lblStartNum
            // 
            this.lblStartNum.AutoSize = true;
            this.lblStartNum.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartNum.Location = new System.Drawing.Point(6, 25);
            this.lblStartNum.Name = "lblStartNum";
            this.lblStartNum.Size = new System.Drawing.Size(90, 19);
            this.lblStartNum.TabIndex = 0;
            this.lblStartNum.Text = "С номера:";
            // 
            // tbStartNum
            // 
            this.tbStartNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbStartNum.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStartNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbStartNum.Location = new System.Drawing.Point(6, 47);
            this.tbStartNum.Name = "tbStartNum";
            this.tbStartNum.Size = new System.Drawing.Size(212, 29);
            this.tbStartNum.TabIndex = 1;
            this.tbStartNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbStartNum_KeyDown);
            this.tbStartNum.Leave += new System.EventHandler(this.tbStartNum_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::Barcodes.Properties.Resources.circle_x_3x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Barcodes.Properties.Resources.circle_check_3x;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(601, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // internalTypeBindingSource
            // 
            this.internalTypeBindingSource.DataSource = typeof(Barcodes.Libs.Models.InternalType);
            // 
            // AddSegmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(734, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbNum);
            this.Controls.Add(this.gbMonth);
            this.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 339);
            this.Name = "AddSegmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить диапазон";
            this.Load += new System.EventHandler(this.AddSegmentForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSegmentForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.gbMonth.ResumeLayout(false);
            this.gbMonth.PerformLayout();
            this.gbNum.ResumeLayout(false);
            this.gbNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internalTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblNumMonthRange;
        private System.Windows.Forms.Label lblNumMonthBarcode;
        private System.Windows.Forms.GroupBox gbMonth;
        private System.Windows.Forms.TextBox tbNumBarcode;
        private System.Windows.Forms.GroupBox gbNum;
        private System.Windows.Forms.TextBox tbEndNum;
        private System.Windows.Forms.Label lblEndNum;
        private System.Windows.Forms.Label lblStartNum;
        private System.Windows.Forms.TextBox tbStartNum;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblTypeSegment;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource internalTypeBindingSource;
    }
}