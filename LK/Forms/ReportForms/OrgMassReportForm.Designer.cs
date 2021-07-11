namespace LK.Forms.ReportForms
{
    partial class OrgMassReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrgMassReportForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MailTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.lblInterCount = new System.Windows.Forms.Label();
            this.lblUnkownCount = new System.Windows.Forms.Label();
            this.lblCityCount = new System.Windows.Forms.Label();
            this.lblMoscowCount = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelMoscow = new System.Windows.Forms.Label();
            this.labelInter = new System.Windows.Forms.Label();
            this.labelUnkown = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.btnPrint = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnClose = new Wc32Api.Widgets.Buttons.WcButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.MailTypeDataGridViewTextBoxColumn,
            this.MassDataGridViewTextBoxColumn,
            this.CountDataGridViewTextBoxColumn,
            this.RateDataGridViewTextBoxColumn,
            this.SumRateDataGridViewTextBoxColumn});
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
            this.dataGridView.Location = new System.Drawing.Point(0, -1);
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
            this.dataGridView.Size = new System.Drawing.Size(805, 360);
            this.dataGridView.TabIndex = 7;
            // 
            // MailTypeDataGridViewTextBoxColumn
            // 
            this.MailTypeDataGridViewTextBoxColumn.HeaderText = "Вид отправления";
            this.MailTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.MailTypeDataGridViewTextBoxColumn.Name = "MailTypeDataGridViewTextBoxColumn";
            this.MailTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.MailTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MassDataGridViewTextBoxColumn
            // 
            this.MassDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.MassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.MassDataGridViewTextBoxColumn.Name = "MassDataGridViewTextBoxColumn";
            this.MassDataGridViewTextBoxColumn.ReadOnly = true;
            this.MassDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CountDataGridViewTextBoxColumn
            // 
            this.CountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.CountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.CountDataGridViewTextBoxColumn.Name = "CountDataGridViewTextBoxColumn";
            this.CountDataGridViewTextBoxColumn.ReadOnly = true;
            this.CountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RateDataGridViewTextBoxColumn
            // 
            this.RateDataGridViewTextBoxColumn.HeaderText = "Плата";
            this.RateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn";
            this.RateDataGridViewTextBoxColumn.ReadOnly = true;
            this.RateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SumRateDataGridViewTextBoxColumn
            // 
            this.SumRateDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.SumRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.SumRateDataGridViewTextBoxColumn.Name = "SumRateDataGridViewTextBoxColumn";
            this.SumRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.SumRateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelSeparator
            // 
            this.panelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSeparator.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelSeparator.Location = new System.Drawing.Point(16, 401);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(340, 2);
            this.panelSeparator.TabIndex = 26;
            // 
            // lblInterCount
            // 
            this.lblInterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInterCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInterCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblInterCount.Location = new System.Drawing.Point(108, 428);
            this.lblInterCount.Name = "lblInterCount";
            this.lblInterCount.Size = new System.Drawing.Size(70, 21);
            this.lblInterCount.TabIndex = 22;
            this.lblInterCount.Text = "0";
            // 
            // lblUnkownCount
            // 
            this.lblUnkownCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUnkownCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnkownCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUnkownCount.Location = new System.Drawing.Point(108, 407);
            this.lblUnkownCount.Name = "lblUnkownCount";
            this.lblUnkownCount.Size = new System.Drawing.Size(70, 21);
            this.lblUnkownCount.TabIndex = 23;
            this.lblUnkownCount.Text = "0";
            // 
            // lblCityCount
            // 
            this.lblCityCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCityCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCityCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCityCount.Location = new System.Drawing.Point(292, 428);
            this.lblCityCount.Name = "lblCityCount";
            this.lblCityCount.Size = new System.Drawing.Size(70, 21);
            this.lblCityCount.TabIndex = 24;
            this.lblCityCount.Text = "0";
            // 
            // lblMoscowCount
            // 
            this.lblMoscowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMoscowCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoscowCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMoscowCount.Location = new System.Drawing.Point(292, 407);
            this.lblMoscowCount.Name = "lblMoscowCount";
            this.lblMoscowCount.Size = new System.Drawing.Size(70, 21);
            this.lblMoscowCount.TabIndex = 25;
            this.lblMoscowCount.Text = "0";
            // 
            // labelIndex
            // 
            this.labelIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndex.Location = new System.Drawing.Point(12, 377);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(73, 20);
            this.labelIndex.TabIndex = 17;
            this.labelIndex.Text = "Индексы";
            // 
            // labelMoscow
            // 
            this.labelMoscow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMoscow.AutoSize = true;
            this.labelMoscow.Location = new System.Drawing.Point(196, 407);
            this.labelMoscow.Name = "labelMoscow";
            this.labelMoscow.Size = new System.Drawing.Size(86, 20);
            this.labelMoscow.TabIndex = 18;
            this.labelMoscow.Text = "На Москву:";
            // 
            // labelInter
            // 
            this.labelInter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInter.AutoSize = true;
            this.labelInter.Location = new System.Drawing.Point(12, 428);
            this.labelInter.Name = "labelInter";
            this.labelInter.Size = new System.Drawing.Size(44, 20);
            this.labelInter.TabIndex = 19;
            this.labelInter.Text = "Мжд:";
            // 
            // labelUnkown
            // 
            this.labelUnkown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUnkown.AutoSize = true;
            this.labelUnkown.Location = new System.Drawing.Point(12, 407);
            this.labelUnkown.Name = "labelUnkown";
            this.labelUnkown.Size = new System.Drawing.Size(69, 20);
            this.labelUnkown.TabIndex = 20;
            this.labelUnkown.Text = "Ошибки:";
            // 
            // labelCity
            // 
            this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(196, 428);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(84, 20);
            this.labelCity.TabIndex = 21;
            this.labelCity.Text = "На города:";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.BorderColor = System.Drawing.Color.Silver;
            this.btnPrint.BorderRadius = 4;
            this.btnPrint.BorderThickness = 1F;
            this.btnPrint.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::LK.Properties.Resources.Printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(546, 403);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnPrint.Size = new System.Drawing.Size(120, 46);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "Печать";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.BorderRadius = 4;
            this.btnClose.BorderThickness = 1F;
            this.btnClose.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::LK.Properties.Resources.close_window_24;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(672, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnClose.Size = new System.Drawing.Size(120, 46);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Закрыть";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OrgMassReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.lblInterCount);
            this.Controls.Add(this.lblUnkownCount);
            this.Controls.Add(this.lblCityCount);
            this.Controls.Add(this.lblMoscowCount);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelMoscow);
            this.Controls.Add(this.labelInter);
            this.Controls.Add(this.labelUnkown);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "OrgMassReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrgMassReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrgMassReportForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.Label lblInterCount;
        private System.Windows.Forms.Label lblUnkownCount;
        private System.Windows.Forms.Label lblCityCount;
        private System.Windows.Forms.Label lblMoscowCount;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelMoscow;
        private System.Windows.Forms.Label labelInter;
        private System.Windows.Forms.Label labelUnkown;
        private System.Windows.Forms.Label labelCity;
        private Wc32Api.Widgets.Buttons.WcButton btnPrint;
        private Wc32Api.Widgets.Buttons.WcButton btnClose;
    }
}