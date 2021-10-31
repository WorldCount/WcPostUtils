
namespace LK.Forms.ReportForms
{
    partial class CreateEditReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditReportForm));
            this.labelIdInfo = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.labelReportName = new System.Windows.Forms.Label();
            this.textBoxReportName = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.labelOrgReport = new System.Windows.Forms.Label();
            this.listBoxReportOrg = new System.Windows.Forms.ListBox();
            this.firmBindingSourceReportOrgs = new System.Windows.Forms.BindingSource(this.components);
            this.labelReportOrgCount = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.btnSave = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnCancel = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnClear = new Wc32Api.Widgets.Buttons.WcButton();
            this.textBoxFilter = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.labelOrgs = new System.Windows.Forms.Label();
            this.listBoxOrgs = new System.Windows.Forms.ListBox();
            this.firmBindingSourceOrgs = new System.Windows.Forms.BindingSource(this.components);
            this.labelOrgCount = new System.Windows.Forms.Label();
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
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(401, 12);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(131, 24);
            this.checkBoxEnabled.TabIndex = 0;
            this.checkBoxEnabled.Text = "Отчет включен";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // labelReportName
            // 
            this.labelReportName.AutoSize = true;
            this.labelReportName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReportName.ForeColor = System.Drawing.Color.DimGray;
            this.labelReportName.Location = new System.Drawing.Point(12, 52);
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
            this.textBoxReportName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxReportName.BorderHeight = 2;
            this.textBoxReportName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReportName.EnterColor = System.Drawing.Color.Firebrick;
            this.textBoxReportName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReportName.LeaveColor = System.Drawing.Color.SteelBlue;
            this.textBoxReportName.Location = new System.Drawing.Point(149, 48);
            this.textBoxReportName.Name = "textBoxReportName";
            this.textBoxReportName.Size = new System.Drawing.Size(383, 26);
            this.textBoxReportName.TabIndex = 1;
            // 
            // labelOrgReport
            // 
            this.labelOrgReport.AutoSize = true;
            this.labelOrgReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrgReport.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrgReport.Location = new System.Drawing.Point(12, 101);
            this.labelOrgReport.Name = "labelOrgReport";
            this.labelOrgReport.Size = new System.Drawing.Size(75, 20);
            this.labelOrgReport.TabIndex = 10;
            this.labelOrgReport.Text = "Отчет по:";
            this.labelOrgReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxReportOrg
            // 
            this.listBoxReportOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxReportOrg.DataSource = this.firmBindingSourceReportOrgs;
            this.listBoxReportOrg.DisplayMember = "ShortName";
            this.listBoxReportOrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.listBoxReportOrg.FormattingEnabled = true;
            this.listBoxReportOrg.ItemHeight = 20;
            this.listBoxReportOrg.Location = new System.Drawing.Point(12, 124);
            this.listBoxReportOrg.Name = "listBoxReportOrg";
            this.listBoxReportOrg.Size = new System.Drawing.Size(520, 204);
            this.listBoxReportOrg.TabIndex = 0;
            this.listBoxReportOrg.TabStop = false;
            this.listBoxReportOrg.ValueMember = "Id";
            this.listBoxReportOrg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxReportOrg_MouseDoubleClick);
            // 
            // firmBindingSourceReportOrgs
            // 
            this.firmBindingSourceReportOrgs.DataSource = typeof(LK.Core.Models.DB.Firm);
            // 
            // labelReportOrgCount
            // 
            this.labelReportOrgCount.AutoSize = true;
            this.labelReportOrgCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReportOrgCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelReportOrgCount.Location = new System.Drawing.Point(17, 331);
            this.labelReportOrgCount.Name = "labelReportOrgCount";
            this.labelReportOrgCount.Size = new System.Drawing.Size(21, 20);
            this.labelReportOrgCount.TabIndex = 0;
            this.labelReportOrgCount.Text = "-1";
            this.labelReportOrgCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilter.ForeColor = System.Drawing.Color.DimGray;
            this.labelFilter.Location = new System.Drawing.Point(12, 366);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(64, 20);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Фильтр:";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.BorderRadius = 4F;
            this.btnSave.BorderSize = 0;
            this.btnSave.DisableBackgroundColor = System.Drawing.Color.DimGray;
            this.btnSave.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::LK.Properties.Resources.save_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(412, 633);
            this.btnSave.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnSave.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSave.Size = new System.Drawing.Size(120, 46);
            this.btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 4F;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.DisableBackgroundColor = System.Drawing.Color.DimGray;
            this.btnCancel.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::LK.Properties.Resources.close_window_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 633);
            this.btnCancel.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnCancel.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(120, 46);
            this.btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnClear.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.BorderRadius = 4F;
            this.btnClear.BorderSize = 0;
            this.btnClear.DisableBackgroundColor = System.Drawing.Color.DimGray;
            this.btnClear.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::LK.Properties.Resources.trash_2_241;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(492, 356);
            this.btnClear.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnClear.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnClear.TabIndex = 0;
            this.btnClear.TabStop = false;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxFilter.BorderHeight = 2;
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFilter.EnterColor = System.Drawing.Color.Firebrick;
            this.textBoxFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilter.LeaveColor = System.Drawing.Color.SteelBlue;
            this.textBoxFilter.Location = new System.Drawing.Point(82, 362);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(404, 26);
            this.textBoxFilter.TabIndex = 0;
            this.textBoxFilter.TabStop = false;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // labelOrgs
            // 
            this.labelOrgs.AutoSize = true;
            this.labelOrgs.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrgs.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrgs.Location = new System.Drawing.Point(12, 415);
            this.labelOrgs.Name = "labelOrgs";
            this.labelOrgs.Size = new System.Drawing.Size(143, 20);
            this.labelOrgs.TabIndex = 0;
            this.labelOrgs.Text = "Добавить к отчету:";
            this.labelOrgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxOrgs
            // 
            this.listBoxOrgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOrgs.DataSource = this.firmBindingSourceOrgs;
            this.listBoxOrgs.DisplayMember = "ShortName";
            this.listBoxOrgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.listBoxOrgs.FormattingEnabled = true;
            this.listBoxOrgs.ItemHeight = 20;
            this.listBoxOrgs.Location = new System.Drawing.Point(12, 438);
            this.listBoxOrgs.Name = "listBoxOrgs";
            this.listBoxOrgs.Size = new System.Drawing.Size(520, 144);
            this.listBoxOrgs.TabIndex = 0;
            this.listBoxOrgs.TabStop = false;
            this.listBoxOrgs.ValueMember = "Id";
            this.listBoxOrgs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOrgs_MouseDoubleClick);
            // 
            // firmBindingSourceOrgs
            // 
            this.firmBindingSourceOrgs.DataSource = typeof(LK.Core.Models.DB.Firm);
            // 
            // labelOrgCount
            // 
            this.labelOrgCount.AutoSize = true;
            this.labelOrgCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrgCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelOrgCount.Location = new System.Drawing.Point(17, 585);
            this.labelOrgCount.Name = "labelOrgCount";
            this.labelOrgCount.Size = new System.Drawing.Size(21, 20);
            this.labelOrgCount.TabIndex = 0;
            this.labelOrgCount.Text = "-1";
            this.labelOrgCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateEditReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 691);
            this.Controls.Add(this.labelOrgCount);
            this.Controls.Add(this.listBoxOrgs);
            this.Controls.Add(this.labelOrgs);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelReportOrgCount);
            this.Controls.Add(this.listBoxReportOrg);
            this.Controls.Add(this.labelOrgReport);
            this.Controls.Add(this.textBoxReportName);
            this.Controls.Add(this.labelReportName);
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelIdInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(560, 730);
            this.Name = "CreateEditReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateEditReportForm";
            this.Load += new System.EventHandler(this.CreateEditReportForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateEditReportForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSourceReportOrgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSourceOrgs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdInfo;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.Label labelReportName;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox textBoxReportName;
        private System.Windows.Forms.Label labelOrgReport;
        private System.Windows.Forms.ListBox listBoxReportOrg;
        private System.Windows.Forms.Label labelReportOrgCount;
        private System.Windows.Forms.Label labelFilter;
        private Wc32Api.Widgets.Buttons.WcButton btnSave;
        private Wc32Api.Widgets.Buttons.WcButton btnCancel;
        private Wc32Api.Widgets.Buttons.WcButton btnClear;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox textBoxFilter;
        private System.Windows.Forms.Label labelOrgs;
        private System.Windows.Forms.ListBox listBoxOrgs;
        private System.Windows.Forms.Label labelOrgCount;
        private System.Windows.Forms.BindingSource firmBindingSourceReportOrgs;
        private System.Windows.Forms.BindingSource firmBindingSourceOrgs;
    }
}