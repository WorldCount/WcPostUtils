namespace PartStat.Forms.ReportForms
{
    partial class CreateReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReportForm));
            this.labelIdInfo = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelReportName = new System.Windows.Forms.Label();
            this.textBoxReportName = new System.Windows.Forms.TextBox();
            this.listBoxReportOrg = new System.Windows.Forms.ListBox();
            this.firmBindingSourceReportOrgs = new System.Windows.Forms.BindingSource(this.components);
            this.labelOrgReport = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.listBoxOrgs = new System.Windows.Forms.ListBox();
            this.firmBindingSourceOrgs = new System.Windows.Forms.BindingSource(this.components);
            this.labelOrgs = new System.Windows.Forms.Label();
            this.labelOrgCount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.labelReportOrgCount = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSourceReportOrgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSourceOrgs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdInfo
            // 
            this.labelIdInfo.AutoSize = true;
            this.labelIdInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelIdInfo.Location = new System.Drawing.Point(12, 9);
            this.labelIdInfo.Name = "labelIdInfo";
            this.labelIdInfo.Size = new System.Drawing.Size(26, 20);
            this.labelIdInfo.TabIndex = 0;
            this.labelIdInfo.Text = "Id:";
            this.labelIdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelId.Location = new System.Drawing.Point(44, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "-1";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReportName
            // 
            this.labelReportName.AutoSize = true;
            this.labelReportName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReportName.ForeColor = System.Drawing.Color.DimGray;
            this.labelReportName.Location = new System.Drawing.Point(12, 40);
            this.labelReportName.Name = "labelReportName";
            this.labelReportName.Size = new System.Drawing.Size(131, 20);
            this.labelReportName.TabIndex = 0;
            this.labelReportName.Text = "Название отчета:";
            this.labelReportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReportName
            // 
            this.textBoxReportName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportName.BackColor = System.Drawing.Color.White;
            this.textBoxReportName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReportName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.textBoxReportName.Location = new System.Drawing.Point(149, 38);
            this.textBoxReportName.Name = "textBoxReportName";
            this.textBoxReportName.Size = new System.Drawing.Size(319, 27);
            this.textBoxReportName.TabIndex = 1;
            this.textBoxReportName.Text = "Новый отчет";
            // 
            // listBoxReportOrg
            // 
            this.listBoxReportOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxReportOrg.DataSource = this.firmBindingSourceReportOrgs;
            this.listBoxReportOrg.DisplayMember = "Name";
            this.listBoxReportOrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.listBoxReportOrg.FormattingEnabled = true;
            this.listBoxReportOrg.ItemHeight = 20;
            this.listBoxReportOrg.Location = new System.Drawing.Point(16, 100);
            this.listBoxReportOrg.Name = "listBoxReportOrg";
            this.listBoxReportOrg.Size = new System.Drawing.Size(452, 204);
            this.listBoxReportOrg.TabIndex = 2;
            this.listBoxReportOrg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxReportOrg_MouseDoubleClick);
            // 
            // firmBindingSourceReportOrgs
            // 
            this.firmBindingSourceReportOrgs.DataSource = typeof(PartStat.Core.Models.DB.Firm);
            // 
            // labelOrgReport
            // 
            this.labelOrgReport.AutoSize = true;
            this.labelOrgReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrgReport.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrgReport.Location = new System.Drawing.Point(12, 77);
            this.labelOrgReport.Name = "labelOrgReport";
            this.labelOrgReport.Size = new System.Drawing.Size(75, 20);
            this.labelOrgReport.TabIndex = 0;
            this.labelOrgReport.Text = "Отчет по:";
            this.labelOrgReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilter.ForeColor = System.Drawing.Color.DimGray;
            this.labelFilter.Location = new System.Drawing.Point(12, 354);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(64, 20);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Фильтр:";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.BackColor = System.Drawing.Color.White;
            this.textBoxFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.textBoxFilter.Location = new System.Drawing.Point(82, 351);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(348, 27);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // listBoxOrgs
            // 
            this.listBoxOrgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOrgs.DataSource = this.firmBindingSourceOrgs;
            this.listBoxOrgs.DisplayMember = "Name";
            this.listBoxOrgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.listBoxOrgs.FormattingEnabled = true;
            this.listBoxOrgs.ItemHeight = 20;
            this.listBoxOrgs.Location = new System.Drawing.Point(16, 404);
            this.listBoxOrgs.Name = "listBoxOrgs";
            this.listBoxOrgs.Size = new System.Drawing.Size(452, 144);
            this.listBoxOrgs.TabIndex = 2;
            this.listBoxOrgs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOrgs_MouseDoubleClick);
            // 
            // firmBindingSourceOrgs
            // 
            this.firmBindingSourceOrgs.DataSource = typeof(PartStat.Core.Models.DB.Firm);
            // 
            // labelOrgs
            // 
            this.labelOrgs.AutoSize = true;
            this.labelOrgs.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrgs.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrgs.Location = new System.Drawing.Point(12, 381);
            this.labelOrgs.Name = "labelOrgs";
            this.labelOrgs.Size = new System.Drawing.Size(143, 20);
            this.labelOrgs.TabIndex = 0;
            this.labelOrgs.Text = "Добавить к отчету:";
            this.labelOrgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrgCount
            // 
            this.labelOrgCount.AutoSize = true;
            this.labelOrgCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrgCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelOrgCount.Location = new System.Drawing.Point(12, 551);
            this.labelOrgCount.Name = "labelOrgCount";
            this.labelOrgCount.Size = new System.Drawing.Size(21, 20);
            this.labelOrgCount.TabIndex = 3;
            this.labelOrgCount.Text = "-1";
            this.labelOrgCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PartStat.Properties.Resources.white_ok_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(348, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::PartStat.Properties.Resources.white_cancel_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 589);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(337, 8);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(131, 24);
            this.checkBoxEnabled.TabIndex = 6;
            this.checkBoxEnabled.Text = "Отчет включен";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBoxEnabled_CheckedChanged);
            // 
            // labelReportOrgCount
            // 
            this.labelReportOrgCount.AutoSize = true;
            this.labelReportOrgCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReportOrgCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelReportOrgCount.Location = new System.Drawing.Point(12, 307);
            this.labelReportOrgCount.Name = "labelReportOrgCount";
            this.labelReportOrgCount.Size = new System.Drawing.Size(21, 20);
            this.labelReportOrgCount.TabIndex = 7;
            this.labelReportOrgCount.Text = "-1";
            this.labelReportOrgCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Image = global::PartStat.Properties.Resources.white_restart_24;
            this.buttonClear.Location = new System.Drawing.Point(436, 348);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(32, 32);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.TabStop = false;
            this.buttonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // CreateReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 641);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelReportOrgCount);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelOrgCount);
            this.Controls.Add(this.listBoxOrgs);
            this.Controls.Add(this.listBoxReportOrg);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.textBoxReportName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelOrgs);
            this.Controls.Add(this.labelOrgReport);
            this.Controls.Add(this.labelReportName);
            this.Controls.Add(this.labelIdInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(500, 680);
            this.Name = "CreateReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateReportForm";
            this.Load += new System.EventHandler(this.CreateReportForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateReportForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSourceReportOrgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSourceOrgs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdInfo;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelReportName;
        private System.Windows.Forms.TextBox textBoxReportName;
        private System.Windows.Forms.ListBox listBoxReportOrg;
        private System.Windows.Forms.BindingSource firmBindingSourceReportOrgs;
        private System.Windows.Forms.Label labelOrgReport;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ListBox listBoxOrgs;
        private System.Windows.Forms.Label labelOrgs;
        private System.Windows.Forms.BindingSource firmBindingSourceOrgs;
        private System.Windows.Forms.Label labelOrgCount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.Label labelReportOrgCount;
        private System.Windows.Forms.Button buttonClear;
    }
}