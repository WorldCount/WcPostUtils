using Mail.Libs.Views;

namespace Mail.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxFIlter = new System.Windows.Forms.TextBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.tableLayoutButton = new Mail.Widgets.NoAutoScrollPanel();
            this.labelInfoLicense = new System.Windows.Forms.Label();
            this.labelLicense = new System.Windows.Forms.Label();
            this.mailViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attachViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.labelFiles = new System.Windows.Forms.Label();
            this.dataGridViewAttach = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewMail = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelMessages = new System.Windows.Forms.Label();
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachViewBindingSource)).BeginInit();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMail)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.status.Location = new System.Drawing.Point(208, 394);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(845, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(702, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.DimGray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(128, 17);
            this.statusAuthor.Text = "WorldCount, 2020 ©";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1053, 32);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::Mail.Properties.Resources.File;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(83, 28);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Mail.Properties.Resources.Button_Close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.toolStripSeparator1,
            this.connectToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::Mail.Properties.Resources.Button_Settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Image = global::Mail.Properties.Resources.Shuffle;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.filterToolStripMenuItem.Text = "Фильтры";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = global::Mail.Properties.Resources.Lan_Socket;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.connectToolStripMenuItem.Text = "Подключение";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // textBoxFIlter
            // 
            this.textBoxFIlter.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.textBoxFIlter.Location = new System.Drawing.Point(8, 58);
            this.textBoxFIlter.Name = "textBoxFIlter";
            this.textBoxFIlter.Size = new System.Drawing.Size(194, 35);
            this.textBoxFIlter.TabIndex = 3;
            this.textBoxFIlter.TextChanged += new System.EventHandler(this.textBoxFIlter_TextChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.labelFilter.Location = new System.Drawing.Point(3, 12);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(202, 40);
            this.labelFilter.TabIndex = 3;
            this.labelFilter.Text = "Фильтр:";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutButton
            // 
            this.tableLayoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutButton.AutoScroll = true;
            this.tableLayoutButton.ColumnCount = 1;
            this.tableLayoutButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutButton.Location = new System.Drawing.Point(8, 99);
            this.tableLayoutButton.Name = "tableLayoutButton";
            this.tableLayoutButton.RowCount = 1;
            this.tableLayoutButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutButton.Size = new System.Drawing.Size(194, 230);
            this.tableLayoutButton.TabIndex = 4;
            // 
            // labelInfoLicense
            // 
            this.labelInfoLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoLicense.Location = new System.Drawing.Point(838, 0);
            this.labelInfoLicense.Name = "labelInfoLicense";
            this.labelInfoLicense.Size = new System.Drawing.Size(113, 32);
            this.labelInfoLicense.TabIndex = 3;
            this.labelInfoLicense.Text = "Лицензия до:";
            this.labelInfoLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLicense
            // 
            this.labelLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLicense.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLicense.Location = new System.Drawing.Point(957, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(96, 32);
            this.labelLicense.TabIndex = 4;
            this.labelLicense.Text = "01.01.0001";
            this.labelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mailViewBindingSource
            // 
            this.mailViewBindingSource.DataSource = typeof(Mail.Libs.Views.MailView);
            // 
            // attachViewBindingSource
            // 
            this.attachViewBindingSource.DataSource = typeof(Mail.Libs.Views.AttachView);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.FillWeight = 105.6995F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.FillWeight = 105.6995F;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.FillWeight = 105.6995F;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Почта";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AttachCount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.FillWeight = 82.90155F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Файлы";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 76;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile.Location = new System.Drawing.Point(135, 262);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(323, 45);
            this.buttonSaveFile.TabIndex = 7;
            this.buttonSaveFile.Text = "Сохранить все";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 32);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1053, 52);
            this.panelFilter.TabIndex = 8;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.tableLayoutButton);
            this.panelButton.Controls.Add(this.textBoxFIlter);
            this.panelButton.Controls.Add(this.labelFilter);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 84);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(208, 332);
            this.panelButton.TabIndex = 11;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(208, 84);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.labelMessages);
            this.splitContainer.Panel1.Controls.Add(this.dataGridViewMail);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridViewAttach);
            this.splitContainer.Panel2.Controls.Add(this.buttonSaveFile);
            this.splitContainer.Panel2.Controls.Add(this.labelFiles);
            this.splitContainer.Size = new System.Drawing.Size(845, 310);
            this.splitContainer.SplitterDistance = 380;
            this.splitContainer.TabIndex = 7;
            // 
            // labelFiles
            // 
            this.labelFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.labelFiles.Location = new System.Drawing.Point(3, 11);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(323, 40);
            this.labelFiles.TabIndex = 6;
            this.labelFiles.Text = "Файлы:";
            this.labelFiles.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dataGridViewAttach
            // 
            this.dataGridViewAttach.AllowUserToAddRows = false;
            this.dataGridViewAttach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewAttach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAttach.AutoGenerateColumns = false;
            this.dataGridViewAttach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttach.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAttach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1});
            this.dataGridViewAttach.DataSource = this.attachViewBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAttach.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewAttach.Location = new System.Drawing.Point(3, 54);
            this.dataGridViewAttach.Name = "dataGridViewAttach";
            this.dataGridViewAttach.ReadOnly = true;
            this.dataGridViewAttach.RowHeadersVisible = false;
            this.dataGridViewAttach.RowHeadersWidth = 45;
            this.dataGridViewAttach.RowTemplate.Height = 46;
            this.dataGridViewAttach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAttach.Size = new System.Drawing.Size(455, 207);
            this.dataGridViewAttach.TabIndex = 0;
            this.dataGridViewAttach.TabStop = false;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.FillWeight = 93.26425F;
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 139.218F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Файл";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            this.pictureDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.pictureDataGridViewImageColumn.FillWeight = 67.51775F;
            this.pictureDataGridViewImageColumn.HeaderText = "";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pictureDataGridViewImageColumn.Width = 78;
            // 
            // dataGridViewMail
            // 
            this.dataGridViewMail.AllowUserToAddRows = false;
            this.dataGridViewMail.AllowUserToDeleteRows = false;
            this.dataGridViewMail.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMail.AutoGenerateColumns = false;
            this.dataGridViewMail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Picture,
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.attachCountDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridViewMail.DataSource = this.mailViewBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMail.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMail.Location = new System.Drawing.Point(10, 54);
            this.dataGridViewMail.Name = "dataGridViewMail";
            this.dataGridViewMail.ReadOnly = true;
            this.dataGridViewMail.RowHeadersVisible = false;
            this.dataGridViewMail.RowHeadersWidth = 45;
            this.dataGridViewMail.RowTemplate.Height = 46;
            this.dataGridViewMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMail.Size = new System.Drawing.Size(367, 253);
            this.dataGridViewMail.TabIndex = 0;
            this.dataGridViewMail.TabStop = false;
            this.dataGridViewMail.DoubleClick += new System.EventHandler(this.dataGridViewMail_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // attachCountDataGridViewTextBoxColumn
            // 
            this.attachCountDataGridViewTextBoxColumn.DataPropertyName = "AttachCount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attachCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.attachCountDataGridViewTextBoxColumn.FillWeight = 82.90155F;
            this.attachCountDataGridViewTextBoxColumn.HeaderText = "Файлы";
            this.attachCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attachCountDataGridViewTextBoxColumn.Name = "attachCountDataGridViewTextBoxColumn";
            this.attachCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.emailDataGridViewTextBoxColumn.FillWeight = 105.6995F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.nameDataGridViewTextBoxColumn.FillWeight = 105.6995F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Format = "G";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dateDataGridViewTextBoxColumn.FillWeight = 105.6995F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 120;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "";
            this.Picture.MinimumWidth = 6;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // labelMessages
            // 
            this.labelMessages.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.labelMessages.Location = new System.Drawing.Point(10, 11);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(260, 40);
            this.labelMessages.TabIndex = 6;
            this.labelMessages.Text = "Сообщения:";
            this.labelMessages.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 416);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelInfoLicense);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachViewBindingSource)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxFIlter;
        private Mail.Widgets.NoAutoScrollPanel tableLayoutButton;
        private System.Windows.Forms.Label labelInfoLicense;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.BindingSource mailViewBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.BindingSource attachViewBindingSource;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.DataGridView dataGridViewMail;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewAttach;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelFiles;
    }
}

