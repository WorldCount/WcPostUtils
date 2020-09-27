namespace PartStat.Forms
{
    partial class ReportMassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMassForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelMoscow = new System.Windows.Forms.Label();
            this.labelUnkown = new System.Windows.Forms.Label();
            this.lblMoscowCount = new System.Windows.Forms.Label();
            this.lblCityCount = new System.Windows.Forms.Label();
            this.lblUnkownCount = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelInter = new System.Windows.Forms.Label();
            this.lblInterCount = new System.Windows.Forms.Label();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView.Location = new System.Drawing.Point(1, 1);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.dataGridView.Size = new System.Drawing.Size(939, 360);
            this.dataGridView.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::PartStat.Properties.Resources.Printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(682, 407);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 40);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Печать";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::PartStat.Properties.Resources.white_cancel_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(808, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelCity
            // 
            this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(196, 426);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(86, 21);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "На города:";
            // 
            // labelMoscow
            // 
            this.labelMoscow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMoscow.AutoSize = true;
            this.labelMoscow.Location = new System.Drawing.Point(196, 405);
            this.labelMoscow.Name = "labelMoscow";
            this.labelMoscow.Size = new System.Drawing.Size(90, 21);
            this.labelMoscow.TabIndex = 14;
            this.labelMoscow.Text = "На Москву:";
            // 
            // labelUnkown
            // 
            this.labelUnkown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUnkown.AutoSize = true;
            this.labelUnkown.Location = new System.Drawing.Point(12, 405);
            this.labelUnkown.Name = "labelUnkown";
            this.labelUnkown.Size = new System.Drawing.Size(73, 21);
            this.labelUnkown.TabIndex = 14;
            this.labelUnkown.Text = "Ошибки:";
            // 
            // lblMoscowCount
            // 
            this.lblMoscowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMoscowCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoscowCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMoscowCount.Location = new System.Drawing.Point(292, 405);
            this.lblMoscowCount.Name = "lblMoscowCount";
            this.lblMoscowCount.Size = new System.Drawing.Size(70, 21);
            this.lblMoscowCount.TabIndex = 15;
            this.lblMoscowCount.Text = "0";
            // 
            // lblCityCount
            // 
            this.lblCityCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCityCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCityCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCityCount.Location = new System.Drawing.Point(292, 426);
            this.lblCityCount.Name = "lblCityCount";
            this.lblCityCount.Size = new System.Drawing.Size(70, 21);
            this.lblCityCount.TabIndex = 15;
            this.lblCityCount.Text = "0";
            // 
            // lblUnkownCount
            // 
            this.lblUnkownCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUnkownCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnkownCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUnkownCount.Location = new System.Drawing.Point(108, 405);
            this.lblUnkownCount.Name = "lblUnkownCount";
            this.lblUnkownCount.Size = new System.Drawing.Size(70, 21);
            this.lblUnkownCount.TabIndex = 15;
            this.lblUnkownCount.Text = "0";
            // 
            // labelIndex
            // 
            this.labelIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndex.Location = new System.Drawing.Point(12, 375);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(77, 21);
            this.labelIndex.TabIndex = 14;
            this.labelIndex.Text = "Индексы";
            // 
            // labelInter
            // 
            this.labelInter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInter.AutoSize = true;
            this.labelInter.Location = new System.Drawing.Point(12, 426);
            this.labelInter.Name = "labelInter";
            this.labelInter.Size = new System.Drawing.Size(48, 21);
            this.labelInter.TabIndex = 14;
            this.labelInter.Text = "Мжд:";
            // 
            // lblInterCount
            // 
            this.lblInterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInterCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInterCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblInterCount.Location = new System.Drawing.Point(108, 426);
            this.lblInterCount.Name = "lblInterCount";
            this.lblInterCount.Size = new System.Drawing.Size(70, 21);
            this.lblInterCount.TabIndex = 15;
            this.lblInterCount.Text = "0";
            // 
            // panelSeparator
            // 
            this.panelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSeparator.BackColor = System.Drawing.Color.SeaGreen;
            this.panelSeparator.Location = new System.Drawing.Point(16, 399);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(340, 2);
            this.panelSeparator.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Вид отправления";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 187;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Вес";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 187;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 188;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Плата";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 187;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 187;
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
            // ReportMassForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(940, 459);
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
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ReportMassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportMassForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportMassForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelMoscow;
        private System.Windows.Forms.Label labelUnkown;
        private System.Windows.Forms.Label lblMoscowCount;
        private System.Windows.Forms.Label lblCityCount;
        private System.Windows.Forms.Label lblUnkownCount;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelInter;
        private System.Windows.Forms.Label lblInterCount;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}