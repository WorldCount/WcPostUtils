using Barcodes.Libs.Models;

namespace Barcodes.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MonthInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numBegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbOrg = new System.Windows.Forms.GroupBox();
            this.tbInn = new System.Windows.Forms.TextBox();
            this.lblOrgInn = new System.Windows.Forms.Label();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.cbOrgs = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIndex = new System.Windows.Forms.ComboBox();
            this.indexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblIndex = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).BeginInit();
            this.gbOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.settingsMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(757, 40);
            this.menu.TabIndex = 0;
            this.menu.Text = "Меню";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.fileMenuItem.Image = global::Barcodes.Properties.Resources.Text;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.fileMenuItem.Size = new System.Drawing.Size(92, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.exitMenuItem.Image = global::Barcodes.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(136, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.interToolStripMenuItem});
            this.settingsMenuItem.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.settingsMenuItem.Image = global::Barcodes.Properties.Resources.Button_Settings;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.settingsMenuItem.Size = new System.Drawing.Size(142, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.connectToolStripMenuItem.Image = global::Barcodes.Properties.Resources.Router;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.connectToolStripMenuItem.Text = "Подключение к БД";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.indexToolStripMenuItem.Image = global::Barcodes.Properties.Resources.Numeric_Stepper;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.indexToolStripMenuItem.Text = "Индексы";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // interToolStripMenuItem
            // 
            this.interToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.interToolStripMenuItem.Image = global::Barcodes.Properties.Resources.Dropdown;
            this.interToolStripMenuItem.Name = "interToolStripMenuItem";
            this.interToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.interToolStripMenuItem.Text = "Мжд коды";
            this.interToolStripMenuItem.Click += new System.EventHandler(this.interToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Consolas", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.status.Location = new System.Drawing.Point(0, 380);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(757, 22);
            this.status.TabIndex = 1;
            this.status.Text = "Статус";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(609, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Consolas", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(133, 17);
            this.statusAuthor.Text = "WorldCount, 2019 ©";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Barcodes.Properties.Resources.cloud_download_2x;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(625, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::Barcodes.Properties.Resources.trash_2x;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(264, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 37);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Очистить";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Firebrick;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = global::Barcodes.Properties.Resources.delete_2x;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(138, 9);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 37);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Удалить";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Barcodes.Properties.Resources.plus_2x;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonthInfo,
            this.numBegDataGridViewTextBoxColumn,
            this.numEndDataGridViewTextBoxColumn,
            this.Count,
            this.StateInfo,
            this.InterInfo});
            this.dataGridView.DataSource = this.segmentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView.Location = new System.Drawing.Point(12, 207);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(733, 170);
            this.dataGridView.TabIndex = 3;
            // 
            // MonthInfo
            // 
            this.MonthInfo.DataPropertyName = "MonthInfo";
            this.MonthInfo.HeaderText = "Месяц";
            this.MonthInfo.MinimumWidth = 6;
            this.MonthInfo.Name = "MonthInfo";
            this.MonthInfo.ReadOnly = true;
            // 
            // numBegDataGridViewTextBoxColumn
            // 
            this.numBegDataGridViewTextBoxColumn.DataPropertyName = "NumBeg";
            this.numBegDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.numBegDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numBegDataGridViewTextBoxColumn.Name = "numBegDataGridViewTextBoxColumn";
            this.numBegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numEndDataGridViewTextBoxColumn
            // 
            this.numEndDataGridViewTextBoxColumn.DataPropertyName = "NumEnd";
            this.numEndDataGridViewTextBoxColumn.HeaderText = "Конец";
            this.numEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numEndDataGridViewTextBoxColumn.Name = "numEndDataGridViewTextBoxColumn";
            this.numEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Количество";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // StateInfo
            // 
            this.StateInfo.DataPropertyName = "StateInfo";
            this.StateInfo.HeaderText = "Статус";
            this.StateInfo.MinimumWidth = 6;
            this.StateInfo.Name = "StateInfo";
            this.StateInfo.ReadOnly = true;
            // 
            // InterInfo
            // 
            this.InterInfo.DataPropertyName = "InterInfo";
            this.InterInfo.HeaderText = "Мжд";
            this.InterInfo.MinimumWidth = 6;
            this.InterInfo.Name = "InterInfo";
            this.InterInfo.ReadOnly = true;
            // 
            // segmentBindingSource
            // 
            this.segmentBindingSource.DataSource = typeof(WcApi.Post.Ranges.Segment);
            // 
            // gbOrg
            // 
            this.gbOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOrg.Controls.Add(this.tbInn);
            this.gbOrg.Controls.Add(this.lblOrgInn);
            this.gbOrg.Controls.Add(this.lblOrgName);
            this.gbOrg.Controls.Add(this.cbOrgs);
            this.gbOrg.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOrg.ForeColor = System.Drawing.Color.DimGray;
            this.gbOrg.Location = new System.Drawing.Point(12, 101);
            this.gbOrg.Name = "gbOrg";
            this.gbOrg.Size = new System.Drawing.Size(733, 100);
            this.gbOrg.TabIndex = 7;
            this.gbOrg.TabStop = false;
            this.gbOrg.Text = "Организация";
            // 
            // tbInn
            // 
            this.tbInn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInn.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbInn.Location = new System.Drawing.Point(515, 52);
            this.tbInn.Name = "tbInn";
            this.tbInn.Size = new System.Drawing.Size(212, 29);
            this.tbInn.TabIndex = 0;
            // 
            // lblOrgInn
            // 
            this.lblOrgInn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrgInn.AutoSize = true;
            this.lblOrgInn.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrgInn.Location = new System.Drawing.Point(511, 30);
            this.lblOrgInn.Name = "lblOrgInn";
            this.lblOrgInn.Size = new System.Drawing.Size(45, 19);
            this.lblOrgInn.TabIndex = 1;
            this.lblOrgInn.Text = "ИНН:";
            // 
            // lblOrgName
            // 
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrgName.Location = new System.Drawing.Point(6, 30);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(90, 19);
            this.lblOrgName.TabIndex = 1;
            this.lblOrgName.Text = "Название:";
            // 
            // cbOrgs
            // 
            this.cbOrgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrgs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOrgs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOrgs.DropDownHeight = 200;
            this.cbOrgs.DropDownWidth = 300;
            this.cbOrgs.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOrgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.cbOrgs.FormattingEnabled = true;
            this.cbOrgs.IntegralHeight = false;
            this.cbOrgs.Location = new System.Drawing.Point(6, 52);
            this.cbOrgs.Name = "cbOrgs";
            this.cbOrgs.Size = new System.Drawing.Size(490, 33);
            this.cbOrgs.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 686;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StateInfo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 228;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InterInfo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Мжд";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 229;
            // 
            // cbIndex
            // 
            this.cbIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIndex.DataSource = this.indexBindingSource;
            this.cbIndex.DisplayMember = "Name";
            this.cbIndex.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbIndex.FormattingEnabled = true;
            this.cbIndex.Location = new System.Drawing.Point(625, 4);
            this.cbIndex.Name = "cbIndex";
            this.cbIndex.Size = new System.Drawing.Size(120, 30);
            this.cbIndex.TabIndex = 8;
            this.cbIndex.ValueMember = "Name";
            // 
            // indexBindingSource
            // 
            this.indexBindingSource.DataSource = typeof(Barcodes.Libs.Models.Index);
            // 
            // lblIndex
            // 
            this.lblIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIndex.ForeColor = System.Drawing.Color.DimGray;
            this.lblIndex.Location = new System.Drawing.Point(547, 10);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(72, 19);
            this.lblIndex.TabIndex = 9;
            this.lblIndex.Text = "ИНДЕКС:";
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(757, 402);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.cbIndex);
            this.Controls.Add(this.gbOrg);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(773, 443);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).EndInit();
            this.gbOrg.ResumeLayout(false);
            this.gbOrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.BindingSource segmentBindingSource;
        private System.Windows.Forms.GroupBox gbOrg;
        private System.Windows.Forms.TextBox tbInn;
        private System.Windows.Forms.Label lblOrgInn;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.ComboBox cbOrgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numBegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbIndex;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.BindingSource indexBindingSource;
        private System.Windows.Forms.ToolStripMenuItem interToolStripMenuItem;
    }
}

