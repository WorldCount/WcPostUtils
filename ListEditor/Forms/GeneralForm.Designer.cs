namespace ListEditor.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearDirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkDateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkNumListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSndrCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkMailTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkMailCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPostMarkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPayTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.indexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.interFilterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.checkBoxIndex = new System.Windows.Forms.CheckBox();
            this.bntClose = new System.Windows.Forms.Button();
            this.btnClearDir = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckPayType = new System.Windows.Forms.Button();
            this.btnCheckPostMark = new System.Windows.Forms.Button();
            this.btnCheckMailCat = new System.Windows.Forms.Button();
            this.btnCheckMailType = new System.Windows.Forms.Button();
            this.btnCheckSndrCat = new System.Windows.Forms.Button();
            this.btnCheckNum = new System.Windows.Forms.Button();
            this.btnCheckDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.labelSave = new System.Windows.Forms.Label();
            this.tbSaveDir = new System.Windows.Forms.TextBox();
            this.dataGridData = new System.Windows.Forms.DataGridView();
            this.SendCtg = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MailType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MailCtg = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WeightValidImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblFilesCount = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.lblStringCount = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.Org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SendDate = new ListEditor.Widget.CalendarColumn();
            this.ListNum = new ListEditor.Widget.NumericColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PostMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new ListEditor.Widget.CalendarColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partFileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.fixMenuItem,
            this.settingMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(904, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Меню";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.clearMenuItem,
            this.toolStripSeparator1,
            this.clearDirMenuItem,
            this.toolStripSeparator2,
            this.exitMenuItem});
            this.fileMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.fileMenuItem.Image = global::ListEditor.Properties.Resources.File_Attachment;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(83, 28);
            this.fileMenuItem.Text = "Файл";
            // 
            // openMenuItem
            // 
            this.openMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.openMenuItem.Image = global::ListEditor.Properties.Resources.Folder_File;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(301, 30);
            this.openMenuItem.Text = "Открыть";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.saveMenuItem.Image = global::ListEditor.Properties.Resources.Save;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(301, 30);
            this.saveMenuItem.Text = "Сохранить";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.clearMenuItem.Image = global::ListEditor.Properties.Resources.Delete;
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearMenuItem.Size = new System.Drawing.Size(301, 30);
            this.clearMenuItem.Text = "Очистить";
            this.clearMenuItem.Click += new System.EventHandler(this.clearMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(298, 6);
            // 
            // clearDirMenuItem
            // 
            this.clearDirMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.clearDirMenuItem.Image = global::ListEditor.Properties.Resources.Folder_Minus;
            this.clearDirMenuItem.Name = "clearDirMenuItem";
            this.clearDirMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clearDirMenuItem.Size = new System.Drawing.Size(301, 30);
            this.clearDirMenuItem.Text = "Очистить папку";
            this.clearDirMenuItem.Click += new System.EventHandler(this.clearDirMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(298, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exitMenuItem.Image = global::ListEditor.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitMenuItem.Size = new System.Drawing.Size(301, 30);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // fixMenuItem
            // 
            this.fixMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkDateMenuItem,
            this.checkNumListMenuItem,
            this.checkSndrCategoryMenuItem,
            this.checkMailTypeMenuItem,
            this.checkMailCategoryMenuItem,
            this.checkPostMarkMenuItem,
            this.checkPayTypeMenuItem});
            this.fixMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.fixMenuItem.Image = global::ListEditor.Properties.Resources.Patch;
            this.fixMenuItem.Name = "fixMenuItem";
            this.fixMenuItem.Size = new System.Drawing.Size(123, 28);
            this.fixMenuItem.Text = "Исправить";
            // 
            // checkDateMenuItem
            // 
            this.checkDateMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkDateMenuItem.Image = global::ListEditor.Properties.Resources.Calendar_Week;
            this.checkDateMenuItem.Name = "checkDateMenuItem";
            this.checkDateMenuItem.Size = new System.Drawing.Size(262, 30);
            this.checkDateMenuItem.Text = "Дату списков";
            this.checkDateMenuItem.Click += new System.EventHandler(this.checkDateMenuItem_Click);
            // 
            // checkNumListMenuItem
            // 
            this.checkNumListMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkNumListMenuItem.Image = global::ListEditor.Properties.Resources.Calculator_2;
            this.checkNumListMenuItem.Name = "checkNumListMenuItem";
            this.checkNumListMenuItem.Size = new System.Drawing.Size(262, 30);
            this.checkNumListMenuItem.Text = "Номера списков";
            this.checkNumListMenuItem.Click += new System.EventHandler(this.checkNumListMenuItem_Click);
            // 
            // checkSndrCategoryMenuItem
            // 
            this.checkSndrCategoryMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkSndrCategoryMenuItem.Image = global::ListEditor.Properties.Resources.Man_Suit;
            this.checkSndrCategoryMenuItem.Name = "checkSndrCategoryMenuItem";
            this.checkSndrCategoryMenuItem.Size = new System.Drawing.Size(262, 30);
            this.checkSndrCategoryMenuItem.Text = "Категорию отправителя";
            this.checkSndrCategoryMenuItem.Click += new System.EventHandler(this.checkSndrCategoryMenuItem_Click);
            // 
            // checkMailTypeMenuItem
            // 
            this.checkMailTypeMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkMailTypeMenuItem.Image = global::ListEditor.Properties.Resources.Envelope_2;
            this.checkMailTypeMenuItem.Name = "checkMailTypeMenuItem";
            this.checkMailTypeMenuItem.Size = new System.Drawing.Size(262, 30);
            this.checkMailTypeMenuItem.Text = "Тип отправления";
            this.checkMailTypeMenuItem.Click += new System.EventHandler(this.checkMailTypeMenuItem_Click);
            // 
            // checkMailCategoryMenuItem
            // 
            this.checkMailCategoryMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkMailCategoryMenuItem.Image = global::ListEditor.Properties.Resources.Stamp;
            this.checkMailCategoryMenuItem.Name = "checkMailCategoryMenuItem";
            this.checkMailCategoryMenuItem.Size = new System.Drawing.Size(262, 30);
            this.checkMailCategoryMenuItem.Text = "Категорию отправления";
            this.checkMailCategoryMenuItem.Click += new System.EventHandler(this.checkMailCategoryMenuItem_Click);
            // 
            // checkPostMarkMenuItem
            // 
            this.checkPostMarkMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkPostMarkMenuItem.Image = global::ListEditor.Properties.Resources.Tag;
            this.checkPostMarkMenuItem.Name = "checkPostMarkMenuItem";
            this.checkPostMarkMenuItem.Size = new System.Drawing.Size(262, 30);
            this.checkPostMarkMenuItem.Text = "Почтовые отметки";
            this.checkPostMarkMenuItem.Click += new System.EventHandler(this.checkPostMarkMenuItem_Click);
            // 
            // checkPayTypeMenuItem
            // 
            this.checkPayTypeMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.checkPayTypeMenuItem.Image = global::ListEditor.Properties.Resources.Coin_Dollar;
            this.checkPayTypeMenuItem.Name = "checkPayTypeMenuItem";
            this.checkPayTypeMenuItem.Size = new System.Drawing.Size(262, 30);
            this.checkPayTypeMenuItem.Text = "Тип оплаты";
            this.checkPayTypeMenuItem.Click += new System.EventHandler(this.checkPayTypeMenuItem_Click);
            // 
            // settingMenuItem
            // 
            this.settingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalMenuItem,
            this.toolStripSeparator4,
            this.indexMenuItem,
            this.toolStripSeparator3,
            this.interFilterMenuItem});
            this.settingMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.settingMenuItem.Image = global::ListEditor.Properties.Resources.Button_Settings;
            this.settingMenuItem.Name = "settingMenuItem";
            this.settingMenuItem.Size = new System.Drawing.Size(123, 28);
            this.settingMenuItem.Text = "Настройки";
            // 
            // generalMenuItem
            // 
            this.generalMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.generalMenuItem.Image = global::ListEditor.Properties.Resources.Properties;
            this.generalMenuItem.Name = "generalMenuItem";
            this.generalMenuItem.Size = new System.Drawing.Size(254, 30);
            this.generalMenuItem.Text = "Главные";
            this.generalMenuItem.Click += new System.EventHandler(this.generalMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(251, 6);
            // 
            // indexMenuItem
            // 
            this.indexMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.indexMenuItem.Image = global::ListEditor.Properties.Resources.Earth;
            this.indexMenuItem.Name = "indexMenuItem";
            this.indexMenuItem.Size = new System.Drawing.Size(254, 30);
            this.indexMenuItem.Text = "Справочник индексов";
            this.indexMenuItem.Click += new System.EventHandler(this.indexMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(251, 6);
            // 
            // interFilterMenuItem
            // 
            this.interFilterMenuItem.Image = global::ListEditor.Properties.Resources.Button_Dashboard;
            this.interFilterMenuItem.Name = "interFilterMenuItem";
            this.interFilterMenuItem.Size = new System.Drawing.Size(254, 30);
            this.interFilterMenuItem.Text = "Фильтр международок";
            this.interFilterMenuItem.Click += new System.EventHandler(this.interFilterMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusStrip.Location = new System.Drawing.Point(0, 397);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(904, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(761, 17);
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
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelMenu.Controls.Add(this.checkBoxIndex);
            this.panelMenu.Controls.Add(this.bntClose);
            this.panelMenu.Controls.Add(this.btnClearDir);
            this.panelMenu.Controls.Add(this.btnRemove);
            this.panelMenu.Controls.Add(this.btnCheckPayType);
            this.panelMenu.Controls.Add(this.btnCheckPostMark);
            this.panelMenu.Controls.Add(this.btnCheckMailCat);
            this.panelMenu.Controls.Add(this.btnCheckMailType);
            this.panelMenu.Controls.Add(this.btnCheckSndrCat);
            this.panelMenu.Controls.Add(this.btnCheckNum);
            this.panelMenu.Controls.Add(this.btnCheckDate);
            this.panelMenu.Controls.Add(this.btnClear);
            this.panelMenu.Controls.Add(this.btnSave);
            this.panelMenu.Controls.Add(this.btnOpen);
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(904, 51);
            this.panelMenu.TabIndex = 2;
            // 
            // checkBoxIndex
            // 
            this.checkBoxIndex.AutoSize = true;
            this.checkBoxIndex.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIndex.ForeColor = System.Drawing.Color.White;
            this.checkBoxIndex.Location = new System.Drawing.Point(662, 13);
            this.checkBoxIndex.Name = "checkBoxIndex";
            this.checkBoxIndex.Size = new System.Drawing.Size(178, 25);
            this.checkBoxIndex.TabIndex = 4;
            this.checkBoxIndex.Text = "Исправлять индексы";
            this.checkBoxIndex.UseVisualStyleBackColor = false;
            this.checkBoxIndex.CheckedChanged += new System.EventHandler(this.checkBoxIndex_CheckedChanged);
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.BackColor = System.Drawing.Color.DimGray;
            this.bntClose.BackgroundImage = global::ListEditor.Properties.Resources.Button_Close;
            this.bntClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClose.ForeColor = System.Drawing.Color.SlateGray;
            this.bntClose.Location = new System.Drawing.Point(850, 4);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(42, 42);
            this.bntClose.TabIndex = 3;
            this.bntClose.UseVisualStyleBackColor = false;
            this.bntClose.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // btnClearDir
            // 
            this.btnClearDir.BackColor = System.Drawing.Color.DimGray;
            this.btnClearDir.BackgroundImage = global::ListEditor.Properties.Resources.Folder_Minus;
            this.btnClearDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDir.ForeColor = System.Drawing.Color.SlateGray;
            this.btnClearDir.Location = new System.Drawing.Point(603, 4);
            this.btnClearDir.Name = "btnClearDir";
            this.btnClearDir.Size = new System.Drawing.Size(42, 42);
            this.btnClearDir.TabIndex = 3;
            this.btnClearDir.UseVisualStyleBackColor = false;
            this.btnClearDir.Click += new System.EventHandler(this.clearDirMenuItem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DimGray;
            this.btnRemove.BackgroundImage = global::ListEditor.Properties.Resources.Minus;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.SlateGray;
            this.btnRemove.Location = new System.Drawing.Point(555, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(42, 42);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheckPayType
            // 
            this.btnCheckPayType.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckPayType.BackgroundImage = global::ListEditor.Properties.Resources.Coin_Dollar;
            this.btnCheckPayType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckPayType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPayType.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCheckPayType.Location = new System.Drawing.Point(475, 4);
            this.btnCheckPayType.Name = "btnCheckPayType";
            this.btnCheckPayType.Size = new System.Drawing.Size(42, 42);
            this.btnCheckPayType.TabIndex = 3;
            this.btnCheckPayType.UseVisualStyleBackColor = false;
            this.btnCheckPayType.Click += new System.EventHandler(this.checkPayTypeMenuItem_Click);
            // 
            // btnCheckPostMark
            // 
            this.btnCheckPostMark.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckPostMark.BackgroundImage = global::ListEditor.Properties.Resources.Tag;
            this.btnCheckPostMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckPostMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPostMark.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCheckPostMark.Location = new System.Drawing.Point(427, 4);
            this.btnCheckPostMark.Name = "btnCheckPostMark";
            this.btnCheckPostMark.Size = new System.Drawing.Size(42, 42);
            this.btnCheckPostMark.TabIndex = 3;
            this.btnCheckPostMark.UseVisualStyleBackColor = false;
            this.btnCheckPostMark.Click += new System.EventHandler(this.checkPostMarkMenuItem_Click);
            // 
            // btnCheckMailCat
            // 
            this.btnCheckMailCat.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckMailCat.BackgroundImage = global::ListEditor.Properties.Resources.Stamp;
            this.btnCheckMailCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckMailCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckMailCat.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCheckMailCat.Location = new System.Drawing.Point(379, 4);
            this.btnCheckMailCat.Name = "btnCheckMailCat";
            this.btnCheckMailCat.Size = new System.Drawing.Size(42, 42);
            this.btnCheckMailCat.TabIndex = 3;
            this.btnCheckMailCat.UseVisualStyleBackColor = false;
            this.btnCheckMailCat.Click += new System.EventHandler(this.checkMailCategoryMenuItem_Click);
            // 
            // btnCheckMailType
            // 
            this.btnCheckMailType.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckMailType.BackgroundImage = global::ListEditor.Properties.Resources.Envelope_2;
            this.btnCheckMailType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckMailType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckMailType.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCheckMailType.Location = new System.Drawing.Point(331, 4);
            this.btnCheckMailType.Name = "btnCheckMailType";
            this.btnCheckMailType.Size = new System.Drawing.Size(42, 42);
            this.btnCheckMailType.TabIndex = 3;
            this.btnCheckMailType.UseVisualStyleBackColor = false;
            this.btnCheckMailType.Click += new System.EventHandler(this.checkMailTypeMenuItem_Click);
            // 
            // btnCheckSndrCat
            // 
            this.btnCheckSndrCat.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckSndrCat.BackgroundImage = global::ListEditor.Properties.Resources.Man_Suit;
            this.btnCheckSndrCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckSndrCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckSndrCat.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCheckSndrCat.Location = new System.Drawing.Point(283, 4);
            this.btnCheckSndrCat.Name = "btnCheckSndrCat";
            this.btnCheckSndrCat.Size = new System.Drawing.Size(42, 42);
            this.btnCheckSndrCat.TabIndex = 3;
            this.btnCheckSndrCat.UseVisualStyleBackColor = false;
            this.btnCheckSndrCat.Click += new System.EventHandler(this.checkSndrCategoryMenuItem_Click);
            // 
            // btnCheckNum
            // 
            this.btnCheckNum.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckNum.BackgroundImage = global::ListEditor.Properties.Resources.Calculator_2;
            this.btnCheckNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckNum.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCheckNum.Location = new System.Drawing.Point(235, 4);
            this.btnCheckNum.Name = "btnCheckNum";
            this.btnCheckNum.Size = new System.Drawing.Size(42, 42);
            this.btnCheckNum.TabIndex = 3;
            this.btnCheckNum.UseVisualStyleBackColor = false;
            this.btnCheckNum.Click += new System.EventHandler(this.checkNumListMenuItem_Click);
            // 
            // btnCheckDate
            // 
            this.btnCheckDate.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckDate.BackgroundImage = global::ListEditor.Properties.Resources.Calendar_Week;
            this.btnCheckDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDate.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCheckDate.Location = new System.Drawing.Point(187, 4);
            this.btnCheckDate.Name = "btnCheckDate";
            this.btnCheckDate.Size = new System.Drawing.Size(42, 42);
            this.btnCheckDate.TabIndex = 3;
            this.btnCheckDate.UseVisualStyleBackColor = false;
            this.btnCheckDate.Click += new System.EventHandler(this.checkDateMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.BackgroundImage = global::ListEditor.Properties.Resources.Delete;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.SlateGray;
            this.btnClear.Location = new System.Drawing.Point(108, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(42, 42);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.clearMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.BackgroundImage = global::ListEditor.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSave.Location = new System.Drawing.Point(60, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DimGray;
            this.btnOpen.BackgroundImage = global::ListEditor.Properties.Resources.Folder_File;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.SlateGray;
            this.btnOpen.Location = new System.Drawing.Point(12, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(42, 42);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelSave.Location = new System.Drawing.Point(8, 95);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(147, 21);
            this.labelSave.TabIndex = 3;
            this.labelSave.Text = "Сохранить в папку:";
            // 
            // tbSaveDir
            // 
            this.tbSaveDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaveDir.Enabled = false;
            this.tbSaveDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbSaveDir.Location = new System.Drawing.Point(164, 92);
            this.tbSaveDir.Name = "tbSaveDir";
            this.tbSaveDir.ReadOnly = true;
            this.tbSaveDir.Size = new System.Drawing.Size(660, 27);
            this.tbSaveDir.TabIndex = 4;
            // 
            // dataGridData
            // 
            this.dataGridData.AllowDrop = true;
            this.dataGridData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridData.AutoGenerateColumns = false;
            this.dataGridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridData.ColumnHeadersHeight = 40;
            this.dataGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Org,
            this.SendCtg,
            this.SendDate,
            this.ListNum,
            this.countDataGridViewTextBoxColumn,
            this.MailType,
            this.MailCtg,
            this.PayType,
            this.PostMark,
            this.Nds,
            this.MinWeight,
            this.MaxWeight,
            this.WeightValidImage,
            this.errorCountDataGridViewTextBoxColumn});
            this.dataGridData.DataSource = this.partFileBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridData.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dataGridData.Location = new System.Drawing.Point(12, 125);
            this.dataGridData.Name = "dataGridData";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridData.Size = new System.Drawing.Size(880, 239);
            this.dataGridData.TabIndex = 6;
            this.dataGridData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridData_CellDoubleClick);
            this.dataGridData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridData_DataError);
            this.dataGridData.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridData_DragDrop);
            this.dataGridData.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridData_DragEnter);
            // 
            // SendCtg
            // 
            this.SendCtg.DataPropertyName = "SendCtg";
            this.SendCtg.DataSource = this.senderCategoryBindingSource;
            this.SendCtg.DisplayMember = "Name";
            this.SendCtg.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.SendCtg.FillWeight = 82.91033F;
            this.SendCtg.HeaderText = "Категория";
            this.SendCtg.Name = "SendCtg";
            this.SendCtg.ValueMember = "Id";
            // 
            // MailType
            // 
            this.MailType.DataPropertyName = "MailType";
            this.MailType.DataSource = this.mailTypeBindingSource;
            this.MailType.DisplayMember = "Name";
            this.MailType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MailType.FillWeight = 82.91033F;
            this.MailType.HeaderText = "Вид";
            this.MailType.Name = "MailType";
            this.MailType.ValueMember = "Id";
            // 
            // MailCtg
            // 
            this.MailCtg.DataPropertyName = "MailCtg";
            this.MailCtg.DataSource = this.mailCategoryBindingSource;
            this.MailCtg.DisplayMember = "Name";
            this.MailCtg.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MailCtg.FillWeight = 82.91033F;
            this.MailCtg.HeaderText = "Тип";
            this.MailCtg.Name = "MailCtg";
            this.MailCtg.ValueMember = "Id";
            // 
            // PayType
            // 
            this.PayType.DataPropertyName = "PayType";
            this.PayType.DataSource = this.payTypeBindingSource;
            this.PayType.DisplayMember = "Name";
            this.PayType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PayType.FillWeight = 82.91033F;
            this.PayType.HeaderText = "Оплата";
            this.PayType.Name = "PayType";
            this.PayType.ValueMember = "Id";
            // 
            // WeightValidImage
            // 
            this.WeightValidImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WeightValidImage.DataPropertyName = "ValidImage";
            this.WeightValidImage.Description = "Соответствие веса отправлению";
            this.WeightValidImage.HeaderText = "Вал";
            this.WeightValidImage.Name = "WeightValidImage";
            this.WeightValidImage.ReadOnly = true;
            this.WeightValidImage.Width = 40;
            // 
            // lblFiles
            // 
            this.lblFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiles.AutoSize = true;
            this.lblFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.lblFiles.Location = new System.Drawing.Point(12, 367);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(109, 21);
            this.lblFiles.TabIndex = 7;
            this.lblFiles.Text = "Всего файлов:";
            // 
            // lblFilesCount
            // 
            this.lblFilesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilesCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFilesCount.Location = new System.Drawing.Point(127, 367);
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(62, 21);
            this.lblFilesCount.TabIndex = 8;
            this.lblFilesCount.Text = "0";
            // 
            // lblString
            // 
            this.lblString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblString.AutoSize = true;
            this.lblString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.lblString.Location = new System.Drawing.Point(195, 367);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(96, 21);
            this.lblString.TabIndex = 9;
            this.lblString.Text = "Всего строк:";
            // 
            // lblStringCount
            // 
            this.lblStringCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStringCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStringCount.Location = new System.Drawing.Point(297, 367);
            this.lblStringCount.Name = "lblStringCount";
            this.lblStringCount.Size = new System.Drawing.Size(105, 21);
            this.lblStringCount.TabIndex = 10;
            this.lblStringCount.Text = "0";
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.BackColor = System.Drawing.SystemColors.Control;
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.Location = new System.Drawing.Point(830, 92);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(62, 27);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(803, 4);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(89, 25);
            this.checkBoxDebug.TabIndex = 11;
            this.checkBoxDebug.Text = "Отладка";
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            this.checkBoxDebug.CheckedChanged += new System.EventHandler(this.checkBoxDebug_CheckedChanged);
            // 
            // Org
            // 
            this.Org.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Org.DataPropertyName = "Sender";
            this.Org.FillWeight = 253.8071F;
            this.Org.HeaderText = "  Отправитель";
            this.Org.Name = "Org";
            this.Org.ReadOnly = true;
            this.Org.Width = 200;
            // 
            // senderCategoryBindingSource
            // 
            this.senderCategoryBindingSource.DataSource = typeof(ListEditor.Models.Part.Types.SenderCategory);
            // 
            // SendDate
            // 
            this.SendDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SendDate.DataPropertyName = "SendDate";
            this.SendDate.FillWeight = 82.91033F;
            this.SendDate.HeaderText = "  Дата";
            this.SendDate.Name = "SendDate";
            this.SendDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SendDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SendDate.Width = 80;
            // 
            // ListNum
            // 
            this.ListNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ListNum.DataPropertyName = "ListNum";
            this.ListNum.FillWeight = 82.91033F;
            this.ListNum.HeaderText = "Номер";
            this.ListNum.Name = "ListNum";
            this.ListNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ListNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ListNum.Width = 70;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.FillWeight = 82.91033F;
            this.countDataGridViewTextBoxColumn.HeaderText = "Кол";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.ToolTipText = "Количество строк";
            this.countDataGridViewTextBoxColumn.Width = 50;
            // 
            // mailTypeBindingSource
            // 
            this.mailTypeBindingSource.DataSource = typeof(ListEditor.Models.Part.Types.MailType);
            // 
            // mailCategoryBindingSource
            // 
            this.mailCategoryBindingSource.DataSource = typeof(ListEditor.Models.Part.Types.MailCategory);
            // 
            // payTypeBindingSource
            // 
            this.payTypeBindingSource.DataSource = typeof(ListEditor.Models.Part.Types.PayType);
            // 
            // PostMark
            // 
            this.PostMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PostMark.DataPropertyName = "PostMark";
            this.PostMark.FillWeight = 82.91033F;
            this.PostMark.HeaderText = "Отм";
            this.PostMark.Name = "PostMark";
            this.PostMark.ReadOnly = true;
            this.PostMark.Width = 60;
            // 
            // Nds
            // 
            this.Nds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nds.DataPropertyName = "Nds";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Nds.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nds.HeaderText = "   Ндс";
            this.Nds.Name = "Nds";
            this.Nds.ReadOnly = true;
            this.Nds.Width = 80;
            // 
            // MinWeight
            // 
            this.MinWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MinWeight.DataPropertyName = "MinWeight";
            this.MinWeight.HeaderText = "Мин";
            this.MinWeight.Name = "MinWeight";
            this.MinWeight.ReadOnly = true;
            this.MinWeight.Width = 40;
            // 
            // MaxWeight
            // 
            this.MaxWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaxWeight.DataPropertyName = "MaxWeight";
            this.MaxWeight.HeaderText = "Мак";
            this.MaxWeight.Name = "MaxWeight";
            this.MaxWeight.ReadOnly = true;
            this.MaxWeight.Width = 40;
            // 
            // errorCountDataGridViewTextBoxColumn
            // 
            this.errorCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.errorCountDataGridViewTextBoxColumn.DataPropertyName = "ErrorCount";
            this.errorCountDataGridViewTextBoxColumn.FillWeight = 82.91033F;
            this.errorCountDataGridViewTextBoxColumn.HeaderText = "Ош";
            this.errorCountDataGridViewTextBoxColumn.Name = "errorCountDataGridViewTextBoxColumn";
            this.errorCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorCountDataGridViewTextBoxColumn.Width = 40;
            // 
            // partFileBindingSource
            // 
            this.partFileBindingSource.DataSource = typeof(ListEditor.Models.Part.PartFile);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PayTypeTest";
            this.dataGridViewTextBoxColumn1.FillWeight = 253.8071F;
            this.dataGridViewTextBoxColumn1.HeaderText = "PayTypeTest";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 152;
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "SendDate";
            this.calendarColumn1.FillWeight = 82.91033F;
            this.calendarColumn1.HeaderText = "Дата";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.ReadOnly = true;
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.calendarColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ListNum";
            this.dataGridViewTextBoxColumn2.FillWeight = 82.91033F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PostMark";
            this.dataGridViewTextBoxColumn3.FillWeight = 82.91033F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Отметки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 419);
            this.Controls.Add(this.checkBoxDebug);
            this.Controls.Add(this.lblStringCount);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblFilesCount);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.dataGridData);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.tbSaveDir);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(920, 460);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partFileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem fixMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearDirMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.TextBox tbSaveDir;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.ToolStripMenuItem indexMenuItem;
        private System.Windows.Forms.DataGridView dataGridData;
        private System.Windows.Forms.BindingSource partFileBindingSource;
        private System.Windows.Forms.BindingSource mailTypeBindingSource;
        private System.Windows.Forms.BindingSource mailCategoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource payTypeBindingSource;
        private System.Windows.Forms.BindingSource senderCategoryBindingSource;
        private System.Windows.Forms.Button btnRemove;
        private Widget.CalendarColumn calendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripMenuItem generalMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem checkDateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkNumListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkSndrCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkMailTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkMailCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPostMarkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPayTypeMenuItem;
        private System.Windows.Forms.Button btnClearDir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnCheckDate;
        private System.Windows.Forms.Button btnCheckNum;
        private System.Windows.Forms.Button btnCheckSndrCat;
        private System.Windows.Forms.Button btnCheckMailType;
        private System.Windows.Forms.Button btnCheckPostMark;
        private System.Windows.Forms.Button btnCheckMailCat;
        private System.Windows.Forms.Button btnCheckPayType;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblFilesCount;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblStringCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Org;
        private System.Windows.Forms.DataGridViewComboBoxColumn SendCtg;
        private Widget.CalendarColumn SendDate;
        private Widget.NumericColumn ListNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn MailType;
        private System.Windows.Forms.DataGridViewComboBoxColumn MailCtg;
        private System.Windows.Forms.DataGridViewComboBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nds;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxWeight;
        private System.Windows.Forms.DataGridViewImageColumn WeightValidImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem interFilterMenuItem;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.CheckBox checkBoxIndex;
    }
}

