namespace LK.Forms.ReportForms
{
    partial class OperatorReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorReportForm));
            this.labelOrg = new System.Windows.Forms.Label();
            this.comboBoxOrgs = new System.Windows.Forms.ComboBox();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoad = new Wc32Api.Widgets.Buttons.WcButton();
            this.labelCopy = new System.Windows.Forms.Label();
            this.numericUpDownCopy = new System.Windows.Forms.NumericUpDown();
            this.btnPrint = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnCancel = new Wc32Api.Widgets.Buttons.WcButton();
            this.labelDateOut = new System.Windows.Forms.Label();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.OperColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RpoCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanPercentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrg.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrg.Location = new System.Drawing.Point(12, 9);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(138, 21);
            this.labelOrg.TabIndex = 16;
            this.labelOrg.Text = "По организации:";
            // 
            // comboBoxOrgs
            // 
            this.comboBoxOrgs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxOrgs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxOrgs.BackColor = System.Drawing.Color.White;
            this.comboBoxOrgs.DataSource = this.firmBindingSource;
            this.comboBoxOrgs.DisplayMember = "ShortName";
            this.comboBoxOrgs.DropDownHeight = 200;
            this.comboBoxOrgs.DropDownWidth = 300;
            this.comboBoxOrgs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOrgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.comboBoxOrgs.FormattingEnabled = true;
            this.comboBoxOrgs.IntegralHeight = false;
            this.comboBoxOrgs.Location = new System.Drawing.Point(16, 33);
            this.comboBoxOrgs.Name = "comboBoxOrgs";
            this.comboBoxOrgs.Size = new System.Drawing.Size(300, 29);
            this.comboBoxOrgs.TabIndex = 15;
            this.comboBoxOrgs.ValueMember = "Id";
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataSource = typeof(LK.Core.Models.DB.Firm);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperColumn,
            this.FirmCountColumn,
            this.ListCountColumn,
            this.RpoCountColumn,
            this.ScanCountColumn,
            this.ScanPercentColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 77);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowTemplate.Height = 34;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(933, 303);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoad.BorderColor = System.Drawing.Color.Silver;
            this.btnLoad.BorderRadius = 4F;
            this.btnLoad.BorderSize = 0;
            this.btnLoad.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoad.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = global::LK.Properties.Resources.white_synchronize_24;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(740, 24);
            this.btnLoad.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoad.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoad.Size = new System.Drawing.Size(127, 46);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.TextColor = System.Drawing.Color.White;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // labelCopy
            // 
            this.labelCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCopy.AutoSize = true;
            this.labelCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelCopy.Location = new System.Drawing.Point(12, 406);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(54, 20);
            this.labelCopy.TabIndex = 19;
            this.labelCopy.Text = "Копии";
            // 
            // numericUpDownCopy
            // 
            this.numericUpDownCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.numericUpDownCopy.Location = new System.Drawing.Point(72, 402);
            this.numericUpDownCopy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCopy.Name = "numericUpDownCopy";
            this.numericUpDownCopy.Size = new System.Drawing.Size(69, 29);
            this.numericUpDownCopy.TabIndex = 20;
            this.numericUpDownCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCopy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.BorderColor = System.Drawing.Color.Silver;
            this.btnPrint.BorderRadius = 4F;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnPrint.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::LK.Properties.Resources.Printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(676, 392);
            this.btnPrint.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnPrint.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnPrint.Size = new System.Drawing.Size(120, 46);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Печать";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 4F;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnCancel.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::LK.Properties.Resources.close_window_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(802, 392);
            this.btnCancel.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnCancel.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(120, 46);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelDateOut
            // 
            this.labelDateOut.AutoSize = true;
            this.labelDateOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelDateOut.Location = new System.Drawing.Point(530, 9);
            this.labelDateOut.Name = "labelDateOut";
            this.labelDateOut.Size = new System.Drawing.Size(72, 21);
            this.labelDateOut.TabIndex = 25;
            this.labelDateOut.Text = "По дату:";
            // 
            // lblDateIn
            // 
            this.lblDateIn.AutoSize = true;
            this.lblDateIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateIn.ForeColor = System.Drawing.Color.DimGray;
            this.lblDateIn.Location = new System.Drawing.Point(322, 9);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(64, 21);
            this.lblDateIn.TabIndex = 26;
            this.lblDateIn.Text = "С даты:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePickerOut.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerOut.CustomFormat = "";
            this.dateTimePickerOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerOut.Location = new System.Drawing.Point(534, 33);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerOut.TabIndex = 24;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePickerIn.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerIn.CustomFormat = "";
            this.dateTimePickerIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerIn.Location = new System.Drawing.Point(322, 33);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerIn.TabIndex = 23;
            this.dateTimePickerIn.ValueChanged += new System.EventHandler(this.dateTimePickerIn_ValueChanged);
            // 
            // OperColumn
            // 
            this.OperColumn.HeaderText = "Оператор";
            this.OperColumn.MinimumWidth = 6;
            this.OperColumn.Name = "OperColumn";
            this.OperColumn.ReadOnly = true;
            this.OperColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FirmCountColumn
            // 
            this.FirmCountColumn.HeaderText = "Организаций";
            this.FirmCountColumn.Name = "FirmCountColumn";
            this.FirmCountColumn.ReadOnly = true;
            this.FirmCountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ListCountColumn
            // 
            this.ListCountColumn.HeaderText = "Списков";
            this.ListCountColumn.Name = "ListCountColumn";
            this.ListCountColumn.ReadOnly = true;
            this.ListCountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RpoCountColumn
            // 
            this.RpoCountColumn.HeaderText = "Отправлений";
            this.RpoCountColumn.MinimumWidth = 6;
            this.RpoCountColumn.Name = "RpoCountColumn";
            this.RpoCountColumn.ReadOnly = true;
            this.RpoCountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ScanCountColumn
            // 
            this.ScanCountColumn.HeaderText = "Отсканировано";
            this.ScanCountColumn.Name = "ScanCountColumn";
            this.ScanCountColumn.ReadOnly = true;
            // 
            // ScanPercentColumn
            // 
            this.ScanPercentColumn.HeaderText = "Процент";
            this.ScanPercentColumn.Name = "ScanPercentColumn";
            this.ScanPercentColumn.ReadOnly = true;
            // 
            // OperatorReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.labelDateOut);
            this.Controls.Add(this.lblDateIn);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.dateTimePickerIn);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.numericUpDownCopy);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelOrg);
            this.Controls.Add(this.comboBoxOrgs);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "OperatorReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OperatorReportForm";
            this.Load += new System.EventHandler(this.ValueReportForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueReportForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.ComboBox comboBoxOrgs;
        private System.Windows.Forms.DataGridView dataGridView;
        private Wc32Api.Widgets.Buttons.WcButton btnLoad;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.NumericUpDown numericUpDownCopy;
        private Wc32Api.Widgets.Buttons.WcButton btnPrint;
        private Wc32Api.Widgets.Buttons.WcButton btnCancel;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private System.Windows.Forms.Label labelDateOut;
        private System.Windows.Forms.Label lblDateIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RpoCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanPercentColumn;
    }
}