namespace Installer.Forms
{
    partial class GeneralForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInstall = new System.Windows.Forms.TabPage();
            this.dataGridViewInstall = new System.Windows.Forms.DataGridView();
            this.NeedUpdateValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAvailable = new System.Windows.Forms.TabPage();
            this.dataGridViewRepo = new System.Windows.Forms.DataGridView();
            this.InstallValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.tbInstallDir = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.contextMenuRepo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bgWorkerGetRepo = new System.ComponentModel.BackgroundWorker();
            this.contextMenuInstall = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoInstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.updInfoInstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoRepoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installRepoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRepoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallRepoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRepoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runInstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirInstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLinkInstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallInstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshInstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updInfoRepoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appInfoInstallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appInfoRepoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabInstall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstall)).BeginInit();
            this.tabAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).BeginInit();
            this.contextMenuRepo.SuspendLayout();
            this.contextMenuInstall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appInfoInstallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appInfoRepoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.status.Location = new System.Drawing.Point(0, 316);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(855, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(712, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(128, 17);
            this.statusAuthor.Text = "WorldCount, 2019 ©";
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.configMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(855, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Меню";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabInstall);
            this.tabControl.Controls.Add(this.tabAvailable);
            this.tabControl.ImageList = this.imageListIcon;
            this.tabControl.ItemSize = new System.Drawing.Size(170, 45);
            this.tabControl.Location = new System.Drawing.Point(0, 73);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(855, 240);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tabInstall
            // 
            this.tabInstall.BackColor = System.Drawing.Color.Transparent;
            this.tabInstall.Controls.Add(this.dataGridViewInstall);
            this.tabInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tabInstall.ImageIndex = 0;
            this.tabInstall.Location = new System.Drawing.Point(4, 49);
            this.tabInstall.Name = "tabInstall";
            this.tabInstall.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstall.Size = new System.Drawing.Size(847, 187);
            this.tabInstall.TabIndex = 0;
            this.tabInstall.Text = "   Установлено";
            // 
            // dataGridViewInstall
            // 
            this.dataGridViewInstall.AllowUserToAddRows = false;
            this.dataGridViewInstall.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInstall.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInstall.AutoGenerateColumns = false;
            this.dataGridViewInstall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInstall.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInstall.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInstall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.versionDataGridViewTextBoxColumn1,
            this.runFileDataGridViewTextBoxColumn,
            this.NeedUpdateValue});
            this.dataGridViewInstall.DataSource = this.appInfoInstallBindingSource;
            this.dataGridViewInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInstall.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dataGridViewInstall.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewInstall.MultiSelect = false;
            this.dataGridViewInstall.Name = "dataGridViewInstall";
            this.dataGridViewInstall.ReadOnly = true;
            this.dataGridViewInstall.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewInstall.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInstall.RowTemplate.Height = 50;
            this.dataGridViewInstall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInstall.Size = new System.Drawing.Size(841, 181);
            this.dataGridViewInstall.TabIndex = 0;
            this.dataGridViewInstall.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInstall_CellFormatting);
            this.dataGridViewInstall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewInstall_MouseClick);
            // 
            // NeedUpdateValue
            // 
            this.NeedUpdateValue.DataPropertyName = "NeedUpdateValue";
            this.NeedUpdateValue.HeaderText = "Есть обновление";
            this.NeedUpdateValue.Name = "NeedUpdateValue";
            this.NeedUpdateValue.ReadOnly = true;
            // 
            // tabAvailable
            // 
            this.tabAvailable.Controls.Add(this.dataGridViewRepo);
            this.tabAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tabAvailable.ImageIndex = 1;
            this.tabAvailable.Location = new System.Drawing.Point(4, 49);
            this.tabAvailable.Name = "tabAvailable";
            this.tabAvailable.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailable.Size = new System.Drawing.Size(847, 187);
            this.tabAvailable.TabIndex = 1;
            this.tabAvailable.Text = "   Доступно";
            this.tabAvailable.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRepo
            // 
            this.dataGridViewRepo.AllowUserToAddRows = false;
            this.dataGridViewRepo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRepo.AutoGenerateColumns = false;
            this.dataGridViewRepo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRepo.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.InstallValue});
            this.dataGridViewRepo.DataSource = this.appInfoRepoBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRepo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dataGridViewRepo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRepo.MultiSelect = false;
            this.dataGridViewRepo.Name = "dataGridViewRepo";
            this.dataGridViewRepo.ReadOnly = true;
            this.dataGridViewRepo.RowTemplate.Height = 50;
            this.dataGridViewRepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepo.Size = new System.Drawing.Size(841, 181);
            this.dataGridViewRepo.TabIndex = 0;
            this.dataGridViewRepo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewNotInstall_CellFormatting);
            this.dataGridViewRepo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRepo_MouseClick);
            // 
            // InstallValue
            // 
            this.InstallValue.DataPropertyName = "InstallValue";
            this.InstallValue.HeaderText = "Установлено";
            this.InstallValue.Name = "InstallValue";
            this.InstallValue.ReadOnly = true;
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "Folder-Checked-2.png");
            this.imageListIcon.Images.SetKeyName(1, "Folder-Cloud.png");
            // 
            // tbInstallDir
            // 
            this.tbInstallDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInstallDir.Enabled = false;
            this.tbInstallDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbInstallDir.Location = new System.Drawing.Point(163, 40);
            this.tbInstallDir.Name = "tbInstallDir";
            this.tbInstallDir.Size = new System.Drawing.Size(680, 27);
            this.tbInstallDir.TabIndex = 2;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.lblDir.Location = new System.Drawing.Point(12, 43);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(134, 21);
            this.lblDir.TabIndex = 3;
            this.lblDir.Text = "Папка установки:";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // contextMenuRepo
            // 
            this.contextMenuRepo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuRepo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.infoRepoMenuItem,
            this.toolStripSeparator1,
            this.updInfoRepoMenuItem,
            this.toolStripSeparator8,
            this.installRepoMenuItem,
            this.updateRepoMenuItem,
            this.uninstallRepoMenuItem,
            this.toolStripSeparator3,
            this.refreshRepoMenuItem});
            this.contextMenuRepo.Name = "contextMenuNotInstall";
            this.contextMenuRepo.Size = new System.Drawing.Size(263, 232);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(259, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(259, 6);
            // 
            // contextMenuInstall
            // 
            this.contextMenuInstall.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuInstall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoInstallMenuItem,
            this.toolStripSeparator4,
            this.runInstallMenuItem,
            this.openDirInstallMenuItem,
            this.createLinkInstallMenuItem,
            this.toolStripSeparator7,
            this.updInfoInstallMenuItem,
            this.toolStripSeparator5,
            this.updateInstallMenuItem,
            this.uninstallInstallMenuItem,
            this.toolStripSeparator6,
            this.refreshInstallMenuItem});
            this.contextMenuInstall.Name = "contextMenuInstall";
            this.contextMenuInstall.Size = new System.Drawing.Size(253, 268);
            // 
            // infoInstallMenuItem
            // 
            this.infoInstallMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold);
            this.infoInstallMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.infoInstallMenuItem.Name = "infoInstallMenuItem";
            this.infoInstallMenuItem.Size = new System.Drawing.Size(252, 30);
            this.infoInstallMenuItem.Text = "info";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(249, 6);
            // 
            // updInfoInstallMenuItem
            // 
            this.updInfoInstallMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updInfoInstallMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.updInfoInstallMenuItem.Image = global::Installer.Properties.Resources.Dashboard;
            this.updInfoInstallMenuItem.Name = "updInfoInstallMenuItem";
            this.updInfoInstallMenuItem.Size = new System.Drawing.Size(252, 30);
            this.updInfoInstallMenuItem.Text = "Информация";
            this.updInfoInstallMenuItem.Click += new System.EventHandler(this.updInfoInstallMenuItem_Click);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.fileMenuItem.Image = global::Installer.Properties.Resources.File_Picture;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(83, 28);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exitMenuItem.Image = global::Installer.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(133, 30);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // configMenuItem
            // 
            this.configMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appMenuItem,
            this.settingsMenuItem});
            this.configMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.configMenuItem.Image = global::Installer.Properties.Resources.Button_Settings;
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(123, 28);
            this.configMenuItem.Text = "Настройки";
            // 
            // appMenuItem
            // 
            this.appMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appMenuItem.Image = global::Installer.Properties.Resources.Dashboard;
            this.appMenuItem.Name = "appMenuItem";
            this.appMenuItem.Size = new System.Drawing.Size(180, 30);
            this.appMenuItem.Text = "Приложения";
            this.appMenuItem.Click += new System.EventHandler(this.appMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.settingsMenuItem.Image = global::Installer.Properties.Resources.Button_More;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(180, 30);
            this.settingsMenuItem.Text = "Настройки";
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // infoRepoMenuItem
            // 
            this.infoRepoMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoRepoMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.infoRepoMenuItem.Image = global::Installer.Properties.Resources.Button_More;
            this.infoRepoMenuItem.Name = "infoRepoMenuItem";
            this.infoRepoMenuItem.ShowShortcutKeys = false;
            this.infoRepoMenuItem.Size = new System.Drawing.Size(262, 30);
            this.infoRepoMenuItem.Text = "Info";
            // 
            // installRepoMenuItem
            // 
            this.installRepoMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.installRepoMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.installRepoMenuItem.Image = global::Installer.Properties.Resources.Arrow_Down;
            this.installRepoMenuItem.Name = "installRepoMenuItem";
            this.installRepoMenuItem.Size = new System.Drawing.Size(262, 30);
            this.installRepoMenuItem.Text = "Установить приложение";
            this.installRepoMenuItem.ToolTipText = "Установить приложение";
            this.installRepoMenuItem.Click += new System.EventHandler(this.installRepoMenuItem_Click);
            // 
            // updateRepoMenuItem
            // 
            this.updateRepoMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateRepoMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.updateRepoMenuItem.Image = global::Installer.Properties.Resources.Arrow_Up;
            this.updateRepoMenuItem.Name = "updateRepoMenuItem";
            this.updateRepoMenuItem.Size = new System.Drawing.Size(262, 30);
            this.updateRepoMenuItem.Text = "Обновить приложение";
            this.updateRepoMenuItem.ToolTipText = "Обновить приложение до последней версии";
            this.updateRepoMenuItem.Click += new System.EventHandler(this.installRepoMenuItem_Click);
            // 
            // uninstallRepoMenuItem
            // 
            this.uninstallRepoMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uninstallRepoMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.uninstallRepoMenuItem.Image = global::Installer.Properties.Resources.Button_Close;
            this.uninstallRepoMenuItem.Name = "uninstallRepoMenuItem";
            this.uninstallRepoMenuItem.Size = new System.Drawing.Size(262, 30);
            this.uninstallRepoMenuItem.Text = "Удалить приложение";
            this.uninstallRepoMenuItem.ToolTipText = "Удалить установленное приложение";
            this.uninstallRepoMenuItem.Click += new System.EventHandler(this.uninstallRepoMenuItem_Click);
            // 
            // refreshRepoMenuItem
            // 
            this.refreshRepoMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshRepoMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.refreshRepoMenuItem.Image = global::Installer.Properties.Resources.Repeat;
            this.refreshRepoMenuItem.Name = "refreshRepoMenuItem";
            this.refreshRepoMenuItem.Size = new System.Drawing.Size(262, 30);
            this.refreshRepoMenuItem.Text = "Обновить список";
            this.refreshRepoMenuItem.ToolTipText = "Обновить список приложений";
            this.refreshRepoMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // runInstallMenuItem
            // 
            this.runInstallMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runInstallMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.runInstallMenuItem.Image = global::Installer.Properties.Resources.Button_On_Off;
            this.runInstallMenuItem.Name = "runInstallMenuItem";
            this.runInstallMenuItem.Size = new System.Drawing.Size(252, 30);
            this.runInstallMenuItem.Text = "Запустить";
            this.runInstallMenuItem.ToolTipText = "Запустить выбранное приложение";
            this.runInstallMenuItem.Click += new System.EventHandler(this.runInstallMenuItem_Click);
            // 
            // openDirInstallMenuItem
            // 
            this.openDirInstallMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDirInstallMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.openDirInstallMenuItem.Image = global::Installer.Properties.Resources.Folder_File;
            this.openDirInstallMenuItem.Name = "openDirInstallMenuItem";
            this.openDirInstallMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openDirInstallMenuItem.Text = "Открыть папку";
            this.openDirInstallMenuItem.ToolTipText = "Открыть папку приложения";
            this.openDirInstallMenuItem.Click += new System.EventHandler(this.openDirInstallMenuItem_Click);
            // 
            // createLinkInstallMenuItem
            // 
            this.createLinkInstallMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createLinkInstallMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.createLinkInstallMenuItem.Image = global::Installer.Properties.Resources.Favorite;
            this.createLinkInstallMenuItem.Name = "createLinkInstallMenuItem";
            this.createLinkInstallMenuItem.Size = new System.Drawing.Size(252, 30);
            this.createLinkInstallMenuItem.Text = "Создать ярлык";
            this.createLinkInstallMenuItem.ToolTipText = "Создать ярлык приложения на рабочем столе";
            this.createLinkInstallMenuItem.Click += new System.EventHandler(this.createLinkInstallMenuItem_Click);
            // 
            // updateInstallMenuItem
            // 
            this.updateInstallMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateInstallMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.updateInstallMenuItem.Image = global::Installer.Properties.Resources.Arrow_Up;
            this.updateInstallMenuItem.Name = "updateInstallMenuItem";
            this.updateInstallMenuItem.Size = new System.Drawing.Size(252, 30);
            this.updateInstallMenuItem.Text = "Обновить приложение";
            this.updateInstallMenuItem.ToolTipText = "Обновить приложение до последней версии";
            this.updateInstallMenuItem.Click += new System.EventHandler(this.updateInstallMenuItem_Click);
            // 
            // uninstallInstallMenuItem
            // 
            this.uninstallInstallMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uninstallInstallMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.uninstallInstallMenuItem.Image = global::Installer.Properties.Resources.Button_Close;
            this.uninstallInstallMenuItem.Name = "uninstallInstallMenuItem";
            this.uninstallInstallMenuItem.Size = new System.Drawing.Size(252, 30);
            this.uninstallInstallMenuItem.Text = "Удалить приложение";
            this.uninstallInstallMenuItem.ToolTipText = "Удалить установленное приложение";
            this.uninstallInstallMenuItem.Click += new System.EventHandler(this.uninstallInstallMenuItem_Click);
            // 
            // refreshInstallMenuItem
            // 
            this.refreshInstallMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshInstallMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.refreshInstallMenuItem.Image = global::Installer.Properties.Resources.Repeat;
            this.refreshInstallMenuItem.Name = "refreshInstallMenuItem";
            this.refreshInstallMenuItem.Size = new System.Drawing.Size(252, 30);
            this.refreshInstallMenuItem.Text = "Обновить список";
            this.refreshInstallMenuItem.ToolTipText = "Обновить список приложений";
            this.refreshInstallMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // updInfoRepoMenuItem
            // 
            this.updInfoRepoMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updInfoRepoMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.updInfoRepoMenuItem.Image = global::Installer.Properties.Resources.Dashboard;
            this.updInfoRepoMenuItem.Name = "updInfoRepoMenuItem";
            this.updInfoRepoMenuItem.Size = new System.Drawing.Size(262, 30);
            this.updInfoRepoMenuItem.Text = "Информация";
            this.updInfoRepoMenuItem.Click += new System.EventHandler(this.updInfoRepoMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(259, 6);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn1
            // 
            this.versionDataGridViewTextBoxColumn1.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn1.HeaderText = "Версия";
            this.versionDataGridViewTextBoxColumn1.Name = "versionDataGridViewTextBoxColumn1";
            this.versionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // runFileDataGridViewTextBoxColumn
            // 
            this.runFileDataGridViewTextBoxColumn.DataPropertyName = "RunFile";
            this.runFileDataGridViewTextBoxColumn.HeaderText = "Запуск";
            this.runFileDataGridViewTextBoxColumn.Name = "runFileDataGridViewTextBoxColumn";
            this.runFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appInfoInstallBindingSource
            // 
            this.appInfoInstallBindingSource.DataSource = typeof(Installer.Models.AppInfo);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Версия";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appInfoRepoBindingSource
            // 
            this.appInfoRepoBindingSource.DataSource = typeof(Installer.Models.AppInfo);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 338);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.tbInstallDir);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Установщик ПО";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabInstall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstall)).EndInit();
            this.tabAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).EndInit();
            this.contextMenuRepo.ResumeLayout(false);
            this.contextMenuInstall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appInfoInstallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appInfoRepoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInstall;
        private System.Windows.Forms.TabPage tabAvailable;
        private System.Windows.Forms.DataGridView dataGridViewInstall;
        private System.Windows.Forms.DataGridView dataGridViewRepo;
        private System.Windows.Forms.TextBox tbInstallDir;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appMenuItem;
        private System.Windows.Forms.BindingSource appInfoRepoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuRepo;
        private System.Windows.Forms.ToolStripMenuItem installRepoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRepoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallRepoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem infoRepoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.ComponentModel.BackgroundWorker bgWorkerGetRepo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem refreshRepoMenuItem;
        private System.Windows.Forms.BindingSource appInfoInstallBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuInstall;
        private System.Windows.Forms.ToolStripMenuItem infoInstallMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem updateInstallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallInstallMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem createLinkInstallMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem refreshInstallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runInstallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirInstallMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn runFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedUpdateValue;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem updInfoInstallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updInfoRepoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}

