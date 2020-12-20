namespace AOP.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.labelDateOut = new System.Windows.Forms.Label();
            this.labelDateIn = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.panelType = new System.Windows.Forms.Panel();
            this.labelMailCategory = new System.Windows.Forms.Label();
            this.labelMailType = new System.Windows.Forms.Label();
            this.comboBoxMailCategory = new System.Windows.Forms.ComboBox();
            this.mailCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMailType = new System.Windows.Forms.ComboBox();
            this.mailTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelListOut = new System.Windows.Forms.Label();
            this.labelListIn = new System.Windows.Forms.Label();
            this.textBoxListOut = new System.Windows.Forms.TextBox();
            this.textBoxListIn = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelInfoLicense = new System.Windows.Forms.Label();
            this.labelLicense = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.checkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateDataGridViewTextBoxColumn = new WcApi.Win32.Widgets.CalendarColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.a4exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.c5exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.excelExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.exportAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.btnSaveDir = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).BeginInit();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpoListBindingSource)).BeginInit();
            this.contextMenuTable.SuspendLayout();
            this.SuspendLayout();
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
            this.settingsMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1116, 40);
            this.menu.TabIndex = 4;
            this.menu.Text = "Меню";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.fileMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.fileMenuItem.Size = new System.Drawing.Size(81, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exitMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitMenuItem.Image")));
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(148, 28);
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
            this.reportsToolStripMenuItem.Enabled = false;
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // reportManagementToolStripMenuItem
            // 
            this.reportManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.reportManagementToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportManagementToolStripMenuItem.Name = "reportManagementToolStripMenuItem";
            this.reportManagementToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.reportManagementToolStripMenuItem.Text = "Управление отчетами";
            // 
            // reportsAllToolStripMenuItem
            // 
            this.reportsAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.reportsAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportsAllToolStripMenuItem.Name = "reportsAllToolStripMenuItem";
            this.reportsAllToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.reportsAllToolStripMenuItem.Text = "Все отчеты";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(258, 6);
            // 
            // valueReportToolStripMenuItem
            // 
            this.valueReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.valueReportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.valueReportToolStripMenuItem.Name = "valueReportToolStripMenuItem";
            this.valueReportToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.valueReportToolStripMenuItem.Text = "Отчет по ценным";
            // 
            // handReportToolStripMenuItem
            // 
            this.handReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.handReportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.handReportToolStripMenuItem.Name = "handReportToolStripMenuItem";
            this.handReportToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.handReportToolStripMenuItem.Text = "Отчет по ручке";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(258, 6);
            // 
            // massReportToolStripMenuItem
            // 
            this.massReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.massReportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.massReportToolStripMenuItem.Name = "massReportToolStripMenuItem";
            this.massReportToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.massReportToolStripMenuItem.Text = "Отчет по весу";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(258, 6);
            // 
            // orgReportToolStripMenuItem
            // 
            this.orgReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.orgReportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgReportToolStripMenuItem.Name = "orgReportToolStripMenuItem";
            this.orgReportToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.orgReportToolStripMenuItem.Text = "Отчет по организации";
            // 
            // transToolStripMenuItem
            // 
            this.transToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.transToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.transToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transToolStripMenuItem.Name = "transToolStripMenuItem";
            this.transToolStripMenuItem.Size = new System.Drawing.Size(140, 36);
            this.transToolStripMenuItem.Text = "Отправления";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.typeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.typeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(164, 28);
            this.typeToolStripMenuItem.Text = "Виды";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(164, 28);
            this.categoryToolStripMenuItem.Text = "Категории";
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
            this.tarifsToolStripMenuItem.Enabled = false;
            this.tarifsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tarifsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tarifsToolStripMenuItem.Name = "tarifsToolStripMenuItem";
            this.tarifsToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.tarifsToolStripMenuItem.Text = "Тарифы";
            // 
            // noticeToolStripMenuItem
            // 
            this.noticeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noticeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.noticeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.noticeToolStripMenuItem.Name = "noticeToolStripMenuItem";
            this.noticeToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.noticeToolStripMenuItem.Text = "Уведомления";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(303, 6);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.mailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.mailToolStripMenuItem.Text = "Письма";
            // 
            // parcelToolStripMenuItem
            // 
            this.parcelToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.parcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.parcelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.parcelToolStripMenuItem.Name = "parcelToolStripMenuItem";
            this.parcelToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.parcelToolStripMenuItem.Text = "Бандероли";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(303, 6);
            // 
            // firstMailToolStripMenuItem
            // 
            this.firstMailToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstMailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.firstMailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.firstMailToolStripMenuItem.Name = "firstMailToolStripMenuItem";
            this.firstMailToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.firstMailToolStripMenuItem.Text = "Письма 1 класс";
            // 
            // firstParcelToolStripMenuItem
            // 
            this.firstParcelToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstParcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.firstParcelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.firstParcelToolStripMenuItem.Name = "firstParcelToolStripMenuItem";
            this.firstParcelToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.firstParcelToolStripMenuItem.Text = "Бандероли 1 класс";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(303, 6);
            // 
            // interMailToolStripMenuItem
            // 
            this.interMailToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.interMailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.interMailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.interMailToolStripMenuItem.Name = "interMailToolStripMenuItem";
            this.interMailToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.interMailToolStripMenuItem.Text = "Международные письма";
            // 
            // interParcelToolStripMenuItem
            // 
            this.interParcelToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.interParcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.interParcelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.interParcelToolStripMenuItem.Name = "interParcelToolStripMenuItem";
            this.interParcelToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.interParcelToolStripMenuItem.Text = "Международные бандероли";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripSeparator3,
            this.configToolStripMenuItem,
            this.toolStripSeparator1,
            this.colorsToolStripMenuItem,
            this.toolStripSeparator7,
            this.licenseToolStripMenuItem,
            this.toolStripSeparator12,
            this.printerToolStripMenuItem});
            this.settingsMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.settingsMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.settingsMenuItem.Size = new System.Drawing.Size(129, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.connectToolStripMenuItem.Enabled = false;
            this.connectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.connectToolStripMenuItem.Text = "Подключение к БД";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.configToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.configToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.configToolStripMenuItem.Text = "Настройки";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.colorsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.colorsToolStripMenuItem.Text = "Цвета";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(229, 6);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.licenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.licenseToolStripMenuItem.Text = "Лицензия";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(229, 6);
            // 
            // printerToolStripMenuItem
            // 
            this.printerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.printerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.printerToolStripMenuItem.Name = "printerToolStripMenuItem";
            this.printerToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.printerToolStripMenuItem.Text = "Принтер";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelFilter.Controls.Add(this.btnSaveDir);
            this.panelFilter.Controls.Add(this.labelPath);
            this.panelFilter.Controls.Add(this.textBoxSavePath);
            this.panelFilter.Controls.Add(this.btnLoad);
            this.panelFilter.Controls.Add(this.labelDateOut);
            this.panelFilter.Controls.Add(this.labelDateIn);
            this.panelFilter.Controls.Add(this.btnClearFilter);
            this.panelFilter.Controls.Add(this.dateTimePickerOut);
            this.panelFilter.Controls.Add(this.dateTimePickerIn);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panelFilter.Location = new System.Drawing.Point(0, 40);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1116, 75);
            this.panelFilter.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Brown;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(424, 24);
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
            this.labelDateOut.Location = new System.Drawing.Point(214, 7);
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
            this.labelDateIn.Location = new System.Drawing.Point(8, 7);
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
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(557, 24);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(40, 40);
            this.btnClearFilter.TabIndex = 0;
            this.btnClearFilter.TabStop = false;
            this.btnClearFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePickerOut.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerOut.Location = new System.Drawing.Point(218, 31);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerOut.TabIndex = 3;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePickerIn.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerIn.Checked = false;
            this.dateTimePickerIn.Location = new System.Drawing.Point(12, 31);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerIn.TabIndex = 2;
            this.dateTimePickerIn.ValueChanged += new System.EventHandler(this.dateTimePickerIn_ValueChanged);
            // 
            // panelType
            // 
            this.panelType.BackColor = System.Drawing.Color.SteelBlue;
            this.panelType.Controls.Add(this.labelMailCategory);
            this.panelType.Controls.Add(this.labelMailType);
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
            this.panelType.Size = new System.Drawing.Size(1116, 75);
            this.panelType.TabIndex = 8;
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
            this.mailCategoryBindingSource.DataSource = typeof(WcApi.Post.Types.MailCategory);
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
            this.mailTypeBindingSource.DataSource = typeof(WcApi.Post.Types.MailType);
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
            // status
            // 
            this.status.Font = new System.Drawing.Font("Consolas", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.status.Location = new System.Drawing.Point(0, 428);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1116, 22);
            this.status.TabIndex = 10;
            this.status.Text = "Статус";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(987, 17);
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
            // labelInfoLicense
            // 
            this.labelInfoLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoLicense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelInfoLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelInfoLicense.Location = new System.Drawing.Point(900, 0);
            this.labelInfoLicense.Name = "labelInfoLicense";
            this.labelInfoLicense.Size = new System.Drawing.Size(113, 40);
            this.labelInfoLicense.TabIndex = 11;
            this.labelInfoLicense.Text = "Лицензия до:";
            this.labelInfoLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLicense
            // 
            this.labelLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLicense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLicense.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLicense.Location = new System.Drawing.Point(1019, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(85, 40);
            this.labelLicense.TabIndex = 12;
            this.labelLicense.Text = "01.01.0001";
            this.labelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 31);
            this.panel1.TabIndex = 13;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.AllowUserToResizeRows = false;
            this.dataGridViewList.AutoGenerateColumns = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewList.ColumnHeadersHeight = 40;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkDataGridViewCheckBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.errorCountDataGridViewTextBoxColumn});
            this.dataGridViewList.DataSource = this.rpoListBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.EnableHeadersVisualStyles = false;
            this.dataGridViewList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewList.Location = new System.Drawing.Point(0, 221);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.RowHeadersWidth = 40;
            this.dataGridViewList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewList.RowTemplate.Height = 40;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.ShowCellErrors = false;
            this.dataGridViewList.ShowRowErrors = false;
            this.dataGridViewList.Size = new System.Drawing.Size(1116, 207);
            this.dataGridViewList.TabIndex = 14;
            this.dataGridViewList.TabStop = false;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellDoubleClick);
            this.dataGridViewList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewList_CellMouseUp);
            this.dataGridViewList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewList_CellPainting);
            this.dataGridViewList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewList_ColumnHeaderMouseClick);
            this.dataGridViewList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewList_DataError);
            this.dataGridViewList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewList_MouseClick);
            // 
            // checkDataGridViewCheckBoxColumn
            // 
            this.checkDataGridViewCheckBoxColumn.DataPropertyName = "Check";
            this.checkDataGridViewCheckBoxColumn.FillWeight = 81.21828F;
            this.checkDataGridViewCheckBoxColumn.HeaderText = "Отм";
            this.checkDataGridViewCheckBoxColumn.Name = "checkDataGridViewCheckBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.numDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.DataSource = this.mailTypeBindingSource;
            this.typeDataGridViewTextBoxColumn.DisplayMember = "ShortName";
            this.typeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.typeDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeDataGridViewTextBoxColumn.HeaderText = "Вид";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.DataSource = this.mailCategoryBindingSource;
            this.categoryDataGridViewTextBoxColumn.DisplayMember = "ShortName";
            this.categoryDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.categoryDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.categoryDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.countDataGridViewTextBoxColumn.HeaderText = "Отправлений";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorCountDataGridViewTextBoxColumn
            // 
            this.errorCountDataGridViewTextBoxColumn.DataPropertyName = "ErrorCount";
            this.errorCountDataGridViewTextBoxColumn.FillWeight = 102.6831F;
            this.errorCountDataGridViewTextBoxColumn.HeaderText = "Ошибок";
            this.errorCountDataGridViewTextBoxColumn.Name = "errorCountDataGridViewTextBoxColumn";
            this.errorCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rpoListBindingSource
            // 
            this.rpoListBindingSource.DataSource = typeof(AOP.Core.Models.DB.RpoList);
            // 
            // contextMenuTable
            // 
            this.contextMenuTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuTable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuTable.ImageScalingSize = new System.Drawing.Size(28, 32);
            this.contextMenuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a4exportMenuItem,
            this.toolStripSeparator8,
            this.c5exportMenuItem,
            this.toolStripSeparator2,
            this.excelExportMenuItem,
            this.toolStripSeparator9,
            this.exportAllMenuItem,
            this.toolStripSeparator10});
            this.contextMenuTable.Name = "contextMenuTable";
            this.contextMenuTable.Size = new System.Drawing.Size(197, 180);
            // 
            // a4exportMenuItem
            // 
            this.a4exportMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a4exportMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.a4exportMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("a4exportMenuItem.Image")));
            this.a4exportMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.a4exportMenuItem.Name = "a4exportMenuItem";
            this.a4exportMenuItem.Size = new System.Drawing.Size(196, 38);
            this.a4exportMenuItem.Text = "Экспорт в А4";
            this.a4exportMenuItem.Click += new System.EventHandler(this.a4exportMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(193, 6);
            // 
            // c5exportMenuItem
            // 
            this.c5exportMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c5exportMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.c5exportMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("c5exportMenuItem.Image")));
            this.c5exportMenuItem.Name = "c5exportMenuItem";
            this.c5exportMenuItem.Size = new System.Drawing.Size(196, 38);
            this.c5exportMenuItem.Text = "Экспорт в С5";
            this.c5exportMenuItem.Click += new System.EventHandler(this.c5exportMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // excelExportMenuItem
            // 
            this.excelExportMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelExportMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.excelExportMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excelExportMenuItem.Image")));
            this.excelExportMenuItem.Name = "excelExportMenuItem";
            this.excelExportMenuItem.Size = new System.Drawing.Size(196, 38);
            this.excelExportMenuItem.Text = "Экспорт в Excel";
            this.excelExportMenuItem.Click += new System.EventHandler(this.excelExportMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(193, 6);
            // 
            // exportAllMenuItem
            // 
            this.exportAllMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exportAllMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportAllMenuItem.Image")));
            this.exportAllMenuItem.Name = "exportAllMenuItem";
            this.exportAllMenuItem.Size = new System.Drawing.Size(196, 38);
            this.exportAllMenuItem.Text = "Экспорт Авто";
            this.exportAllMenuItem.Click += new System.EventHandler(this.exportAllMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(193, 6);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InterName";
            this.dataGridViewTextBoxColumn1.FillWeight = 103.4385F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Класс";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ManualName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ручка";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MailTypeName";
            this.dataGridViewTextBoxColumn3.FillWeight = 103.4385F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MailCategoryName";
            this.dataGridViewTextBoxColumn4.FillWeight = 103.4385F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 76;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PostMarkName";
            this.dataGridViewTextBoxColumn5.FillWeight = 103.4385F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Отм";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 76;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 73;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Num";
            this.dataGridViewTextBoxColumn7.HeaderText = "Num";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 74;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 73;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn9.HeaderText = "Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 74;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn10.HeaderText = "Category";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 73;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn11.HeaderText = "Count";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 74;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ErrorCount";
            this.dataGridViewTextBoxColumn12.HeaderText = "ErrorCount";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 73;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn13.HeaderText = "Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 74;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn14.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 73;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ЕнзуName";
            this.dataGridViewTextBoxColumn15.HeaderText = "ЕнзуName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 74;
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSavePath.BackColor = System.Drawing.Color.White;
            this.textBoxSavePath.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSavePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.textBoxSavePath.Location = new System.Drawing.Point(750, 30);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.ReadOnly = true;
            this.textBoxSavePath.Size = new System.Drawing.Size(308, 29);
            this.textBoxSavePath.TabIndex = 6;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.ForeColor = System.Drawing.Color.White;
            this.labelPath.Location = new System.Drawing.Point(625, 35);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(119, 19);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Путь сохранения:";
            // 
            // btnSaveDir
            // 
            this.btnSaveDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDir.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveDir.FlatAppearance.BorderSize = 0;
            this.btnSaveDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSaveDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDir.ForeColor = System.Drawing.Color.White;
            this.btnSaveDir.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDir.Image")));
            this.btnSaveDir.Location = new System.Drawing.Point(1064, 24);
            this.btnSaveDir.Name = "btnSaveDir";
            this.btnSaveDir.Size = new System.Drawing.Size(40, 40);
            this.btnSaveDir.TabIndex = 8;
            this.btnSaveDir.TabStop = false;
            this.btnSaveDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDir.UseVisualStyleBackColor = false;
            this.btnSaveDir.Click += new System.EventHandler(this.btnSaveDir_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelInfoLicense);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panelType);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralForm";
            this.Text = "AOP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpoListBindingSource)).EndInit();
            this.contextMenuTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem valueReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem massReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem orgReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label labelDateOut;
        private System.Windows.Forms.Label labelDateIn;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.Label labelMailCategory;
        private System.Windows.Forms.Label labelMailType;
        private System.Windows.Forms.ComboBox comboBoxMailCategory;
        private System.Windows.Forms.ComboBox comboBoxMailType;
        private System.Windows.Forms.Label labelListOut;
        private System.Windows.Forms.Label labelListIn;
        private System.Windows.Forms.TextBox textBoxListOut;
        private System.Windows.Forms.TextBox textBoxListIn;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Label labelInfoLicense;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.BindingSource rpoListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingSource mailCategoryBindingSource;
        private System.Windows.Forms.BindingSource mailTypeBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuTable;
        private System.Windows.Forms.ToolStripMenuItem a4exportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c5exportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelExportMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkDataGridViewCheckBoxColumn;
        private WcApi.Win32.Widgets.CalendarColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem exportAllMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button btnSaveDir;
    }
}

