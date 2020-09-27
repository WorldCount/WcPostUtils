namespace Installer.Forms
{
    partial class AppAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppAddForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAppId = new System.Windows.Forms.Label();
            this.tbAppId = new System.Windows.Forms.TextBox();
            this.lblRunFile = new System.Windows.Forms.Label();
            this.tbRunFile = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lblUri = new System.Windows.Forms.Label();
            this.tbUri = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDistrUrl = new System.Windows.Forms.TextBox();
            this.lblMd5 = new System.Windows.Forms.Label();
            this.tbMd5 = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.changeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInfo = new System.Windows.Forms.RichTextBox();
            this.Md5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIdDataGridViewTextBoxColumn,
            this.runFileDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.Md5,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.appInfoBindingSource;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dataGridView.Location = new System.Drawing.Point(12, 358);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 50;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(823, 165);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(720, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Location = new System.Drawing.Point(12, 22);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(49, 19);
            this.lblAppId.TabIndex = 2;
            this.lblAppId.Text = "AppId:";
            // 
            // tbAppId
            // 
            this.tbAppId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbAppId.Location = new System.Drawing.Point(67, 19);
            this.tbAppId.Name = "tbAppId";
            this.tbAppId.Size = new System.Drawing.Size(133, 25);
            this.tbAppId.TabIndex = 1;
            // 
            // lblRunFile
            // 
            this.lblRunFile.AutoSize = true;
            this.lblRunFile.Location = new System.Drawing.Point(218, 22);
            this.lblRunFile.Name = "lblRunFile";
            this.lblRunFile.Size = new System.Drawing.Size(56, 19);
            this.lblRunFile.TabIndex = 2;
            this.lblRunFile.Text = "RunFile:";
            // 
            // tbRunFile
            // 
            this.tbRunFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbRunFile.Location = new System.Drawing.Point(280, 19);
            this.tbRunFile.Name = "tbRunFile";
            this.tbRunFile.Size = new System.Drawing.Size(186, 25);
            this.tbRunFile.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbName.Location = new System.Drawing.Point(67, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(133, 25);
            this.tbName.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 107);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(41, 19);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Desc:";
            // 
            // tbDesc
            // 
            this.tbDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbDesc.Location = new System.Drawing.Point(67, 104);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(768, 25);
            this.tbDesc.TabIndex = 5;
            // 
            // lblUri
            // 
            this.lblUri.AutoSize = true;
            this.lblUri.Location = new System.Drawing.Point(494, 22);
            this.lblUri.Name = "lblUri";
            this.lblUri.Size = new System.Drawing.Size(30, 19);
            this.lblUri.TabIndex = 2;
            this.lblUri.Text = "Uri:";
            // 
            // tbUri
            // 
            this.tbUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbUri.Location = new System.Drawing.Point(530, 19);
            this.tbUri.Name = "tbUri";
            this.tbUri.Size = new System.Drawing.Size(184, 25);
            this.tbUri.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(217, 64);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 19);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version:";
            // 
            // tbVersion
            // 
            this.tbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbVersion.Location = new System.Drawing.Point(280, 61);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(186, 25);
            this.tbVersion.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(720, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbDistrUrl
            // 
            this.tbDistrUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDistrUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbDistrUrl.Location = new System.Drawing.Point(12, 538);
            this.tbDistrUrl.Name = "tbDistrUrl";
            this.tbDistrUrl.Size = new System.Drawing.Size(554, 25);
            this.tbDistrUrl.TabIndex = 0;
            this.tbDistrUrl.TabStop = false;
            // 
            // lblMd5
            // 
            this.lblMd5.AutoSize = true;
            this.lblMd5.Location = new System.Drawing.Point(483, 64);
            this.lblMd5.Name = "lblMd5";
            this.lblMd5.Size = new System.Drawing.Size(41, 19);
            this.lblMd5.TabIndex = 2;
            this.lblMd5.Text = "Md5:";
            // 
            // tbMd5
            // 
            this.tbMd5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMd5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbMd5.Location = new System.Drawing.Point(530, 61);
            this.tbMd5.Name = "tbMd5";
            this.tbMd5.Size = new System.Drawing.Size(184, 25);
            this.tbMd5.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(25, 152);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(36, 19);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Info:";
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMenuItem,
            this.toolStripSeparator2,
            this.loadMenuItem,
            this.toolStripSeparator1,
            this.deleteMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(160, 106);
            this.contextMenu.Text = "Контекстное меню";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Image = global::Installer.Properties.Resources.Cloud_Download;
            this.btnLoad.Location = new System.Drawing.Point(572, 531);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(36, 36);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.TabStop = false;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.Image = global::Installer.Properties.Resources.View;
            this.btnChoose.Location = new System.Drawing.Point(720, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(112, 36);
            this.btnChoose.TabIndex = 7;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // changeMenuItem
            // 
            this.changeMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.changeMenuItem.Image = global::Installer.Properties.Resources.Button_More;
            this.changeMenuItem.Name = "changeMenuItem";
            this.changeMenuItem.Size = new System.Drawing.Size(159, 30);
            this.changeMenuItem.Text = "Изменить";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Image = global::Installer.Properties.Resources.Repeat;
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(159, 30);
            this.loadMenuItem.Text = "Загрузить";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.deleteMenuItem.Image = global::Installer.Properties.Resources.Button_Close;
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(159, 30);
            this.deleteMenuItem.Text = "Удалить";
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbInfo.Font = new System.Drawing.Font("Consolas", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo.ForeColor = System.Drawing.Color.Silver;
            this.tbInfo.Location = new System.Drawing.Point(67, 149);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.tbInfo.Size = new System.Drawing.Size(768, 203);
            this.tbInfo.TabIndex = 9;
            this.tbInfo.Text = "";
            this.tbInfo.WordWrap = false;
            // 
            // Md5
            // 
            this.Md5.DataPropertyName = "Md5";
            this.Md5.HeaderText = "Md5";
            this.Md5.Name = "Md5";
            this.Md5.ReadOnly = true;
            // 
            // appIdDataGridViewTextBoxColumn
            // 
            this.appIdDataGridViewTextBoxColumn.DataPropertyName = "AppId";
            this.appIdDataGridViewTextBoxColumn.HeaderText = "AppId";
            this.appIdDataGridViewTextBoxColumn.Name = "appIdDataGridViewTextBoxColumn";
            this.appIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runFileDataGridViewTextBoxColumn
            // 
            this.runFileDataGridViewTextBoxColumn.DataPropertyName = "RunFile";
            this.runFileDataGridViewTextBoxColumn.HeaderText = "RunFile";
            this.runFileDataGridViewTextBoxColumn.Name = "runFileDataGridViewTextBoxColumn";
            this.runFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appInfoBindingSource
            // 
            this.appInfoBindingSource.DataSource = typeof(Installer.Models.AppInfo);
            // 
            // AppAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 579);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbDistrUrl);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.tbMd5);
            this.Controls.Add(this.tbUri);
            this.Controls.Add(this.lblMd5);
            this.Controls.Add(this.lblUri);
            this.Controls.Add(this.tbRunFile);
            this.Controls.Add(this.lblRunFile);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbAppId);
            this.Controls.Add(this.lblAppId);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AppAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Приложения";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox tbAppId;
        private System.Windows.Forms.Label lblRunFile;
        private System.Windows.Forms.TextBox tbRunFile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lblUri;
        private System.Windows.Forms.TextBox tbUri;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.BindingSource appInfoBindingSource;
        private System.Windows.Forms.TextBox tbDistrUrl;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblMd5;
        private System.Windows.Forms.TextBox tbMd5;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Md5;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem changeMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.RichTextBox tbInfo;
    }
}