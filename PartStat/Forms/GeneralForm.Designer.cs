using PartStat.Core.Libs.Stats.StatObject;

namespace PartStat.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.valueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.massReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.orgReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.firstMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.interMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.labelDateOut = new System.Windows.Forms.Label();
            this.labelDateIn = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.labelOrg = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOrgs = new System.Windows.Forms.ComboBox();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCreateType = new System.Windows.Forms.Label();
            this.comboBoxCreateList = new System.Windows.Forms.ComboBox();
            this.createListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelClass = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.comboBoxListClass = new System.Windows.Forms.ComboBox();
            this.interTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxErrorList = new System.Windows.Forms.ComboBox();
            this.errorListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.checkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interNameGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manualNameGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postMarkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warnCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.checkFirmListStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckFirmListStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.inverseCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.setHandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewStat = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.panelType = new System.Windows.Forms.Panel();
            this.labelMailCategory = new System.Windows.Forms.Label();
            this.labelListStatus = new System.Windows.Forms.Label();
            this.labelMailType = new System.Windows.Forms.Label();
            this.comboBoxListStatus = new System.Windows.Forms.ComboBox();
            this.listStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMailCategory = new System.Windows.Forms.ComboBox();
            this.mailCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMailType = new System.Windows.Forms.ComboBox();
            this.mailTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelListOut = new System.Windows.Forms.Label();
            this.labelListIn = new System.Windows.Forms.Label();
            this.textBoxListOut = new System.Windows.Forms.TextBox();
            this.textBoxListIn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRevise = new System.Windows.Forms.CheckBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.checkBoxPrintPreview = new System.Windows.Forms.CheckBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.btnTablePrint = new System.Windows.Forms.Button();
            this.imageListCheckBox = new System.Windows.Forms.ImageList(this.components);
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmListBindingSource)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDataBindingSource)).BeginInit();
            this.panelType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Consolas", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.status.Location = new System.Drawing.Point(0, 550);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1273, 22);
            this.status.TabIndex = 2;
            this.status.Text = "Статус";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(1144, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(114, 17);
            this.statusAuthor.Text = "WorldCount, 2020 ©";
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.reportsToolStripMenuItem,
            this.transToolStripMenuItem,
            this.tarifsToolStripMenuItem,
            this.settingsMenuItem,
            this.infoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1273, 40);
            this.menu.TabIndex = 3;
            this.menu.Text = "Меню";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.fileMenuItem.Image = global::PartStat.Properties.Resources.Text;
            this.fileMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.fileMenuItem.Size = new System.Drawing.Size(106, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.exitMenuItem.Image = global::PartStat.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(129, 28);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportManagementToolStripMenuItem,
            this.reportsAllToolStripMenuItem,
            this.toolStripSeparator13,
            this.valueReportToolStripMenuItem,
            this.handReportToolStripMenuItem,
            this.toolStripSeparator14,
            this.massReportToolStripMenuItem,
            this.toolStripSeparator15,
            this.orgReportToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.reportsToolStripMenuItem.Image = global::PartStat.Properties.Resources.Books_2;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // reportManagementToolStripMenuItem
            // 
            this.reportManagementToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.reportManagementToolStripMenuItem.Image = global::PartStat.Properties.Resources.Notebook;
            this.reportManagementToolStripMenuItem.Name = "reportManagementToolStripMenuItem";
            this.reportManagementToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.reportManagementToolStripMenuItem.Text = "Управление отчетами";
            this.reportManagementToolStripMenuItem.Click += new System.EventHandler(this.reportManagementToolStripMenuItem_Click);
            // 
            // reportsAllToolStripMenuItem
            // 
            this.reportsAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.reportsAllToolStripMenuItem.Image = global::PartStat.Properties.Resources.Agenda;
            this.reportsAllToolStripMenuItem.Name = "reportsAllToolStripMenuItem";
            this.reportsAllToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.reportsAllToolStripMenuItem.Text = "Все отчеты";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(260, 6);
            // 
            // valueReportToolStripMenuItem
            // 
            this.valueReportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.valueReportToolStripMenuItem.Image = global::PartStat.Properties.Resources.Coin_1;
            this.valueReportToolStripMenuItem.Name = "valueReportToolStripMenuItem";
            this.valueReportToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.valueReportToolStripMenuItem.Text = "Отчет по ценным";
            this.valueReportToolStripMenuItem.Click += new System.EventHandler(this.valueReportToolStripMenuItem_Click);
            // 
            // handReportToolStripMenuItem
            // 
            this.handReportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.handReportToolStripMenuItem.Image = global::PartStat.Properties.Resources.Pen;
            this.handReportToolStripMenuItem.Name = "handReportToolStripMenuItem";
            this.handReportToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.handReportToolStripMenuItem.Text = "Отчет по ручке";
            this.handReportToolStripMenuItem.Click += new System.EventHandler(this.handReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(260, 6);
            // 
            // massReportToolStripMenuItem
            // 
            this.massReportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.massReportToolStripMenuItem.Image = global::PartStat.Properties.Resources.Crane;
            this.massReportToolStripMenuItem.Name = "massReportToolStripMenuItem";
            this.massReportToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.massReportToolStripMenuItem.Text = "Отчет по весу";
            this.massReportToolStripMenuItem.Click += new System.EventHandler(this.massReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(260, 6);
            // 
            // orgReportToolStripMenuItem
            // 
            this.orgReportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.orgReportToolStripMenuItem.Image = global::PartStat.Properties.Resources.Bank;
            this.orgReportToolStripMenuItem.Name = "orgReportToolStripMenuItem";
            this.orgReportToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.orgReportToolStripMenuItem.Text = "Отчет по организации";
            this.orgReportToolStripMenuItem.Click += new System.EventHandler(this.orgReportToolStripMenuItem_Click);
            // 
            // transToolStripMenuItem
            // 
            this.transToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.transToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.transToolStripMenuItem.Image = global::PartStat.Properties.Resources.Box_2;
            this.transToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transToolStripMenuItem.Name = "transToolStripMenuItem";
            this.transToolStripMenuItem.Size = new System.Drawing.Size(159, 36);
            this.transToolStripMenuItem.Text = "Отправления";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.typeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.typeToolStripMenuItem.Image = global::PartStat.Properties.Resources.Envelope_2;
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.typeToolStripMenuItem.Text = "Виды";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.categoryToolStripMenuItem.Image = global::PartStat.Properties.Resources.Notebook_2;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(162, 28);
            this.categoryToolStripMenuItem.Text = "Категории";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // tarifsToolStripMenuItem
            // 
            this.tarifsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noticeToolStripMenuItem,
            this.toolStripSeparator4,
            this.mailToolStripMenuItem,
            this.parcelToolStripMenuItem,
            this.toolStripSeparator5,
            this.firstMailToolStripMenuItem,
            this.firstParcelToolStripMenuItem,
            this.toolStripSeparator6,
            this.interMailToolStripMenuItem,
            this.interParcelToolStripMenuItem});
            this.tarifsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.tarifsToolStripMenuItem.Image = global::PartStat.Properties.Resources.Calculator;
            this.tarifsToolStripMenuItem.Name = "tarifsToolStripMenuItem";
            this.tarifsToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.tarifsToolStripMenuItem.Text = "Тарифы";
            // 
            // noticeToolStripMenuItem
            // 
            this.noticeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noticeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.noticeToolStripMenuItem.Name = "noticeToolStripMenuItem";
            this.noticeToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.noticeToolStripMenuItem.Text = "Уведомления";
            this.noticeToolStripMenuItem.Click += new System.EventHandler(this.noticeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(301, 6);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.mailToolStripMenuItem.Text = "Письма";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // parcelToolStripMenuItem
            // 
            this.parcelToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.parcelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.parcelToolStripMenuItem.Name = "parcelToolStripMenuItem";
            this.parcelToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.parcelToolStripMenuItem.Text = "Бандероли";
            this.parcelToolStripMenuItem.Click += new System.EventHandler(this.parcelToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(301, 6);
            // 
            // firstMailToolStripMenuItem
            // 
            this.firstMailToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstMailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.firstMailToolStripMenuItem.Name = "firstMailToolStripMenuItem";
            this.firstMailToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.firstMailToolStripMenuItem.Text = "Письма 1 класс";
            this.firstMailToolStripMenuItem.Click += new System.EventHandler(this.firstMailToolStripMenuItem_Click);
            // 
            // firstParcelToolStripMenuItem
            // 
            this.firstParcelToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstParcelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.firstParcelToolStripMenuItem.Name = "firstParcelToolStripMenuItem";
            this.firstParcelToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.firstParcelToolStripMenuItem.Text = "Бандероли 1 класс";
            this.firstParcelToolStripMenuItem.Click += new System.EventHandler(this.firstParcelToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(301, 6);
            // 
            // interMailToolStripMenuItem
            // 
            this.interMailToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.interMailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.interMailToolStripMenuItem.Name = "interMailToolStripMenuItem";
            this.interMailToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.interMailToolStripMenuItem.Text = "Международные письма";
            this.interMailToolStripMenuItem.Click += new System.EventHandler(this.interMailToolStripMenuItem_Click);
            // 
            // interParcelToolStripMenuItem
            // 
            this.interParcelToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.interParcelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.interParcelToolStripMenuItem.Name = "interParcelToolStripMenuItem";
            this.interParcelToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.interParcelToolStripMenuItem.Text = "Международные бандероли";
            this.interParcelToolStripMenuItem.Click += new System.EventHandler(this.interParcelToolStripMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripSeparator3,
            this.configToolStripMenuItem,
            this.toolStripSeparator1,
            this.statusToolStripMenuItem,
            this.toolStripSeparator2,
            this.colorsToolStripMenuItem,
            this.toolStripSeparator12,
            this.printerToolStripMenuItem});
            this.settingsMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.settingsMenuItem.Image = global::PartStat.Properties.Resources.Button_Settings;
            this.settingsMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.settingsMenuItem.Size = new System.Drawing.Size(150, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.connectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.connectToolStripMenuItem.Image = global::PartStat.Properties.Resources.Repeat;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.connectToolStripMenuItem.Text = "Подключение к БД";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(231, 6);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.configToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.configToolStripMenuItem.Image = global::PartStat.Properties.Resources.Settings;
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.configToolStripMenuItem.Text = "Настройки";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.statusToolStripMenuItem.Image = global::PartStat.Properties.Resources.Menu_2;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.statusToolStripMenuItem.Text = "Статусы списков";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colorsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.colorsToolStripMenuItem.Image = global::PartStat.Properties.Resources.Font_Color;
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.colorsToolStripMenuItem.Text = "Цвета";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(231, 6);
            // 
            // printerToolStripMenuItem
            // 
            this.printerToolStripMenuItem.Image = global::PartStat.Properties.Resources.Printer;
            this.printerToolStripMenuItem.Name = "printerToolStripMenuItem";
            this.printerToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.printerToolStripMenuItem.Text = "Принтер";
            this.printerToolStripMenuItem.Click += new System.EventHandler(this.printerToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.infoToolStripMenuItem.Image = global::PartStat.Properties.Resources._4_Leaf_Clover;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(87, 36);
            this.infoToolStripMenuItem.Text = "Инфо";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.updateToolStripMenuItem.Image = global::PartStat.Properties.Resources.Button_Dashboard;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.updateToolStripMenuItem.Text = "Обновление";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelFilter.Controls.Add(this.btnLock);
            this.panelFilter.Controls.Add(this.btnLoad);
            this.panelFilter.Controls.Add(this.labelDateOut);
            this.panelFilter.Controls.Add(this.labelDateIn);
            this.panelFilter.Controls.Add(this.btnClearFilter);
            this.panelFilter.Controls.Add(this.labelOrg);
            this.panelFilter.Controls.Add(this.dateTimePickerOut);
            this.panelFilter.Controls.Add(this.dateTimePickerIn);
            this.panelFilter.Controls.Add(this.comboBoxOrgs);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panelFilter.Location = new System.Drawing.Point(0, 40);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1273, 75);
            this.panelFilter.TabIndex = 4;
            // 
            // btnLock
            // 
            this.btnLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Image = global::PartStat.Properties.Resources.Locked;
            this.btnLock.Location = new System.Drawing.Point(1221, 26);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(40, 40);
            this.btnLock.TabIndex = 18;
            this.btnLock.TabStop = false;
            this.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Brown;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = global::PartStat.Properties.Resources.white_synchronize_24;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(730, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(127, 40);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // labelDateOut
            // 
            this.labelDateOut.AutoSize = true;
            this.labelDateOut.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOut.ForeColor = System.Drawing.Color.White;
            this.labelDateOut.Location = new System.Drawing.Point(520, 9);
            this.labelDateOut.Name = "labelDateOut";
            this.labelDateOut.Size = new System.Drawing.Size(62, 19);
            this.labelDateOut.TabIndex = 3;
            this.labelDateOut.Text = "По дату:";
            // 
            // labelDateIn
            // 
            this.labelDateIn.AutoSize = true;
            this.labelDateIn.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateIn.ForeColor = System.Drawing.Color.White;
            this.labelDateIn.Location = new System.Drawing.Point(314, 9);
            this.labelDateIn.Name = "labelDateIn";
            this.labelDateIn.Size = new System.Drawing.Size(56, 19);
            this.labelDateIn.TabIndex = 3;
            this.labelDateIn.Text = "С даты:";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.SlateGray;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Image = global::PartStat.Properties.Resources.Delete;
            this.btnClearFilter.Location = new System.Drawing.Point(863, 26);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(40, 40);
            this.btnClearFilter.TabIndex = 0;
            this.btnClearFilter.TabStop = false;
            this.btnClearFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // labelOrg
            // 
            this.labelOrg.AutoSize = true;
            this.labelOrg.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrg.ForeColor = System.Drawing.Color.White;
            this.labelOrg.Location = new System.Drawing.Point(12, 8);
            this.labelOrg.Name = "labelOrg";
            this.labelOrg.Size = new System.Drawing.Size(95, 19);
            this.labelOrg.TabIndex = 0;
            this.labelOrg.Text = "Организация:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePickerOut.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerOut.Location = new System.Drawing.Point(524, 33);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerOut.TabIndex = 3;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePickerIn.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerIn.Location = new System.Drawing.Point(318, 33);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerIn.TabIndex = 2;
            this.dateTimePickerIn.ValueChanged += new System.EventHandler(this.dateTimePickerIn_ValueChanged);
            // 
            // comboBoxOrgs
            // 
            this.comboBoxOrgs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxOrgs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxOrgs.BackColor = System.Drawing.Color.White;
            this.comboBoxOrgs.DataSource = this.firmBindingSource;
            this.comboBoxOrgs.DisplayMember = "Name";
            this.comboBoxOrgs.DropDownHeight = 200;
            this.comboBoxOrgs.DropDownWidth = 300;
            this.comboBoxOrgs.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOrgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.comboBoxOrgs.FormattingEnabled = true;
            this.comboBoxOrgs.IntegralHeight = false;
            this.comboBoxOrgs.Location = new System.Drawing.Point(12, 32);
            this.comboBoxOrgs.Name = "comboBoxOrgs";
            this.comboBoxOrgs.Size = new System.Drawing.Size(300, 27);
            this.comboBoxOrgs.TabIndex = 1;
            this.comboBoxOrgs.ValueMember = "Inn";
            this.comboBoxOrgs.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrgs_SelectedIndexChanged);
            this.comboBoxOrgs.Enter += new System.EventHandler(this.comboBoxOrgs_Enter);
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataSource = typeof(PartStat.Core.Models.DB.Firm);
            // 
            // labelCreateType
            // 
            this.labelCreateType.AutoSize = true;
            this.labelCreateType.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreateType.ForeColor = System.Drawing.Color.White;
            this.labelCreateType.Location = new System.Drawing.Point(1106, 11);
            this.labelCreateType.Name = "labelCreateType";
            this.labelCreateType.Size = new System.Drawing.Size(122, 19);
            this.labelCreateType.TabIndex = 13;
            this.labelCreateType.Text = "Категория списка:";
            // 
            // comboBoxCreateList
            // 
            this.comboBoxCreateList.BackColor = System.Drawing.Color.White;
            this.comboBoxCreateList.DataSource = this.createListBindingSource;
            this.comboBoxCreateList.DisplayMember = "Name";
            this.comboBoxCreateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCreateList.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCreateList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.comboBoxCreateList.FormattingEnabled = true;
            this.comboBoxCreateList.Location = new System.Drawing.Point(1110, 35);
            this.comboBoxCreateList.Name = "comboBoxCreateList";
            this.comboBoxCreateList.Size = new System.Drawing.Size(134, 27);
            this.comboBoxCreateList.TabIndex = 12;
            this.comboBoxCreateList.ValueMember = "Type";
            // 
            // createListBindingSource
            // 
            this.createListBindingSource.DataSource = typeof(PartStat.Core.Models.CreateList);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClass.ForeColor = System.Drawing.Color.White;
            this.labelClass.Location = new System.Drawing.Point(946, 12);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(131, 19);
            this.labelClass.TabIndex = 11;
            this.labelClass.Text = "Класс отправления:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(805, 11);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(65, 19);
            this.labelError.TabIndex = 11;
            this.labelError.Text = "Ошибки:";
            // 
            // comboBoxListClass
            // 
            this.comboBoxListClass.BackColor = System.Drawing.Color.White;
            this.comboBoxListClass.DataSource = this.interTypeBindingSource;
            this.comboBoxListClass.DisplayMember = "Name";
            this.comboBoxListClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListClass.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxListClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.comboBoxListClass.FormattingEnabled = true;
            this.comboBoxListClass.Location = new System.Drawing.Point(950, 36);
            this.comboBoxListClass.Name = "comboBoxListClass";
            this.comboBoxListClass.Size = new System.Drawing.Size(154, 27);
            this.comboBoxListClass.TabIndex = 11;
            this.comboBoxListClass.ValueMember = "Code";
            // 
            // interTypeBindingSource
            // 
            this.interTypeBindingSource.DataSource = typeof(PartStat.Core.Models.InterType);
            // 
            // comboBoxErrorList
            // 
            this.comboBoxErrorList.BackColor = System.Drawing.Color.White;
            this.comboBoxErrorList.DataSource = this.errorListBindingSource;
            this.comboBoxErrorList.DisplayMember = "Name";
            this.comboBoxErrorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxErrorList.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxErrorList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.comboBoxErrorList.FormattingEnabled = true;
            this.comboBoxErrorList.Location = new System.Drawing.Point(809, 35);
            this.comboBoxErrorList.Name = "comboBoxErrorList";
            this.comboBoxErrorList.Size = new System.Drawing.Size(135, 27);
            this.comboBoxErrorList.TabIndex = 10;
            this.comboBoxErrorList.ValueMember = "ErrorType";
            // 
            // errorListBindingSource
            // 
            this.errorListBindingSource.DataSource = typeof(PartStat.Core.Models.ErrorList);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.AllowUserToResizeRows = false;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.AutoGenerateColumns = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewList.ColumnHeadersHeight = 40;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkDataGridViewCheckBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.firmNameDataGridViewTextBoxColumn,
            this.interNameGridViewTextBoxColumn,
            this.manualNameGridViewTextBoxColumn,
            this.mailTypeDataGridViewTextBoxColumn,
            this.MailCategoryName,
            this.postMarkNameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.warnCountDataGridViewTextBoxColumn,
            this.errCountDataGridViewTextBoxColumn,
            this.massRateDataGridViewTextBoxColumn});
            this.dataGridViewList.DataSource = this.firmListBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewList.EnableHeadersVisualStyles = false;
            this.dataGridViewList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewList.Location = new System.Drawing.Point(0, 239);
            this.dataGridViewList.Name = "dataGridViewList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.RowHeadersWidth = 40;
            this.dataGridViewList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewList.RowTemplate.Height = 40;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(1273, 184);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.TabStop = false;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellDoubleClick);
            this.dataGridViewList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewList_CellMouseUp);
            this.dataGridViewList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewList_CellPainting);
            this.dataGridViewList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewList_ColumnHeaderMouseClick);
            this.dataGridViewList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewList_MouseClick);
            this.dataGridViewList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewList_MouseDoubleClick);
            // 
            // checkDataGridViewCheckBoxColumn
            // 
            this.checkDataGridViewCheckBoxColumn.DataPropertyName = "Check";
            this.checkDataGridViewCheckBoxColumn.FillWeight = 62.17617F;
            this.checkDataGridViewCheckBoxColumn.HeaderText = "";
            this.checkDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.checkDataGridViewCheckBoxColumn.Name = "checkDataGridViewCheckBoxColumn";
            this.checkDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.numDataGridViewTextBoxColumn.HeaderText = "Список";
            this.numDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmNameDataGridViewTextBoxColumn
            // 
            this.firmNameDataGridViewTextBoxColumn.DataPropertyName = "FirmName";
            this.firmNameDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.firmNameDataGridViewTextBoxColumn.HeaderText = "Орг";
            this.firmNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmNameDataGridViewTextBoxColumn.Name = "firmNameDataGridViewTextBoxColumn";
            this.firmNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interNameGridViewTextBoxColumn
            // 
            this.interNameGridViewTextBoxColumn.DataPropertyName = "InterName";
            this.interNameGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.interNameGridViewTextBoxColumn.HeaderText = "Класс";
            this.interNameGridViewTextBoxColumn.MinimumWidth = 6;
            this.interNameGridViewTextBoxColumn.Name = "interNameGridViewTextBoxColumn";
            this.interNameGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manualNameGridViewTextBoxColumn
            // 
            this.manualNameGridViewTextBoxColumn.DataPropertyName = "ManualName";
            this.manualNameGridViewTextBoxColumn.HeaderText = "Ручка";
            this.manualNameGridViewTextBoxColumn.MinimumWidth = 6;
            this.manualNameGridViewTextBoxColumn.Name = "manualNameGridViewTextBoxColumn";
            this.manualNameGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailTypeDataGridViewTextBoxColumn
            // 
            this.mailTypeDataGridViewTextBoxColumn.DataPropertyName = "MailTypeName";
            this.mailTypeDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.mailTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.mailTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailTypeDataGridViewTextBoxColumn.Name = "mailTypeDataGridViewTextBoxColumn";
            this.mailTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MailCategoryName
            // 
            this.MailCategoryName.DataPropertyName = "MailCategoryName";
            this.MailCategoryName.FillWeight = 103.4385F;
            this.MailCategoryName.HeaderText = "Категория";
            this.MailCategoryName.MinimumWidth = 6;
            this.MailCategoryName.Name = "MailCategoryName";
            this.MailCategoryName.ReadOnly = true;
            // 
            // postMarkNameDataGridViewTextBoxColumn
            // 
            this.postMarkNameDataGridViewTextBoxColumn.DataPropertyName = "PostMarkName";
            this.postMarkNameDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.postMarkNameDataGridViewTextBoxColumn.HeaderText = "Отм";
            this.postMarkNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postMarkNameDataGridViewTextBoxColumn.Name = "postMarkNameDataGridViewTextBoxColumn";
            this.postMarkNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.countDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warnCountDataGridViewTextBoxColumn
            // 
            this.warnCountDataGridViewTextBoxColumn.DataPropertyName = "WarnCount";
            this.warnCountDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.warnCountDataGridViewTextBoxColumn.HeaderText = "Зам";
            this.warnCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warnCountDataGridViewTextBoxColumn.Name = "warnCountDataGridViewTextBoxColumn";
            this.warnCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errCountDataGridViewTextBoxColumn
            // 
            this.errCountDataGridViewTextBoxColumn.DataPropertyName = "ErrCount";
            this.errCountDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.errCountDataGridViewTextBoxColumn.HeaderText = "Выб";
            this.errCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errCountDataGridViewTextBoxColumn.Name = "errCountDataGridViewTextBoxColumn";
            this.errCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // massRateDataGridViewTextBoxColumn
            // 
            this.massRateDataGridViewTextBoxColumn.DataPropertyName = "MassRate";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.massRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.massRateDataGridViewTextBoxColumn.FillWeight = 103.4385F;
            this.massRateDataGridViewTextBoxColumn.HeaderText = "Сбор";
            this.massRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.massRateDataGridViewTextBoxColumn.Name = "massRateDataGridViewTextBoxColumn";
            this.massRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmListBindingSource
            // 
            this.firmListBindingSource.DataSource = typeof(PartStat.Core.Models.DB.FirmList);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.uncheckAllToolStripMenuItem,
            this.toolStripSeparator8,
            this.checkFirmListStripMenuItem,
            this.uncheckFirmListStripMenuItem,
            this.toolStripSeparator9,
            this.inverseCheckToolStripMenuItem,
            this.toolStripSeparator10,
            this.setHandToolStripMenuItem,
            this.toolStripSeparator11});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(346, 256);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.checkAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkAllToolStripMenuItem.Image")));
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(345, 38);
            this.checkAllToolStripMenuItem.Text = "Отметить все";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.uncheckAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uncheckAllToolStripMenuItem.Image")));
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(345, 38);
            this.uncheckAllToolStripMenuItem.Text = "Снять все отметки";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(342, 6);
            // 
            // checkFirmListStripMenuItem
            // 
            this.checkFirmListStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.checkFirmListStripMenuItem.Image = global::PartStat.Properties.Resources.checked_32;
            this.checkFirmListStripMenuItem.Name = "checkFirmListStripMenuItem";
            this.checkFirmListStripMenuItem.Size = new System.Drawing.Size(345, 38);
            this.checkFirmListStripMenuItem.Text = "Отметить организацию";
            this.checkFirmListStripMenuItem.Click += new System.EventHandler(this.checkFirmListStripMenuItem_Click);
            // 
            // uncheckFirmListStripMenuItem
            // 
            this.uncheckFirmListStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.uncheckFirmListStripMenuItem.Image = global::PartStat.Properties.Resources.unchecked_32;
            this.uncheckFirmListStripMenuItem.Name = "uncheckFirmListStripMenuItem";
            this.uncheckFirmListStripMenuItem.Size = new System.Drawing.Size(345, 38);
            this.uncheckFirmListStripMenuItem.Text = "Снять отметки с организации";
            this.uncheckFirmListStripMenuItem.Click += new System.EventHandler(this.uncheckFirmListStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(342, 6);
            // 
            // inverseCheckToolStripMenuItem
            // 
            this.inverseCheckToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.inverseCheckToolStripMenuItem.Name = "inverseCheckToolStripMenuItem";
            this.inverseCheckToolStripMenuItem.Size = new System.Drawing.Size(345, 38);
            this.inverseCheckToolStripMenuItem.Text = "Инвертировать отмеченные списки";
            this.inverseCheckToolStripMenuItem.Click += new System.EventHandler(this.inverseCheckToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(342, 6);
            // 
            // setHandToolStripMenuItem
            // 
            this.setHandToolStripMenuItem.Enabled = false;
            this.setHandToolStripMenuItem.Name = "setHandToolStripMenuItem";
            this.setHandToolStripMenuItem.Size = new System.Drawing.Size(345, 38);
            this.setHandToolStripMenuItem.Text = "Сделать ручным списком";
            this.setHandToolStripMenuItem.Click += new System.EventHandler(this.setHandToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(342, 6);
            // 
            // dataGridViewStat
            // 
            this.dataGridViewStat.AllowUserToAddRows = false;
            this.dataGridViewStat.AllowUserToDeleteRows = false;
            this.dataGridViewStat.AllowUserToResizeRows = false;
            this.dataGridViewStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStat.AutoGenerateColumns = false;
            this.dataGridViewStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStat.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewStat.ColumnHeadersHeight = 30;
            this.dataGridViewStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.listCountDataGridViewTextBoxColumn,
            this.warnDataGridViewTextBoxColumn,
            this.errorDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn1,
            this.rateDataGridViewTextBoxColumn});
            this.dataGridViewStat.DataSource = this.statDataBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStat.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewStat.EnableHeadersVisualStyles = false;
            this.dataGridViewStat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewStat.Location = new System.Drawing.Point(0, 427);
            this.dataGridViewStat.MultiSelect = false;
            this.dataGridViewStat.Name = "dataGridViewStat";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStat.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewStat.RowHeadersVisible = false;
            this.dataGridViewStat.RowHeadersWidth = 30;
            this.dataGridViewStat.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewStat.RowTemplate.Height = 30;
            this.dataGridViewStat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStat.Size = new System.Drawing.Size(1273, 120);
            this.dataGridViewStat.TabIndex = 0;
            this.dataGridViewStat.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Вид статистики";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listCountDataGridViewTextBoxColumn
            // 
            this.listCountDataGridViewTextBoxColumn.DataPropertyName = "ListCount";
            this.listCountDataGridViewTextBoxColumn.HeaderText = "Списков";
            this.listCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.listCountDataGridViewTextBoxColumn.Name = "listCountDataGridViewTextBoxColumn";
            this.listCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warnDataGridViewTextBoxColumn
            // 
            this.warnDataGridViewTextBoxColumn.DataPropertyName = "Warn";
            this.warnDataGridViewTextBoxColumn.HeaderText = "Замечаний";
            this.warnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warnDataGridViewTextBoxColumn.Name = "warnDataGridViewTextBoxColumn";
            this.warnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorDataGridViewTextBoxColumn
            // 
            this.errorDataGridViewTextBoxColumn.DataPropertyName = "Error";
            this.errorDataGridViewTextBoxColumn.HeaderText = "Выбыло";
            this.errorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorDataGridViewTextBoxColumn.Name = "errorDataGridViewTextBoxColumn";
            this.errorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.rateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.rateDataGridViewTextBoxColumn.HeaderText = "Плата";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statDataBindingSource
            // 
            this.statDataBindingSource.DataSource = typeof(PartStat.Core.Libs.Stats.StatObject.StatData);
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // panelType
            // 
            this.panelType.BackColor = System.Drawing.Color.SeaGreen;
            this.panelType.Controls.Add(this.labelCreateType);
            this.panelType.Controls.Add(this.labelMailCategory);
            this.panelType.Controls.Add(this.comboBoxCreateList);
            this.panelType.Controls.Add(this.labelClass);
            this.panelType.Controls.Add(this.labelListStatus);
            this.panelType.Controls.Add(this.comboBoxListClass);
            this.panelType.Controls.Add(this.labelError);
            this.panelType.Controls.Add(this.labelMailType);
            this.panelType.Controls.Add(this.comboBoxListStatus);
            this.panelType.Controls.Add(this.comboBoxErrorList);
            this.panelType.Controls.Add(this.comboBoxMailCategory);
            this.panelType.Controls.Add(this.comboBoxMailType);
            this.panelType.Controls.Add(this.labelListOut);
            this.panelType.Controls.Add(this.labelListIn);
            this.panelType.Controls.Add(this.textBoxListOut);
            this.panelType.Controls.Add(this.textBoxListIn);
            this.panelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panelType.Location = new System.Drawing.Point(0, 115);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(1273, 75);
            this.panelType.TabIndex = 7;
            this.panelType.Paint += new System.Windows.Forms.PaintEventHandler(this.panelType_Paint);
            // 
            // labelMailCategory
            // 
            this.labelMailCategory.AutoSize = true;
            this.labelMailCategory.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMailCategory.ForeColor = System.Drawing.Color.White;
            this.labelMailCategory.Location = new System.Drawing.Point(418, 11);
            this.labelMailCategory.Name = "labelMailCategory";
            this.labelMailCategory.Size = new System.Drawing.Size(161, 19);
            this.labelMailCategory.TabIndex = 7;
            this.labelMailCategory.Text = "Категория отправления:";
            // 
            // labelListStatus
            // 
            this.labelListStatus.AutoSize = true;
            this.labelListStatus.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListStatus.ForeColor = System.Drawing.Color.White;
            this.labelListStatus.Location = new System.Drawing.Point(616, 11);
            this.labelListStatus.Name = "labelListStatus";
            this.labelListStatus.Size = new System.Drawing.Size(99, 19);
            this.labelListStatus.TabIndex = 6;
            this.labelListStatus.Text = "Статус списка:";
            // 
            // labelMailType
            // 
            this.labelMailType.AutoSize = true;
            this.labelMailType.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMailType.ForeColor = System.Drawing.Color.White;
            this.labelMailType.Location = new System.Drawing.Point(220, 11);
            this.labelMailType.Name = "labelMailType";
            this.labelMailType.Size = new System.Drawing.Size(121, 19);
            this.labelMailType.TabIndex = 6;
            this.labelMailType.Text = "Вид отправления:";
            // 
            // comboBoxListStatus
            // 
            this.comboBoxListStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxListStatus.DataSource = this.listStatusBindingSource;
            this.comboBoxListStatus.DisplayMember = "Name";
            this.comboBoxListStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListStatus.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxListStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.comboBoxListStatus.FormattingEnabled = true;
            this.comboBoxListStatus.Location = new System.Drawing.Point(620, 36);
            this.comboBoxListStatus.Name = "comboBoxListStatus";
            this.comboBoxListStatus.Size = new System.Drawing.Size(183, 27);
            this.comboBoxListStatus.TabIndex = 9;
            this.comboBoxListStatus.ValueMember = "Id";
            // 
            // listStatusBindingSource
            // 
            this.listStatusBindingSource.DataSource = typeof(PartStat.Core.Models.DB.ListStatus);
            // 
            // comboBoxMailCategory
            // 
            this.comboBoxMailCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxMailCategory.DataSource = this.mailCategoryBindingSource;
            this.comboBoxMailCategory.DisplayMember = "ShortName";
            this.comboBoxMailCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMailCategory.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMailCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.comboBoxMailCategory.FormattingEnabled = true;
            this.comboBoxMailCategory.Location = new System.Drawing.Point(422, 36);
            this.comboBoxMailCategory.Name = "comboBoxMailCategory";
            this.comboBoxMailCategory.Size = new System.Drawing.Size(192, 27);
            this.comboBoxMailCategory.TabIndex = 8;
            this.comboBoxMailCategory.ValueMember = "Id";
            // 
            // mailCategoryBindingSource
            // 
            this.mailCategoryBindingSource.DataSource = typeof(PartStat.Core.Models.DB.MailCategory);
            // 
            // comboBoxMailType
            // 
            this.comboBoxMailType.BackColor = System.Drawing.Color.White;
            this.comboBoxMailType.DataSource = this.mailTypeBindingSource;
            this.comboBoxMailType.DisplayMember = "ShortName";
            this.comboBoxMailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMailType.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMailType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.comboBoxMailType.FormattingEnabled = true;
            this.comboBoxMailType.Location = new System.Drawing.Point(224, 36);
            this.comboBoxMailType.Name = "comboBoxMailType";
            this.comboBoxMailType.Size = new System.Drawing.Size(192, 27);
            this.comboBoxMailType.TabIndex = 7;
            this.comboBoxMailType.ValueMember = "Id";
            // 
            // mailTypeBindingSource
            // 
            this.mailTypeBindingSource.DataSource = typeof(PartStat.Core.Models.DB.MailType);
            // 
            // labelListOut
            // 
            this.labelListOut.AutoSize = true;
            this.labelListOut.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListOut.ForeColor = System.Drawing.Color.White;
            this.labelListOut.Location = new System.Drawing.Point(114, 11);
            this.labelListOut.Name = "labelListOut";
            this.labelListOut.Size = new System.Drawing.Size(77, 19);
            this.labelListOut.TabIndex = 4;
            this.labelListOut.Text = "По список:";
            // 
            // labelListIn
            // 
            this.labelListIn.AutoSize = true;
            this.labelListIn.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListIn.ForeColor = System.Drawing.Color.White;
            this.labelListIn.Location = new System.Drawing.Point(12, 11);
            this.labelListIn.Name = "labelListIn";
            this.labelListIn.Size = new System.Drawing.Size(75, 19);
            this.labelListIn.TabIndex = 4;
            this.labelListIn.Text = "Со списка:";
            // 
            // textBoxListOut
            // 
            this.textBoxListOut.BackColor = System.Drawing.Color.White;
            this.textBoxListOut.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxListOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.textBoxListOut.Location = new System.Drawing.Point(118, 35);
            this.textBoxListOut.Name = "textBoxListOut";
            this.textBoxListOut.Size = new System.Drawing.Size(100, 29);
            this.textBoxListOut.TabIndex = 6;
            this.textBoxListOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // textBoxListIn
            // 
            this.textBoxListIn.BackColor = System.Drawing.Color.White;
            this.textBoxListIn.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxListIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.textBoxListIn.Location = new System.Drawing.Point(12, 35);
            this.textBoxListIn.Name = "textBoxListIn";
            this.textBoxListIn.Size = new System.Drawing.Size(100, 29);
            this.textBoxListIn.TabIndex = 5;
            this.textBoxListIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btnRevise);
            this.panel1.Controls.Add(this.btnPrintReport);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnUncheckAll);
            this.panel1.Controls.Add(this.btnCheckAll);
            this.panel1.Controls.Add(this.checkBoxPrintPreview);
            this.panel1.Controls.Add(this.labelBarcode);
            this.panel1.Controls.Add(this.tbBarcode);
            this.panel1.Controls.Add(this.btnTablePrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 53);
            this.panel1.TabIndex = 8;
            // 
            // btnRevise
            // 
            this.btnRevise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevise.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRevise.BackColor = System.Drawing.Color.DimGray;
            this.btnRevise.Enabled = false;
            this.btnRevise.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRevise.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btnRevise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevise.ForeColor = System.Drawing.Color.White;
            this.btnRevise.Location = new System.Drawing.Point(965, 6);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(139, 40);
            this.btnRevise.TabIndex = 18;
            this.btnRevise.Text = "Сверка";
            this.btnRevise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRevise.UseVisualStyleBackColor = false;
            this.btnRevise.CheckedChanged += new System.EventHandler(this.btnRevise_CheckedChanged);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.Color.SlateGray;
            this.btnPrintReport.Enabled = false;
            this.btnPrintReport.FlatAppearance.BorderSize = 0;
            this.btnPrintReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.Image = global::PartStat.Properties.Resources.Portable_Printer;
            this.btnPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintReport.Location = new System.Drawing.Point(456, 6);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(172, 40);
            this.btnPrintReport.TabIndex = 17;
            this.btnPrintReport.Text = "Печать отчета";
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SlateGray;
            this.btnReport.Enabled = false;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::PartStat.Properties.Resources.Invoice;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(343, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 40);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "Отчет";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.BackColor = System.Drawing.Color.Gray;
            this.btnUncheckAll.FlatAppearance.BorderSize = 0;
            this.btnUncheckAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnUncheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUncheckAll.ForeColor = System.Drawing.Color.White;
            this.btnUncheckAll.Image = global::PartStat.Properties.Resources.gray_unchecked_32;
            this.btnUncheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUncheckAll.Location = new System.Drawing.Point(763, 6);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(40, 40);
            this.btnUncheckAll.TabIndex = 16;
            this.btnUncheckAll.UseVisualStyleBackColor = false;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.Gray;
            this.btnCheckAll.FlatAppearance.BorderSize = 0;
            this.btnCheckAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAll.ForeColor = System.Drawing.Color.White;
            this.btnCheckAll.Image = global::PartStat.Properties.Resources.gray_checked_32;
            this.btnCheckAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckAll.Location = new System.Drawing.Point(717, 6);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(40, 40);
            this.btnCheckAll.TabIndex = 15;
            this.btnCheckAll.UseVisualStyleBackColor = false;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // checkBoxPrintPreview
            // 
            this.checkBoxPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPrintPreview.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPrintPreview.Checked = true;
            this.checkBoxPrintPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrintPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkBoxPrintPreview.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkBoxPrintPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkBoxPrintPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkBoxPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPrintPreview.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPrintPreview.ForeColor = System.Drawing.Color.White;
            this.checkBoxPrintPreview.Image = global::PartStat.Properties.Resources.white_checked_32;
            this.checkBoxPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxPrintPreview.Location = new System.Drawing.Point(1106, 0);
            this.checkBoxPrintPreview.Name = "checkBoxPrintPreview";
            this.checkBoxPrintPreview.Size = new System.Drawing.Size(159, 50);
            this.checkBoxPrintPreview.TabIndex = 0;
            this.checkBoxPrintPreview.TabStop = false;
            this.checkBoxPrintPreview.Text = "Предпросмотр";
            this.checkBoxPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxPrintPreview.UseVisualStyleBackColor = false;
            this.checkBoxPrintPreview.CheckedChanged += new System.EventHandler(this.checkBoxPrintPreview_CheckedChanged);
            this.checkBoxPrintPreview.CheckStateChanged += new System.EventHandler(this.checkBoxPrintPreview_CheckStateChanged);
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBarcode.ForeColor = System.Drawing.Color.White;
            this.labelBarcode.Location = new System.Drawing.Point(8, 17);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(45, 19);
            this.labelBarcode.TabIndex = 0;
            this.labelBarcode.Text = "ШПИ:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.BackColor = System.Drawing.Color.White;
            this.tbBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBarcode.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbBarcode.Location = new System.Drawing.Point(65, 12);
            this.tbBarcode.MaxLength = 14;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(153, 29);
            this.tbBarcode.TabIndex = 13;
            this.tbBarcode.Enter += new System.EventHandler(this.tbBarcode_Enter);
            this.tbBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBarcode_KeyDown);
            // 
            // btnTablePrint
            // 
            this.btnTablePrint.BackColor = System.Drawing.Color.SlateGray;
            this.btnTablePrint.FlatAppearance.BorderSize = 0;
            this.btnTablePrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnTablePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablePrint.ForeColor = System.Drawing.Color.White;
            this.btnTablePrint.Image = global::PartStat.Properties.Resources.Printer;
            this.btnTablePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablePrint.Location = new System.Drawing.Point(224, 6);
            this.btnTablePrint.Name = "btnTablePrint";
            this.btnTablePrint.Size = new System.Drawing.Size(113, 40);
            this.btnTablePrint.TabIndex = 14;
            this.btnTablePrint.Text = "Печать";
            this.btnTablePrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTablePrint.UseVisualStyleBackColor = false;
            this.btnTablePrint.Click += new System.EventHandler(this.btnTablePrint_Click);
            // 
            // imageListCheckBox
            // 
            this.imageListCheckBox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCheckBox.ImageStream")));
            this.imageListCheckBox.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCheckBox.Images.SetKeyName(0, "white_checked-32.png");
            this.imageListCheckBox.Images.SetKeyName(1, "white-unchecked-32.png");
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1273, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelType);
            this.Controls.Add(this.dataGridViewStat);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.status);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.SizeChanged += new System.EventHandler(this.GeneralForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmListBindingSource)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDataBindingSource)).EndInit();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.DataGridView dataGridViewStat;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ComboBox comboBoxOrgs;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem transToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.Label labelOrg;
        private System.Windows.Forms.Label labelDateOut;
        private System.Windows.Forms.Label labelDateIn;
        private System.Windows.Forms.Label labelListOut;
        private System.Windows.Forms.Label labelListIn;
        private System.Windows.Forms.TextBox textBoxListOut;
        private System.Windows.Forms.TextBox textBoxListIn;
        private System.Windows.Forms.ComboBox comboBoxMailCategory;
        private System.Windows.Forms.ComboBox comboBoxMailType;
        private System.Windows.Forms.Label labelMailCategory;
        private System.Windows.Forms.Label labelMailType;
        private System.Windows.Forms.ComboBox comboBoxListStatus;
        private System.Windows.Forms.Label labelListStatus;
        private System.Windows.Forms.BindingSource mailCategoryBindingSource;
        private System.Windows.Forms.BindingSource mailTypeBindingSource;
        private System.Windows.Forms.BindingSource listStatusBindingSource;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.BindingSource firmListBindingSource;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnTablePrint;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tarifsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem firstMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstParcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem interMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interParcelToolStripMenuItem;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.ComboBox comboBoxErrorList;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.BindingSource errorListBindingSource;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxListClass;
        private System.Windows.Forms.BindingSource interTypeBindingSource;
        private System.Windows.Forms.CheckBox checkBoxPrintPreview;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.BindingSource statDataBindingSource;
        private System.Windows.Forms.Label labelCreateType;
        private System.Windows.Forms.ComboBox comboBoxCreateList;
        private System.Windows.Forms.BindingSource createListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.ImageList imageListCheckBox;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem checkFirmListStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckFirmListStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem inverseCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interNameGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manualNameGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn postMarkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warnCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn massRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.ToolStripMenuItem setHandToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.CheckBox btnRevise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem reportManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem massReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem orgReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valueReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

