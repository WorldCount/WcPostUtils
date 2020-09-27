using Tracking.Libs.Widget;
using Tracking.Libs.Widget.Renderer;

namespace Tracking.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menu = new Tracking.Libs.Widget.Renderer.BrowserMenu();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusPay = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelBarcode = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblHanding = new System.Windows.Forms.Label();
            this.lblReception = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbBarcode = new Tracking.Libs.Widget.TranslateTextBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.panelBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuConfig});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(786, 37);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrint,
            this.menuExit});
            this.menuFile.ForeColor = System.Drawing.Color.White;
            this.menuFile.Image = global::Tracking.Properties.Resources.File;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(83, 33);
            this.menuFile.Text = "Файл";
            // 
            // menuPrint
            // 
            this.menuPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.menuPrint.ForeColor = System.Drawing.Color.White;
            this.menuPrint.Image = global::Tracking.Properties.Resources.Printer;
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuPrint.Size = new System.Drawing.Size(194, 30);
            this.menuPrint.Text = "Печать";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // menuExit
            // 
            this.menuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.menuExit.ForeColor = System.Drawing.Color.White;
            this.menuExit.Image = global::Tracking.Properties.Resources.ButtonClose;
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuExit.Size = new System.Drawing.Size(194, 30);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnect});
            this.menuConfig.ForeColor = System.Drawing.Color.White;
            this.menuConfig.Image = global::Tracking.Properties.Resources.ButtonSettings;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(123, 33);
            this.menuConfig.Text = "Настройки";
            // 
            // menuConnect
            // 
            this.menuConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.menuConnect.ForeColor = System.Drawing.Color.White;
            this.menuConnect.Image = global::Tracking.Properties.Resources.LanSocket;
            this.menuConnect.Name = "menuConnect";
            this.menuConnect.Size = new System.Drawing.Size(189, 30);
            this.menuConnect.Text = "Подключение";
            this.menuConnect.Click += new System.EventHandler(this.menuConnect_Click);
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.status.Dock = System.Windows.Forms.DockStyle.None;
            this.status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPay,
            this.statusText,
            this.statusAuthor});
            this.status.Location = new System.Drawing.Point(0, 319);
            this.status.Name = "status";
            this.status.ShowItemToolTips = true;
            this.status.Size = new System.Drawing.Size(786, 33);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // statusPay
            // 
            this.statusPay.AutoSize = false;
            this.statusPay.ForeColor = System.Drawing.Color.White;
            this.statusPay.Name = "statusPay";
            this.statusPay.Size = new System.Drawing.Size(100, 28);
            this.statusPay.Text = "Плата: ";
            this.statusPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusText
            // 
            this.statusText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusText.ForeColor = System.Drawing.Color.White;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(543, 28);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(128, 28);
            this.statusAuthor.Text = "WorldCount, 2019 ©";
            this.statusAuthor.ToolTipText = "Что он сказал?";
            // 
            // panelBarcode
            // 
            this.panelBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelBarcode.Controls.Add(this.label5);
            this.panelBarcode.Controls.Add(this.label4);
            this.panelBarcode.Controls.Add(this.label3);
            this.panelBarcode.Controls.Add(this.label2);
            this.panelBarcode.Controls.Add(this.label8);
            this.panelBarcode.Controls.Add(this.lblValue);
            this.panelBarcode.Controls.Add(this.lblMass);
            this.panelBarcode.Controls.Add(this.lblHanding);
            this.panelBarcode.Controls.Add(this.lblReception);
            this.panelBarcode.Controls.Add(this.label1);
            this.panelBarcode.Controls.Add(this.lblSender);
            this.panelBarcode.Controls.Add(this.btnFind);
            this.panelBarcode.Controls.Add(this.tbBarcode);
            this.panelBarcode.Controls.Add(this.labelBarcode);
            this.panelBarcode.Location = new System.Drawing.Point(0, 69);
            this.panelBarcode.Name = "panelBarcode";
            this.panelBarcode.Size = new System.Drawing.Size(786, 87);
            this.panelBarcode.TabIndex = 2;
            this.panelBarcode.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panelBarcode.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(120, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "ОЦ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "ВЕС:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(316, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вручено:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Получатель:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-180, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Нет данных";
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(156, 58);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(58, 21);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "НД";
            // 
            // lblMass
            // 
            this.lblMass.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMass.ForeColor = System.Drawing.Color.White;
            this.lblMass.Location = new System.Drawing.Point(43, 58);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(70, 21);
            this.lblMass.TabIndex = 5;
            this.lblMass.Text = "НД";
            // 
            // lblHanding
            // 
            this.lblHanding.AutoSize = true;
            this.lblHanding.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHanding.ForeColor = System.Drawing.Color.White;
            this.lblHanding.Location = new System.Drawing.Point(434, 58);
            this.lblHanding.Name = "lblHanding";
            this.lblHanding.Size = new System.Drawing.Size(93, 21);
            this.lblHanding.TabIndex = 5;
            this.lblHanding.Text = "Нет данных";
            // 
            // lblReception
            // 
            this.lblReception.AutoSize = true;
            this.lblReception.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReception.ForeColor = System.Drawing.Color.White;
            this.lblReception.Location = new System.Drawing.Point(434, 31);
            this.lblReception.Name = "lblReception";
            this.lblReception.Size = new System.Drawing.Size(93, 21);
            this.lblReception.TabIndex = 5;
            this.lblReception.Text = "Нет данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Отправитель:";
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSender.ForeColor = System.Drawing.Color.White;
            this.lblSender.Location = new System.Drawing.Point(434, 4);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(93, 21);
            this.lblSender.TabIndex = 5;
            this.lblSender.Text = "Нет данных";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnFind.Location = new System.Drawing.Point(220, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 29);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbBarcode
            // 
            this.tbBarcode.BorderColor = System.Drawing.Color.DimGray;
            this.tbBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBarcode.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbBarcode.Location = new System.Drawing.Point(60, 15);
            this.tbBarcode.MaxLength = 14;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(154, 29);
            this.tbBarcode.TabIndex = 3;
            this.tbBarcode.Click += new System.EventHandler(this.tbBarcode_Click);
            this.tbBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBarcode_KeyDown);
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBarcode.ForeColor = System.Drawing.Color.White;
            this.labelBarcode.Location = new System.Drawing.Point(3, 19);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(54, 21);
            this.labelBarcode.TabIndex = 3;
            this.labelBarcode.Text = "ШПИ:";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.lblMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(220, 2);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(558, 33);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.OperName,
            this.Attr,
            this.IndexFrom,
            this.DescFrom,
            this.Mass,
            this.Value,
            this.IndexTo,
            this.DescTo});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(94)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 156);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(786, 163);
            this.dataGridView.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.DefaultCellStyle = dataGridViewCellStyle3;
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // OperName
            // 
            this.OperName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OperName.DefaultCellStyle = dataGridViewCellStyle4;
            this.OperName.HeaderText = "Операция";
            this.OperName.MinimumWidth = 10;
            this.OperName.Name = "OperName";
            this.OperName.ReadOnly = true;
            this.OperName.Width = 110;
            // 
            // Attr
            // 
            this.Attr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Attr.DefaultCellStyle = dataGridViewCellStyle5;
            this.Attr.FillWeight = 173.6024F;
            this.Attr.HeaderText = "Атрибут";
            this.Attr.MinimumWidth = 10;
            this.Attr.Name = "Attr";
            this.Attr.ReadOnly = true;
            this.Attr.Width = 130;
            // 
            // IndexFrom
            // 
            this.IndexFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IndexFrom.DefaultCellStyle = dataGridViewCellStyle6;
            this.IndexFrom.FillWeight = 67.59849F;
            this.IndexFrom.HeaderText = "Индекс Места";
            this.IndexFrom.MinimumWidth = 10;
            this.IndexFrom.Name = "IndexFrom";
            this.IndexFrom.ReadOnly = true;
            this.IndexFrom.Width = 60;
            // 
            // DescFrom
            // 
            this.DescFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DescFrom.DefaultCellStyle = dataGridViewCellStyle7;
            this.DescFrom.FillWeight = 106.1371F;
            this.DescFrom.HeaderText = "Название Места";
            this.DescFrom.MinimumWidth = 10;
            this.DescFrom.Name = "DescFrom";
            this.DescFrom.ReadOnly = true;
            this.DescFrom.Width = 140;
            // 
            // Mass
            // 
            this.Mass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Mass.DefaultCellStyle = dataGridViewCellStyle8;
            this.Mass.FillWeight = 69.64651F;
            this.Mass.HeaderText = "Вес";
            this.Mass.MinimumWidth = 10;
            this.Mass.Name = "Mass";
            this.Mass.ReadOnly = true;
            this.Mass.Width = 40;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Value.DefaultCellStyle = dataGridViewCellStyle9;
            this.Value.FillWeight = 76.55476F;
            this.Value.HeaderText = "ОЦ";
            this.Value.MinimumWidth = 10;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 40;
            // 
            // IndexTo
            // 
            this.IndexTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IndexTo.DefaultCellStyle = dataGridViewCellStyle10;
            this.IndexTo.FillWeight = 56.95701F;
            this.IndexTo.HeaderText = "Индекс Куда";
            this.IndexTo.MinimumWidth = 10;
            this.IndexTo.Name = "IndexTo";
            this.IndexTo.ReadOnly = true;
            this.IndexTo.Width = 60;
            // 
            // DescTo
            // 
            this.DescTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DescTo.DefaultCellStyle = dataGridViewCellStyle11;
            this.DescTo.FillWeight = 108.74F;
            this.DescTo.HeaderText = "Название Куда";
            this.DescTo.MinimumWidth = 10;
            this.DescTo.Name = "DescTo";
            this.DescTo.ReadOnly = true;
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelInfo.Controls.Add(this.lblBarcode);
            this.panelInfo.Controls.Add(this.lblMark);
            this.panelInfo.Location = new System.Drawing.Point(0, 37);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(786, 32);
            this.panelInfo.TabIndex = 5;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panelInfo.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(5, 5);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(71, 21);
            this.lblBarcode.TabIndex = 6;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblMark
            // 
            this.lblMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMark.ForeColor = System.Drawing.Color.White;
            this.lblMark.Location = new System.Drawing.Point(224, 1);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(554, 28);
            this.lblMark.TabIndex = 0;
            this.lblMark.Text = "Mark";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(786, 352);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.panelBarcode);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.GeneralForm_InputLanguageChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panelBarcode.ResumeLayout(false);
            this.panelBarcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrowserMenu menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuConnect;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel panelBarcode;
        private TranslateTextBox tbBarcode;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripStatusLabel statusPay;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblReception;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHanding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTo;
    }
}

