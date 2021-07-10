
namespace DwUtils.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabReceived = new System.Windows.Forms.TabPage();
            this.dataGridViewReceive = new System.Windows.Forms.DataGridView();
            this.panelReceived = new System.Windows.Forms.Panel();
            this.tabReceivedDoc = new System.Windows.Forms.TabPage();
            this.dataGridViewDocReceive = new System.Windows.Forms.DataGridView();
            this.receiveReestrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelReceivedDoc = new System.Windows.Forms.Panel();
            this.btnReceiveDocLoad = new System.Windows.Forms.Button();
            this.receiveDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.receiveDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabOrgsDoc = new System.Windows.Forms.TabPage();
            this.dataGridViewDocOrg = new System.Windows.Forms.DataGridView();
            this.orgReestrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelOrgDoc = new System.Windows.Forms.Panel();
            this.btnOrgDocLoad = new System.Windows.Forms.Button();
            this.orgDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.orgDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabActiveUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewUserOnline = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adminStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.connectUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelActive = new System.Windows.Forms.Panel();
            this.btnActiveUserLoad = new System.Windows.Forms.Button();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelInfoLicense = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpoCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tabsControl.SuspendLayout();
            this.tabReceived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceive)).BeginInit();
            this.tabReceivedDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveReestrBindingSource)).BeginInit();
            this.panelReceivedDoc.SuspendLayout();
            this.tabOrgsDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgReestrBindingSource)).BeginInit();
            this.panelOrgDoc.SuspendLayout();
            this.tabActiveUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectUserBindingSource)).BeginInit();
            this.panelActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.connectsMenuItem,
            this.settingsMenuItem,
            this.infosMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(800, 40);
            this.menuBar.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Image = global::DwUtils.Properties.Resources.File;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(81, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::DwUtils.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(130, 30);
            this.exitMenuItem.Text = "Выход";
            // 
            // connectsMenuItem
            // 
            this.connectsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authMenuItem,
            this.databaseToolStripMenuItem});
            this.connectsMenuItem.Image = global::DwUtils.Properties.Resources.Server;
            this.connectsMenuItem.Name = "connectsMenuItem";
            this.connectsMenuItem.Size = new System.Drawing.Size(142, 36);
            this.connectsMenuItem.Text = "Подключения";
            // 
            // authMenuItem
            // 
            this.authMenuItem.Image = global::DwUtils.Properties.Resources.Suit;
            this.authMenuItem.Name = "authMenuItem";
            this.authMenuItem.Size = new System.Drawing.Size(263, 30);
            this.authMenuItem.Text = "Авторизация на Почта.Ру";
            this.authMenuItem.Click += new System.EventHandler(this.authMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Image = global::DwUtils.Properties.Resources.Lan_Socket;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.databaseToolStripMenuItem.Text = "Подключение к БД";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDbMenuItem});
            this.settingsMenuItem.Image = global::DwUtils.Properties.Resources.Button_Settings;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(120, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // createDbMenuItem
            // 
            this.createDbMenuItem.Image = global::DwUtils.Properties.Resources.Lego_Bricks;
            this.createDbMenuItem.Name = "createDbMenuItem";
            this.createDbMenuItem.Size = new System.Drawing.Size(213, 30);
            this.createDbMenuItem.Text = "Создать новую БД";
            this.createDbMenuItem.Click += new System.EventHandler(this.createDbMenuItem_Click);
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.Image = global::DwUtils.Properties.Resources._4_Leaf_Clover;
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(84, 36);
            this.infosMenuItem.Text = "Инфо";
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(671, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.Gray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(114, 17);
            this.statusAuthor.Text = "WorldCount, 2020 ©";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.panelGeneral.Controls.Add(this.lblUsers);
            this.panelGeneral.Controls.Add(this.btnSync);
            this.panelGeneral.Controls.Add(this.cbUsers);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 44);
            this.panelGeneral.TabIndex = 2;
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsers.Location = new System.Drawing.Point(422, 12);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(111, 20);
            this.lblUsers.TabIndex = 20;
            this.lblUsers.Text = "Пользователь:";
            // 
            // btnSync
            // 
            this.btnSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSync.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.Image = global::DwUtils.Properties.Resources.cloud_4_24;
            this.btnSync.Location = new System.Drawing.Point(752, 4);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(36, 36);
            this.btnSync.TabIndex = 19;
            this.btnSync.TabStop = false;
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSync.UseVisualStyleBackColor = false;
            // 
            // cbUsers
            // 
            this.cbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUsers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUsers.DataSource = this.userBindingSource;
            this.cbUsers.DisplayMember = "Name";
            this.cbUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.IntegralHeight = false;
            this.cbUsers.Location = new System.Drawing.Point(539, 9);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(207, 28);
            this.cbUsers.TabIndex = 0;
            this.cbUsers.ValueMember = "Id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DwUtils.Core.Models.Firebird.User);
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabReceived);
            this.tabsControl.Controls.Add(this.tabReceivedDoc);
            this.tabsControl.Controls.Add(this.tabOrgsDoc);
            this.tabsControl.Controls.Add(this.tabActiveUsers);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabsControl.Location = new System.Drawing.Point(0, 84);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(800, 344);
            this.tabsControl.TabIndex = 3;
            // 
            // tabReceived
            // 
            this.tabReceived.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReceived.Controls.Add(this.dataGridViewReceive);
            this.tabReceived.Controls.Add(this.panelReceived);
            this.tabReceived.Location = new System.Drawing.Point(4, 29);
            this.tabReceived.Name = "tabReceived";
            this.tabReceived.Size = new System.Drawing.Size(792, 311);
            this.tabReceived.TabIndex = 0;
            this.tabReceived.Text = "На вручение";
            // 
            // dataGridViewReceive
            // 
            this.dataGridViewReceive.AllowUserToAddRows = false;
            this.dataGridViewReceive.AllowUserToDeleteRows = false;
            this.dataGridViewReceive.AllowUserToResizeRows = false;
            this.dataGridViewReceive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceive.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewReceive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReceive.ColumnHeadersHeight = 40;
            this.dataGridViewReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReceive.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReceive.EnableHeadersVisualStyles = false;
            this.dataGridViewReceive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewReceive.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewReceive.Name = "dataGridViewReceive";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceive.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReceive.RowHeadersVisible = false;
            this.dataGridViewReceive.RowHeadersWidth = 40;
            this.dataGridViewReceive.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewReceive.RowTemplate.Height = 40;
            this.dataGridViewReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReceive.Size = new System.Drawing.Size(792, 263);
            this.dataGridViewReceive.TabIndex = 5;
            this.dataGridViewReceive.TabStop = false;
            // 
            // panelReceived
            // 
            this.panelReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceived.Location = new System.Drawing.Point(0, 0);
            this.panelReceived.Name = "panelReceived";
            this.panelReceived.Size = new System.Drawing.Size(792, 48);
            this.panelReceived.TabIndex = 4;
            // 
            // tabReceivedDoc
            // 
            this.tabReceivedDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReceivedDoc.Controls.Add(this.dataGridViewDocReceive);
            this.tabReceivedDoc.Controls.Add(this.panelReceivedDoc);
            this.tabReceivedDoc.Location = new System.Drawing.Point(4, 29);
            this.tabReceivedDoc.Name = "tabReceivedDoc";
            this.tabReceivedDoc.Size = new System.Drawing.Size(792, 311);
            this.tabReceivedDoc.TabIndex = 2;
            this.tabReceivedDoc.Text = "Накладные на прибытие";
            // 
            // dataGridViewDocReceive
            // 
            this.dataGridViewDocReceive.AllowUserToAddRows = false;
            this.dataGridViewDocReceive.AllowUserToDeleteRows = false;
            this.dataGridViewDocReceive.AllowUserToResizeRows = false;
            this.dataGridViewDocReceive.AutoGenerateColumns = false;
            this.dataGridViewDocReceive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocReceive.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDocReceive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDocReceive.ColumnHeadersHeight = 40;
            this.dataGridViewDocReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDocReceive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.directionIndexDataGridViewTextBoxColumn,
            this.directionPlaceDataGridViewTextBoxColumn,
            this.stateIdDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.editDateDataGridViewTextBoxColumn,
            this.rpoCountDataGridViewTextBoxColumn,
            this.placeIdDataGridViewTextBoxColumn1,
            this.userIdDataGridViewTextBoxColumn1});
            this.dataGridViewDocReceive.DataSource = this.receiveReestrBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocReceive.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDocReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocReceive.EnableHeadersVisualStyles = false;
            this.dataGridViewDocReceive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewDocReceive.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewDocReceive.Name = "dataGridViewDocReceive";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocReceive.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDocReceive.RowHeadersVisible = false;
            this.dataGridViewDocReceive.RowHeadersWidth = 40;
            this.dataGridViewDocReceive.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDocReceive.RowTemplate.Height = 40;
            this.dataGridViewDocReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDocReceive.Size = new System.Drawing.Size(792, 263);
            this.dataGridViewDocReceive.TabIndex = 6;
            this.dataGridViewDocReceive.TabStop = false;
            // 
            // receiveReestrBindingSource
            // 
            this.receiveReestrBindingSource.DataSource = typeof(DwUtils.Core.Models.Firebird.Reestr);
            // 
            // panelReceivedDoc
            // 
            this.panelReceivedDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceivedDoc.Controls.Add(this.btnReceiveDocLoad);
            this.panelReceivedDoc.Controls.Add(this.receiveDateTimePickerEnd);
            this.panelReceivedDoc.Controls.Add(this.receiveDateTimePickerStart);
            this.panelReceivedDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceivedDoc.Location = new System.Drawing.Point(0, 0);
            this.panelReceivedDoc.Name = "panelReceivedDoc";
            this.panelReceivedDoc.Size = new System.Drawing.Size(792, 48);
            this.panelReceivedDoc.TabIndex = 3;
            // 
            // btnReceiveDocLoad
            // 
            this.btnReceiveDocLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceiveDocLoad.BackColor = System.Drawing.Color.Brown;
            this.btnReceiveDocLoad.FlatAppearance.BorderSize = 0;
            this.btnReceiveDocLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnReceiveDocLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveDocLoad.ForeColor = System.Drawing.Color.White;
            this.btnReceiveDocLoad.Image = global::DwUtils.Properties.Resources.white_synchronize_24;
            this.btnReceiveDocLoad.Location = new System.Drawing.Point(748, 6);
            this.btnReceiveDocLoad.Name = "btnReceiveDocLoad";
            this.btnReceiveDocLoad.Size = new System.Drawing.Size(36, 36);
            this.btnReceiveDocLoad.TabIndex = 21;
            this.btnReceiveDocLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceiveDocLoad.UseVisualStyleBackColor = false;
            this.btnReceiveDocLoad.Click += new System.EventHandler(this.btnReceiveDocLoad_Click);
            // 
            // receiveDateTimePickerEnd
            // 
            this.receiveDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receiveDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.receiveDateTimePickerEnd.Location = new System.Drawing.Point(219, 11);
            this.receiveDateTimePickerEnd.Name = "receiveDateTimePickerEnd";
            this.receiveDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.receiveDateTimePickerEnd.TabIndex = 4;
            // 
            // receiveDateTimePickerStart
            // 
            this.receiveDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receiveDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.receiveDateTimePickerStart.Location = new System.Drawing.Point(13, 11);
            this.receiveDateTimePickerStart.Name = "receiveDateTimePickerStart";
            this.receiveDateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.receiveDateTimePickerStart.TabIndex = 3;
            this.receiveDateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerIn_ValueChanged);
            // 
            // tabOrgsDoc
            // 
            this.tabOrgsDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrgsDoc.Controls.Add(this.dataGridViewDocOrg);
            this.tabOrgsDoc.Controls.Add(this.panelOrgDoc);
            this.tabOrgsDoc.Location = new System.Drawing.Point(4, 29);
            this.tabOrgsDoc.Name = "tabOrgsDoc";
            this.tabOrgsDoc.Size = new System.Drawing.Size(792, 311);
            this.tabOrgsDoc.TabIndex = 1;
            this.tabOrgsDoc.Text = "Накладные на организации";
            // 
            // dataGridViewDocOrg
            // 
            this.dataGridViewDocOrg.AllowUserToAddRows = false;
            this.dataGridViewDocOrg.AllowUserToDeleteRows = false;
            this.dataGridViewDocOrg.AllowUserToResizeRows = false;
            this.dataGridViewDocOrg.AutoGenerateColumns = false;
            this.dataGridViewDocOrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocOrg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDocOrg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocOrg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDocOrg.ColumnHeadersHeight = 40;
            this.dataGridViewDocOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDocOrg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewComboBoxColumn1});
            this.dataGridViewDocOrg.DataSource = this.orgReestrBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocOrg.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDocOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocOrg.EnableHeadersVisualStyles = false;
            this.dataGridViewDocOrg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewDocOrg.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewDocOrg.Name = "dataGridViewDocOrg";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocOrg.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewDocOrg.RowHeadersVisible = false;
            this.dataGridViewDocOrg.RowHeadersWidth = 40;
            this.dataGridViewDocOrg.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDocOrg.RowTemplate.Height = 40;
            this.dataGridViewDocOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDocOrg.Size = new System.Drawing.Size(792, 263);
            this.dataGridViewDocOrg.TabIndex = 7;
            this.dataGridViewDocOrg.TabStop = false;
            // 
            // orgReestrBindingSource
            // 
            this.orgReestrBindingSource.DataSource = typeof(DwUtils.Core.Models.Firebird.Reestr);
            // 
            // panelOrgDoc
            // 
            this.panelOrgDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelOrgDoc.Controls.Add(this.btnOrgDocLoad);
            this.panelOrgDoc.Controls.Add(this.orgDateTimePickerEnd);
            this.panelOrgDoc.Controls.Add(this.orgDateTimePickerStart);
            this.panelOrgDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrgDoc.Location = new System.Drawing.Point(0, 0);
            this.panelOrgDoc.Name = "panelOrgDoc";
            this.panelOrgDoc.Size = new System.Drawing.Size(792, 48);
            this.panelOrgDoc.TabIndex = 3;
            // 
            // btnOrgDocLoad
            // 
            this.btnOrgDocLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrgDocLoad.BackColor = System.Drawing.Color.Brown;
            this.btnOrgDocLoad.FlatAppearance.BorderSize = 0;
            this.btnOrgDocLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOrgDocLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrgDocLoad.ForeColor = System.Drawing.Color.White;
            this.btnOrgDocLoad.Image = global::DwUtils.Properties.Resources.white_synchronize_24;
            this.btnOrgDocLoad.Location = new System.Drawing.Point(748, 6);
            this.btnOrgDocLoad.Name = "btnOrgDocLoad";
            this.btnOrgDocLoad.Size = new System.Drawing.Size(36, 36);
            this.btnOrgDocLoad.TabIndex = 24;
            this.btnOrgDocLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrgDocLoad.UseVisualStyleBackColor = false;
            this.btnOrgDocLoad.Click += new System.EventHandler(this.btnOrgDocLoad_Click);
            // 
            // orgDateTimePickerEnd
            // 
            this.orgDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.orgDateTimePickerEnd.Location = new System.Drawing.Point(219, 11);
            this.orgDateTimePickerEnd.Name = "orgDateTimePickerEnd";
            this.orgDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.orgDateTimePickerEnd.TabIndex = 23;
            // 
            // orgDateTimePickerStart
            // 
            this.orgDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.orgDateTimePickerStart.Location = new System.Drawing.Point(13, 11);
            this.orgDateTimePickerStart.Name = "orgDateTimePickerStart";
            this.orgDateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.orgDateTimePickerStart.TabIndex = 22;
            this.orgDateTimePickerStart.ValueChanged += new System.EventHandler(this.orgDateTimePickerStart_ValueChanged);
            // 
            // tabActiveUsers
            // 
            this.tabActiveUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabActiveUsers.Controls.Add(this.dataGridViewUserOnline);
            this.tabActiveUsers.Controls.Add(this.panelActive);
            this.tabActiveUsers.Location = new System.Drawing.Point(4, 29);
            this.tabActiveUsers.Name = "tabActiveUsers";
            this.tabActiveUsers.Size = new System.Drawing.Size(792, 311);
            this.tabActiveUsers.TabIndex = 3;
            this.tabActiveUsers.Text = "Подключенные пользователи";
            // 
            // dataGridViewUserOnline
            // 
            this.dataGridViewUserOnline.AllowUserToAddRows = false;
            this.dataGridViewUserOnline.AllowUserToDeleteRows = false;
            this.dataGridViewUserOnline.AllowUserToResizeRows = false;
            this.dataGridViewUserOnline.AutoGenerateColumns = false;
            this.dataGridViewUserOnline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserOnline.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUserOnline.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserOnline.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewUserOnline.ColumnHeadersHeight = 40;
            this.dataGridViewUserOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUserOnline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.placeIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.placeNameDataGridViewTextBoxColumn,
            this.connectDateDataGridViewTextBoxColumn,
            this.workDateDataGridViewTextBoxColumn,
            this.isAdminDataGridViewCheckBoxColumn,
            this.adminStatusDataGridViewTextBoxColumn,
            this.isValidDataGridViewCheckBoxColumn});
            this.dataGridViewUserOnline.DataSource = this.connectUserBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserOnline.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewUserOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserOnline.EnableHeadersVisualStyles = false;
            this.dataGridViewUserOnline.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewUserOnline.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewUserOnline.Name = "dataGridViewUserOnline";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserOnline.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewUserOnline.RowHeadersVisible = false;
            this.dataGridViewUserOnline.RowHeadersWidth = 40;
            this.dataGridViewUserOnline.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewUserOnline.RowTemplate.Height = 40;
            this.dataGridViewUserOnline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUserOnline.Size = new System.Drawing.Size(792, 263);
            this.dataGridViewUserOnline.TabIndex = 1;
            this.dataGridViewUserOnline.TabStop = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // placeIdDataGridViewTextBoxColumn
            // 
            this.placeIdDataGridViewTextBoxColumn.DataPropertyName = "PlaceId";
            this.placeIdDataGridViewTextBoxColumn.HeaderText = "PlaceId";
            this.placeIdDataGridViewTextBoxColumn.Name = "placeIdDataGridViewTextBoxColumn";
            this.placeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.userNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeNameDataGridViewTextBoxColumn
            // 
            this.placeNameDataGridViewTextBoxColumn.DataPropertyName = "PlaceName";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.placeNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.placeNameDataGridViewTextBoxColumn.HeaderText = "Место";
            this.placeNameDataGridViewTextBoxColumn.Name = "placeNameDataGridViewTextBoxColumn";
            this.placeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectDateDataGridViewTextBoxColumn
            // 
            this.connectDateDataGridViewTextBoxColumn.DataPropertyName = "ConnectDate";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.connectDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.connectDateDataGridViewTextBoxColumn.HeaderText = "   Подключился";
            this.connectDateDataGridViewTextBoxColumn.Name = "connectDateDataGridViewTextBoxColumn";
            this.connectDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.workDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.workDateDataGridViewTextBoxColumn.HeaderText = "  Работает";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            this.workDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            this.isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.HeaderText = "Админ";
            this.isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            this.isAdminDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isAdminDataGridViewCheckBoxColumn.Visible = false;
            // 
            // adminStatusDataGridViewTextBoxColumn
            // 
            this.adminStatusDataGridViewTextBoxColumn.DataPropertyName = "AdminStatus";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = "НЕТ";
            this.adminStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.adminStatusDataGridViewTextBoxColumn.HeaderText = "  Админ";
            this.adminStatusDataGridViewTextBoxColumn.Name = "adminStatusDataGridViewTextBoxColumn";
            this.adminStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isValidDataGridViewCheckBoxColumn
            // 
            this.isValidDataGridViewCheckBoxColumn.DataPropertyName = "IsValid";
            this.isValidDataGridViewCheckBoxColumn.HeaderText = "IsValid";
            this.isValidDataGridViewCheckBoxColumn.Name = "isValidDataGridViewCheckBoxColumn";
            this.isValidDataGridViewCheckBoxColumn.Visible = false;
            // 
            // connectUserBindingSource
            // 
            this.connectUserBindingSource.DataSource = typeof(DwUtils.Core.Models.Firebird.ConnectUser);
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelActive.Controls.Add(this.btnActiveUserLoad);
            this.panelActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActive.Location = new System.Drawing.Point(0, 0);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(792, 48);
            this.panelActive.TabIndex = 2;
            // 
            // btnActiveUserLoad
            // 
            this.btnActiveUserLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActiveUserLoad.BackColor = System.Drawing.Color.Brown;
            this.btnActiveUserLoad.FlatAppearance.BorderSize = 0;
            this.btnActiveUserLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnActiveUserLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveUserLoad.ForeColor = System.Drawing.Color.White;
            this.btnActiveUserLoad.Image = global::DwUtils.Properties.Resources.white_synchronize_24;
            this.btnActiveUserLoad.Location = new System.Drawing.Point(748, 6);
            this.btnActiveUserLoad.Name = "btnActiveUserLoad";
            this.btnActiveUserLoad.Size = new System.Drawing.Size(36, 36);
            this.btnActiveUserLoad.TabIndex = 20;
            this.btnActiveUserLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActiveUserLoad.UseVisualStyleBackColor = false;
            this.btnActiveUserLoad.Click += new System.EventHandler(this.btnActiveUserLoad_Click);
            // 
            // labelLicense
            // 
            this.labelLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLicense.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLicense.Location = new System.Drawing.Point(704, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(96, 40);
            this.labelLicense.TabIndex = 12;
            this.labelLicense.Text = "01.01.0001";
            this.labelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoLicense
            // 
            this.labelInfoLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoLicense.Location = new System.Drawing.Point(585, 0);
            this.labelInfoLicense.Name = "labelInfoLicense";
            this.labelInfoLicense.Size = new System.Drawing.Size(113, 40);
            this.labelInfoLicense.TabIndex = 11;
            this.labelInfoLicense.Text = "Лицензия до:";
            this.labelInfoLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // directionIndexDataGridViewTextBoxColumn
            // 
            this.directionIndexDataGridViewTextBoxColumn.DataPropertyName = "DirectionIndex";
            this.directionIndexDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.directionIndexDataGridViewTextBoxColumn.Name = "directionIndexDataGridViewTextBoxColumn";
            this.directionIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.directionIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // directionPlaceDataGridViewTextBoxColumn
            // 
            this.directionPlaceDataGridViewTextBoxColumn.DataPropertyName = "DirectionPlace";
            this.directionPlaceDataGridViewTextBoxColumn.HeaderText = "Место";
            this.directionPlaceDataGridViewTextBoxColumn.Name = "directionPlaceDataGridViewTextBoxColumn";
            this.directionPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateIdDataGridViewTextBoxColumn
            // 
            this.stateIdDataGridViewTextBoxColumn.DataPropertyName = "StateId";
            this.stateIdDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.stateIdDataGridViewTextBoxColumn.Name = "stateIdDataGridViewTextBoxColumn";
            this.stateIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Создано";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // editDateDataGridViewTextBoxColumn
            // 
            this.editDateDataGridViewTextBoxColumn.DataPropertyName = "EditDate";
            this.editDateDataGridViewTextBoxColumn.HeaderText = "Изменено";
            this.editDateDataGridViewTextBoxColumn.Name = "editDateDataGridViewTextBoxColumn";
            this.editDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.editDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // rpoCountDataGridViewTextBoxColumn
            // 
            this.rpoCountDataGridViewTextBoxColumn.DataPropertyName = "RpoCount";
            this.rpoCountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.rpoCountDataGridViewTextBoxColumn.Name = "rpoCountDataGridViewTextBoxColumn";
            this.rpoCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeIdDataGridViewTextBoxColumn1
            // 
            this.placeIdDataGridViewTextBoxColumn1.DataPropertyName = "PlaceId";
            this.placeIdDataGridViewTextBoxColumn1.HeaderText = "Участок";
            this.placeIdDataGridViewTextBoxColumn1.Name = "placeIdDataGridViewTextBoxColumn1";
            this.placeIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn1
            // 
            this.userIdDataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn1.DataSource = this.userBindingSource;
            this.userIdDataGridViewTextBoxColumn1.DisplayMember = "Name";
            this.userIdDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIdDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIdDataGridViewTextBoxColumn1.HeaderText = "Пользователь";
            this.userIdDataGridViewTextBoxColumn1.Name = "userIdDataGridViewTextBoxColumn1";
            this.userIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIdDataGridViewTextBoxColumn1.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Num";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DirectionIndex";
            this.dataGridViewTextBoxColumn5.HeaderText = "Индекс";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DirectionPlace";
            this.dataGridViewTextBoxColumn6.HeaderText = "Место";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StateId";
            this.dataGridViewTextBoxColumn7.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "Создано";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "EditDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "Изменено";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "RpoCount";
            this.dataGridViewTextBoxColumn12.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PlaceId";
            this.dataGridViewTextBoxColumn8.HeaderText = "Участок";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "UserId";
            this.dataGridViewComboBoxColumn1.DataSource = this.userBindingSource;
            this.dataGridViewComboBoxColumn1.DisplayMember = "Name";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxColumn1.HeaderText = "Пользователь";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.ValueMember = "Id";
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelInfoLicense);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DwUtils";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tabsControl.ResumeLayout(false);
            this.tabReceived.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceive)).EndInit();
            this.tabReceivedDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveReestrBindingSource)).EndInit();
            this.panelReceivedDoc.ResumeLayout(false);
            this.tabOrgsDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgReestrBindingSource)).EndInit();
            this.panelOrgDoc.ResumeLayout(false);
            this.tabActiveUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectUserBindingSource)).EndInit();
            this.panelActive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabReceived;
        private System.Windows.Forms.TabPage tabOrgsDoc;
        private System.Windows.Forms.TabPage tabReceivedDoc;
        private System.Windows.Forms.TabPage tabActiveUsers;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Label labelInfoLicense;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.ToolStripMenuItem connectsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewUserOnline;
        private System.Windows.Forms.BindingSource connectUserBindingSource;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Panel panelReceivedDoc;
        private System.Windows.Forms.Panel panelOrgDoc;
        private System.Windows.Forms.Panel panelReceived;
        private System.Windows.Forms.Button btnActiveUserLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewReceive;
        private System.Windows.Forms.DataGridView dataGridViewDocReceive;
        private System.Windows.Forms.ToolStripMenuItem createDbMenuItem;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.DateTimePicker receiveDateTimePickerStart;
        private System.Windows.Forms.DateTimePicker receiveDateTimePickerEnd;
        private System.Windows.Forms.Button btnReceiveDocLoad;
        private System.Windows.Forms.BindingSource receiveReestrBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewDocOrg;
        private System.Windows.Forms.Button btnOrgDocLoad;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerStart;
        private System.Windows.Forms.BindingSource orgReestrBindingSource;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpoCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
    }
}

