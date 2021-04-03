namespace DwUtils.Forms.ConfigForms
{
    partial class ConnectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectsForm));
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabPostUnit = new System.Windows.Forms.TabPage();
            this.connectPostUnit = new DwUtils.Core.Libs.Widgets.ConnectWidget();
            this.groupBoxPostUnit = new System.Windows.Forms.GroupBox();
            this.cbCryptPostUnit = new System.Windows.Forms.ComboBox();
            this.lblCryptPostUnit = new System.Windows.Forms.Label();
            this.tbPortPostUnit = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.lblPortPostUnit = new System.Windows.Forms.Label();
            this.cbServerTypePostUnit = new System.Windows.Forms.ComboBox();
            this.tbServerTypePostUnit = new System.Windows.Forms.Label();
            this.tbPasswordPostUnit = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.tbLoginPostUnit = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.btnChoosePostUnit = new System.Windows.Forms.Button();
            this.lblPostUnit = new System.Windows.Forms.Label();
            this.lblLoginPostUnit = new System.Windows.Forms.Label();
            this.tbPathPostUnit = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.lblPathPostUnit = new System.Windows.Forms.Label();
            this.btnAutoPostUnit = new System.Windows.Forms.Button();
            this.tbHostPostUnit = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.lblHostPostUnit = new System.Windows.Forms.Label();
            this.tabPostItem = new System.Windows.Forms.TabPage();
            this.connectPostItem = new DwUtils.Core.Libs.Widgets.ConnectWidget();
            this.groupBoxPostItem = new System.Windows.Forms.GroupBox();
            this.cbCryptPostItem = new System.Windows.Forms.ComboBox();
            this.lblCryptPostItem = new System.Windows.Forms.Label();
            this.tbPortPostItem = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.lblPortPostItem = new System.Windows.Forms.Label();
            this.cbServerTypePostItem = new System.Windows.Forms.ComboBox();
            this.lblServerTypePostItem = new System.Windows.Forms.Label();
            this.tbPasswordPostItem = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.tbLoginPostItem = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.btnChoosePostItem = new System.Windows.Forms.Button();
            this.lblPasswordPostItem = new System.Windows.Forms.Label();
            this.lblUserPostItem = new System.Windows.Forms.Label();
            this.tbPathPostItem = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.lblPathPostItem = new System.Windows.Forms.Label();
            this.btnAutoPostItem = new System.Windows.Forms.Button();
            this.tbHostPostItem = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.lblHostPostItem = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbTimeoutPostUnit = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.lblTimeoutPostUnit = new System.Windows.Forms.Label();
            this.tbTimeoutPostItem = new Wc32Api.Widgets.TextBoxs.BorderTextBox();
            this.lblTimeoutPostItem = new System.Windows.Forms.Label();
            this.tabsControl.SuspendLayout();
            this.tabPostUnit.SuspendLayout();
            this.groupBoxPostUnit.SuspendLayout();
            this.tabPostItem.SuspendLayout();
            this.groupBoxPostItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsControl.Controls.Add(this.tabPostUnit);
            this.tabsControl.Controls.Add(this.tabPostItem);
            this.tabsControl.Location = new System.Drawing.Point(1, 52);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(722, 431);
            this.tabsControl.TabIndex = 0;
            this.tabsControl.TabStop = false;
            // 
            // tabPostUnit
            // 
            this.tabPostUnit.BackColor = System.Drawing.Color.White;
            this.tabPostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPostUnit.Controls.Add(this.connectPostUnit);
            this.tabPostUnit.Controls.Add(this.groupBoxPostUnit);
            this.tabPostUnit.Location = new System.Drawing.Point(4, 29);
            this.tabPostUnit.Name = "tabPostUnit";
            this.tabPostUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostUnit.Size = new System.Drawing.Size(714, 398);
            this.tabPostUnit.TabIndex = 0;
            this.tabPostUnit.Text = "PostUnit";
            // 
            // connectPostUnit
            // 
            this.connectPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectPostUnit.BorderColor = System.Drawing.Color.Gray;
            this.connectPostUnit.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.connectPostUnit.BorderWidth = 1;
            this.connectPostUnit.ErrorStatusColor = System.Drawing.Color.Firebrick;
            this.connectPostUnit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectPostUnit.Location = new System.Drawing.Point(27, 331);
            this.connectPostUnit.Message = "Подключение к PostUnit";
            this.connectPostUnit.MessageColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.connectPostUnit.Name = "connectPostUnit";
            this.connectPostUnit.Size = new System.Drawing.Size(375, 40);
            this.connectPostUnit.StatusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.connectPostUnit.StatusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.connectPostUnit.StatusBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.connectPostUnit.StatusBorderWidth = 1;
            this.connectPostUnit.SuccessStatusColor = System.Drawing.Color.SeaGreen;
            this.connectPostUnit.TabIndex = 3;
            // 
            // groupBoxPostUnit
            // 
            this.groupBoxPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPostUnit.Controls.Add(this.tbTimeoutPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.lblTimeoutPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.cbCryptPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.lblCryptPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.tbPortPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.lblPortPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.cbServerTypePostUnit);
            this.groupBoxPostUnit.Controls.Add(this.tbServerTypePostUnit);
            this.groupBoxPostUnit.Controls.Add(this.tbPasswordPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.tbLoginPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.btnChoosePostUnit);
            this.groupBoxPostUnit.Controls.Add(this.lblPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.lblLoginPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.tbPathPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.lblPathPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.btnAutoPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.tbHostPostUnit);
            this.groupBoxPostUnit.Controls.Add(this.lblHostPostUnit);
            this.groupBoxPostUnit.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPostUnit.Name = "groupBoxPostUnit";
            this.groupBoxPostUnit.Size = new System.Drawing.Size(700, 310);
            this.groupBoxPostUnit.TabIndex = 0;
            this.groupBoxPostUnit.TabStop = false;
            this.groupBoxPostUnit.Text = "Подключение к PostUnit";
            // 
            // cbCryptPostUnit
            // 
            this.cbCryptPostUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCryptPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.cbCryptPostUnit.FormattingEnabled = true;
            this.cbCryptPostUnit.Location = new System.Drawing.Point(158, 270);
            this.cbCryptPostUnit.Name = "cbCryptPostUnit";
            this.cbCryptPostUnit.Size = new System.Drawing.Size(247, 28);
            this.cbCryptPostUnit.TabIndex = 16;
            // 
            // lblCryptPostUnit
            // 
            this.lblCryptPostUnit.AutoSize = true;
            this.lblCryptPostUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCryptPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblCryptPostUnit.Location = new System.Drawing.Point(16, 269);
            this.lblCryptPostUnit.Name = "lblCryptPostUnit";
            this.lblCryptPostUnit.Size = new System.Drawing.Size(136, 25);
            this.lblCryptPostUnit.TabIndex = 15;
            this.lblCryptPostUnit.Text = "Шифрование:";
            // 
            // tbPortPostUnit
            // 
            this.tbPortPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPortPostUnit.BackColor = System.Drawing.Color.White;
            this.tbPortPostUnit.BorderHeight = 2;
            this.tbPortPostUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPortPostUnit.EnterColor = System.Drawing.Color.Firebrick;
            this.tbPortPostUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPortPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbPortPostUnit.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbPortPostUnit.Location = new System.Drawing.Point(498, 226);
            this.tbPortPostUnit.Name = "tbPortPostUnit";
            this.tbPortPostUnit.Size = new System.Drawing.Size(90, 26);
            this.tbPortPostUnit.TabIndex = 14;
            this.tbPortPostUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // lblPortPostUnit
            // 
            this.lblPortPostUnit.AutoSize = true;
            this.lblPortPostUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPortPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblPortPostUnit.Location = new System.Drawing.Point(431, 227);
            this.lblPortPostUnit.Name = "lblPortPostUnit";
            this.lblPortPostUnit.Size = new System.Drawing.Size(61, 25);
            this.lblPortPostUnit.TabIndex = 13;
            this.lblPortPostUnit.Text = "Порт:";
            // 
            // cbServerTypePostUnit
            // 
            this.cbServerTypePostUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbServerTypePostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.cbServerTypePostUnit.FormattingEnabled = true;
            this.cbServerTypePostUnit.Location = new System.Drawing.Point(158, 227);
            this.cbServerTypePostUnit.Name = "cbServerTypePostUnit";
            this.cbServerTypePostUnit.Size = new System.Drawing.Size(247, 28);
            this.cbServerTypePostUnit.TabIndex = 12;
            // 
            // tbServerTypePostUnit
            // 
            this.tbServerTypePostUnit.AutoSize = true;
            this.tbServerTypePostUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServerTypePostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.tbServerTypePostUnit.Location = new System.Drawing.Point(16, 227);
            this.tbServerTypePostUnit.Name = "tbServerTypePostUnit";
            this.tbServerTypePostUnit.Size = new System.Drawing.Size(125, 25);
            this.tbServerTypePostUnit.TabIndex = 11;
            this.tbServerTypePostUnit.Text = "Тип сервера:";
            // 
            // tbPasswordPostUnit
            // 
            this.tbPasswordPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordPostUnit.BackColor = System.Drawing.Color.White;
            this.tbPasswordPostUnit.BorderHeight = 2;
            this.tbPasswordPostUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordPostUnit.EnterColor = System.Drawing.Color.Firebrick;
            this.tbPasswordPostUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbPasswordPostUnit.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbPasswordPostUnit.Location = new System.Drawing.Point(106, 179);
            this.tbPasswordPostUnit.Name = "tbPasswordPostUnit";
            this.tbPasswordPostUnit.PasswordChar = '*';
            this.tbPasswordPostUnit.Size = new System.Drawing.Size(482, 26);
            this.tbPasswordPostUnit.TabIndex = 10;
            // 
            // tbLoginPostUnit
            // 
            this.tbLoginPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoginPostUnit.BackColor = System.Drawing.Color.White;
            this.tbLoginPostUnit.BorderHeight = 2;
            this.tbLoginPostUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginPostUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLoginPostUnit.EnterColor = System.Drawing.Color.Firebrick;
            this.tbLoginPostUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbLoginPostUnit.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbLoginPostUnit.Location = new System.Drawing.Point(165, 131);
            this.tbLoginPostUnit.Name = "tbLoginPostUnit";
            this.tbLoginPostUnit.Size = new System.Drawing.Size(423, 26);
            this.tbLoginPostUnit.TabIndex = 9;
            // 
            // btnChoosePostUnit
            // 
            this.btnChoosePostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoosePostUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnChoosePostUnit.FlatAppearance.BorderSize = 0;
            this.btnChoosePostUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.btnChoosePostUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(109)))), ((int)(((byte)(120)))));
            this.btnChoosePostUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePostUnit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePostUnit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChoosePostUnit.Location = new System.Drawing.Point(594, 80);
            this.btnChoosePostUnit.Name = "btnChoosePostUnit";
            this.btnChoosePostUnit.Size = new System.Drawing.Size(100, 34);
            this.btnChoosePostUnit.TabIndex = 8;
            this.btnChoosePostUnit.TabStop = false;
            this.btnChoosePostUnit.Text = " ...";
            this.btnChoosePostUnit.UseVisualStyleBackColor = false;
            this.btnChoosePostUnit.Click += new System.EventHandler(this.btnChoosePostUnit_Click);
            // 
            // lblPostUnit
            // 
            this.lblPostUnit.AutoSize = true;
            this.lblPostUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblPostUnit.Location = new System.Drawing.Point(16, 179);
            this.lblPostUnit.Name = "lblPostUnit";
            this.lblPostUnit.Size = new System.Drawing.Size(84, 25);
            this.lblPostUnit.TabIndex = 7;
            this.lblPostUnit.Text = "Пароль:";
            // 
            // lblLoginPostUnit
            // 
            this.lblLoginPostUnit.AutoSize = true;
            this.lblLoginPostUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblLoginPostUnit.Location = new System.Drawing.Point(16, 132);
            this.lblLoginPostUnit.Name = "lblLoginPostUnit";
            this.lblLoginPostUnit.Size = new System.Drawing.Size(143, 25);
            this.lblLoginPostUnit.TabIndex = 7;
            this.lblLoginPostUnit.Text = "Пользователь:";
            // 
            // tbPathPostUnit
            // 
            this.tbPathPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPathPostUnit.BackColor = System.Drawing.Color.White;
            this.tbPathPostUnit.BorderHeight = 2;
            this.tbPathPostUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathPostUnit.EnterColor = System.Drawing.Color.Firebrick;
            this.tbPathPostUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPathPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbPathPostUnit.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbPathPostUnit.Location = new System.Drawing.Point(126, 83);
            this.tbPathPostUnit.Name = "tbPathPostUnit";
            this.tbPathPostUnit.Size = new System.Drawing.Size(462, 26);
            this.tbPathPostUnit.TabIndex = 6;
            // 
            // lblPathPostUnit
            // 
            this.lblPathPostUnit.AutoSize = true;
            this.lblPathPostUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblPathPostUnit.Location = new System.Drawing.Point(16, 83);
            this.lblPathPostUnit.Name = "lblPathPostUnit";
            this.lblPathPostUnit.Size = new System.Drawing.Size(104, 25);
            this.lblPathPostUnit.TabIndex = 5;
            this.lblPathPostUnit.Text = "Путь к БД:";
            // 
            // btnAutoPostUnit
            // 
            this.btnAutoPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPostUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnAutoPostUnit.FlatAppearance.BorderSize = 0;
            this.btnAutoPostUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.btnAutoPostUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(109)))), ((int)(((byte)(120)))));
            this.btnAutoPostUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPostUnit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoPostUnit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutoPostUnit.Location = new System.Drawing.Point(594, 32);
            this.btnAutoPostUnit.Name = "btnAutoPostUnit";
            this.btnAutoPostUnit.Size = new System.Drawing.Size(100, 34);
            this.btnAutoPostUnit.TabIndex = 4;
            this.btnAutoPostUnit.TabStop = false;
            this.btnAutoPostUnit.Text = "Авто";
            this.btnAutoPostUnit.UseVisualStyleBackColor = false;
            this.btnAutoPostUnit.Click += new System.EventHandler(this.btnAutoPostUnit_Click);
            // 
            // tbHostPostUnit
            // 
            this.tbHostPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHostPostUnit.BackColor = System.Drawing.Color.White;
            this.tbHostPostUnit.BorderHeight = 2;
            this.tbHostPostUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHostPostUnit.EnterColor = System.Drawing.Color.Firebrick;
            this.tbHostPostUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHostPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbHostPostUnit.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbHostPostUnit.Location = new System.Drawing.Point(79, 35);
            this.tbHostPostUnit.Name = "tbHostPostUnit";
            this.tbHostPostUnit.Size = new System.Drawing.Size(509, 26);
            this.tbHostPostUnit.TabIndex = 3;
            // 
            // lblHostPostUnit
            // 
            this.lblHostPostUnit.AutoSize = true;
            this.lblHostPostUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHostPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblHostPostUnit.Location = new System.Drawing.Point(16, 36);
            this.lblHostPostUnit.Name = "lblHostPostUnit";
            this.lblHostPostUnit.Size = new System.Drawing.Size(57, 25);
            this.lblHostPostUnit.TabIndex = 2;
            this.lblHostPostUnit.Text = "Хост:";
            // 
            // tabPostItem
            // 
            this.tabPostItem.BackColor = System.Drawing.Color.White;
            this.tabPostItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPostItem.Controls.Add(this.connectPostItem);
            this.tabPostItem.Controls.Add(this.groupBoxPostItem);
            this.tabPostItem.Location = new System.Drawing.Point(4, 29);
            this.tabPostItem.Name = "tabPostItem";
            this.tabPostItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostItem.Size = new System.Drawing.Size(714, 398);
            this.tabPostItem.TabIndex = 1;
            this.tabPostItem.Text = "PostItem";
            // 
            // connectPostItem
            // 
            this.connectPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectPostItem.BorderColor = System.Drawing.Color.Gray;
            this.connectPostItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.connectPostItem.BorderWidth = 1;
            this.connectPostItem.ErrorStatusColor = System.Drawing.Color.Firebrick;
            this.connectPostItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectPostItem.Location = new System.Drawing.Point(27, 331);
            this.connectPostItem.Message = "Подключение к PostItem";
            this.connectPostItem.MessageColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.connectPostItem.Name = "connectPostItem";
            this.connectPostItem.Size = new System.Drawing.Size(375, 40);
            this.connectPostItem.StatusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.connectPostItem.StatusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.connectPostItem.StatusBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.connectPostItem.StatusBorderWidth = 1;
            this.connectPostItem.SuccessStatusColor = System.Drawing.Color.SeaGreen;
            this.connectPostItem.TabIndex = 2;
            // 
            // groupBoxPostItem
            // 
            this.groupBoxPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPostItem.Controls.Add(this.tbTimeoutPostItem);
            this.groupBoxPostItem.Controls.Add(this.lblTimeoutPostItem);
            this.groupBoxPostItem.Controls.Add(this.cbCryptPostItem);
            this.groupBoxPostItem.Controls.Add(this.lblCryptPostItem);
            this.groupBoxPostItem.Controls.Add(this.tbPortPostItem);
            this.groupBoxPostItem.Controls.Add(this.lblPortPostItem);
            this.groupBoxPostItem.Controls.Add(this.cbServerTypePostItem);
            this.groupBoxPostItem.Controls.Add(this.lblServerTypePostItem);
            this.groupBoxPostItem.Controls.Add(this.tbPasswordPostItem);
            this.groupBoxPostItem.Controls.Add(this.tbLoginPostItem);
            this.groupBoxPostItem.Controls.Add(this.btnChoosePostItem);
            this.groupBoxPostItem.Controls.Add(this.lblPasswordPostItem);
            this.groupBoxPostItem.Controls.Add(this.lblUserPostItem);
            this.groupBoxPostItem.Controls.Add(this.tbPathPostItem);
            this.groupBoxPostItem.Controls.Add(this.lblPathPostItem);
            this.groupBoxPostItem.Controls.Add(this.btnAutoPostItem);
            this.groupBoxPostItem.Controls.Add(this.tbHostPostItem);
            this.groupBoxPostItem.Controls.Add(this.lblHostPostItem);
            this.groupBoxPostItem.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPostItem.Name = "groupBoxPostItem";
            this.groupBoxPostItem.Size = new System.Drawing.Size(700, 310);
            this.groupBoxPostItem.TabIndex = 1;
            this.groupBoxPostItem.TabStop = false;
            this.groupBoxPostItem.Text = "Подключение к PostItem";
            // 
            // cbCryptPostItem
            // 
            this.cbCryptPostItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCryptPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.cbCryptPostItem.FormattingEnabled = true;
            this.cbCryptPostItem.Location = new System.Drawing.Point(158, 270);
            this.cbCryptPostItem.Name = "cbCryptPostItem";
            this.cbCryptPostItem.Size = new System.Drawing.Size(247, 28);
            this.cbCryptPostItem.TabIndex = 18;
            // 
            // lblCryptPostItem
            // 
            this.lblCryptPostItem.AutoSize = true;
            this.lblCryptPostItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCryptPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblCryptPostItem.Location = new System.Drawing.Point(16, 269);
            this.lblCryptPostItem.Name = "lblCryptPostItem";
            this.lblCryptPostItem.Size = new System.Drawing.Size(136, 25);
            this.lblCryptPostItem.TabIndex = 17;
            this.lblCryptPostItem.Text = "Шифрование:";
            // 
            // tbPortPostItem
            // 
            this.tbPortPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPortPostItem.BackColor = System.Drawing.Color.White;
            this.tbPortPostItem.BorderHeight = 2;
            this.tbPortPostItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPortPostItem.EnterColor = System.Drawing.Color.Firebrick;
            this.tbPortPostItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPortPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbPortPostItem.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbPortPostItem.Location = new System.Drawing.Point(498, 226);
            this.tbPortPostItem.Name = "tbPortPostItem";
            this.tbPortPostItem.Size = new System.Drawing.Size(90, 26);
            this.tbPortPostItem.TabIndex = 14;
            this.tbPortPostItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // lblPortPostItem
            // 
            this.lblPortPostItem.AutoSize = true;
            this.lblPortPostItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPortPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblPortPostItem.Location = new System.Drawing.Point(431, 227);
            this.lblPortPostItem.Name = "lblPortPostItem";
            this.lblPortPostItem.Size = new System.Drawing.Size(61, 25);
            this.lblPortPostItem.TabIndex = 13;
            this.lblPortPostItem.Text = "Порт:";
            // 
            // cbServerTypePostItem
            // 
            this.cbServerTypePostItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbServerTypePostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.cbServerTypePostItem.FormattingEnabled = true;
            this.cbServerTypePostItem.Location = new System.Drawing.Point(158, 227);
            this.cbServerTypePostItem.Name = "cbServerTypePostItem";
            this.cbServerTypePostItem.Size = new System.Drawing.Size(247, 28);
            this.cbServerTypePostItem.TabIndex = 12;
            // 
            // lblServerTypePostItem
            // 
            this.lblServerTypePostItem.AutoSize = true;
            this.lblServerTypePostItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServerTypePostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblServerTypePostItem.Location = new System.Drawing.Point(16, 227);
            this.lblServerTypePostItem.Name = "lblServerTypePostItem";
            this.lblServerTypePostItem.Size = new System.Drawing.Size(125, 25);
            this.lblServerTypePostItem.TabIndex = 11;
            this.lblServerTypePostItem.Text = "Тип сервера:";
            // 
            // tbPasswordPostItem
            // 
            this.tbPasswordPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordPostItem.BackColor = System.Drawing.Color.White;
            this.tbPasswordPostItem.BorderHeight = 2;
            this.tbPasswordPostItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordPostItem.EnterColor = System.Drawing.Color.Firebrick;
            this.tbPasswordPostItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbPasswordPostItem.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbPasswordPostItem.Location = new System.Drawing.Point(106, 179);
            this.tbPasswordPostItem.Name = "tbPasswordPostItem";
            this.tbPasswordPostItem.PasswordChar = '*';
            this.tbPasswordPostItem.Size = new System.Drawing.Size(482, 26);
            this.tbPasswordPostItem.TabIndex = 10;
            // 
            // tbLoginPostItem
            // 
            this.tbLoginPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoginPostItem.BackColor = System.Drawing.Color.White;
            this.tbLoginPostItem.BorderHeight = 2;
            this.tbLoginPostItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginPostItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLoginPostItem.EnterColor = System.Drawing.Color.Firebrick;
            this.tbLoginPostItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbLoginPostItem.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbLoginPostItem.Location = new System.Drawing.Point(165, 131);
            this.tbLoginPostItem.Name = "tbLoginPostItem";
            this.tbLoginPostItem.Size = new System.Drawing.Size(423, 26);
            this.tbLoginPostItem.TabIndex = 9;
            // 
            // btnChoosePostItem
            // 
            this.btnChoosePostItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoosePostItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnChoosePostItem.FlatAppearance.BorderSize = 0;
            this.btnChoosePostItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.btnChoosePostItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(109)))), ((int)(((byte)(120)))));
            this.btnChoosePostItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePostItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePostItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChoosePostItem.Location = new System.Drawing.Point(594, 80);
            this.btnChoosePostItem.Name = "btnChoosePostItem";
            this.btnChoosePostItem.Size = new System.Drawing.Size(100, 34);
            this.btnChoosePostItem.TabIndex = 8;
            this.btnChoosePostItem.TabStop = false;
            this.btnChoosePostItem.Text = " ...";
            this.btnChoosePostItem.UseVisualStyleBackColor = false;
            this.btnChoosePostItem.Click += new System.EventHandler(this.btnChoosePostItem_Click);
            // 
            // lblPasswordPostItem
            // 
            this.lblPasswordPostItem.AutoSize = true;
            this.lblPasswordPostItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPasswordPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblPasswordPostItem.Location = new System.Drawing.Point(16, 179);
            this.lblPasswordPostItem.Name = "lblPasswordPostItem";
            this.lblPasswordPostItem.Size = new System.Drawing.Size(84, 25);
            this.lblPasswordPostItem.TabIndex = 7;
            this.lblPasswordPostItem.Text = "Пароль:";
            // 
            // lblUserPostItem
            // 
            this.lblUserPostItem.AutoSize = true;
            this.lblUserPostItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblUserPostItem.Location = new System.Drawing.Point(16, 132);
            this.lblUserPostItem.Name = "lblUserPostItem";
            this.lblUserPostItem.Size = new System.Drawing.Size(143, 25);
            this.lblUserPostItem.TabIndex = 7;
            this.lblUserPostItem.Text = "Пользователь:";
            // 
            // tbPathPostItem
            // 
            this.tbPathPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPathPostItem.BackColor = System.Drawing.Color.White;
            this.tbPathPostItem.BorderHeight = 2;
            this.tbPathPostItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathPostItem.EnterColor = System.Drawing.Color.Firebrick;
            this.tbPathPostItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPathPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbPathPostItem.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbPathPostItem.Location = new System.Drawing.Point(126, 83);
            this.tbPathPostItem.Name = "tbPathPostItem";
            this.tbPathPostItem.Size = new System.Drawing.Size(462, 26);
            this.tbPathPostItem.TabIndex = 6;
            // 
            // lblPathPostItem
            // 
            this.lblPathPostItem.AutoSize = true;
            this.lblPathPostItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblPathPostItem.Location = new System.Drawing.Point(16, 83);
            this.lblPathPostItem.Name = "lblPathPostItem";
            this.lblPathPostItem.Size = new System.Drawing.Size(104, 25);
            this.lblPathPostItem.TabIndex = 5;
            this.lblPathPostItem.Text = "Путь к БД:";
            // 
            // btnAutoPostItem
            // 
            this.btnAutoPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPostItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnAutoPostItem.FlatAppearance.BorderSize = 0;
            this.btnAutoPostItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.btnAutoPostItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(109)))), ((int)(((byte)(120)))));
            this.btnAutoPostItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPostItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoPostItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutoPostItem.Location = new System.Drawing.Point(594, 32);
            this.btnAutoPostItem.Name = "btnAutoPostItem";
            this.btnAutoPostItem.Size = new System.Drawing.Size(100, 34);
            this.btnAutoPostItem.TabIndex = 4;
            this.btnAutoPostItem.TabStop = false;
            this.btnAutoPostItem.Text = "Авто";
            this.btnAutoPostItem.UseVisualStyleBackColor = false;
            this.btnAutoPostItem.Click += new System.EventHandler(this.btnAutoPostItem_Click);
            // 
            // tbHostPostItem
            // 
            this.tbHostPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHostPostItem.BackColor = System.Drawing.Color.White;
            this.tbHostPostItem.BorderHeight = 2;
            this.tbHostPostItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHostPostItem.EnterColor = System.Drawing.Color.Firebrick;
            this.tbHostPostItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHostPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbHostPostItem.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbHostPostItem.Location = new System.Drawing.Point(79, 35);
            this.tbHostPostItem.Name = "tbHostPostItem";
            this.tbHostPostItem.Size = new System.Drawing.Size(509, 26);
            this.tbHostPostItem.TabIndex = 3;
            // 
            // lblHostPostItem
            // 
            this.lblHostPostItem.AutoSize = true;
            this.lblHostPostItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHostPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblHostPostItem.Location = new System.Drawing.Point(16, 36);
            this.lblHostPostItem.Name = "lblHostPostItem";
            this.lblHostPostItem.Size = new System.Drawing.Size(57, 25);
            this.lblHostPostItem.TabIndex = 2;
            this.lblHostPostItem.Text = "Хост:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(186, 28);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Подключение к БД";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::DwUtils.Properties.Resources.save_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(592, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::DwUtils.Properties.Resources.close_window_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(466, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbTimeoutPostUnit
            // 
            this.tbTimeoutPostUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimeoutPostUnit.BackColor = System.Drawing.Color.White;
            this.tbTimeoutPostUnit.BorderHeight = 2;
            this.tbTimeoutPostUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTimeoutPostUnit.EnterColor = System.Drawing.Color.Firebrick;
            this.tbTimeoutPostUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeoutPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbTimeoutPostUnit.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbTimeoutPostUnit.Location = new System.Drawing.Point(525, 268);
            this.tbTimeoutPostUnit.Name = "tbTimeoutPostUnit";
            this.tbTimeoutPostUnit.Size = new System.Drawing.Size(63, 26);
            this.tbTimeoutPostUnit.TabIndex = 18;
            this.tbTimeoutPostUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTimeout_KeyPress);
            // 
            // lblTimeoutPostUnit
            // 
            this.lblTimeoutPostUnit.AutoSize = true;
            this.lblTimeoutPostUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeoutPostUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblTimeoutPostUnit.Location = new System.Drawing.Point(431, 269);
            this.lblTimeoutPostUnit.Name = "lblTimeoutPostUnit";
            this.lblTimeoutPostUnit.Size = new System.Drawing.Size(88, 25);
            this.lblTimeoutPostUnit.TabIndex = 17;
            this.lblTimeoutPostUnit.Text = "Таймаут:";
            // 
            // tbTimeoutPostItem
            // 
            this.tbTimeoutPostItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimeoutPostItem.BackColor = System.Drawing.Color.White;
            this.tbTimeoutPostItem.BorderHeight = 2;
            this.tbTimeoutPostItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTimeoutPostItem.EnterColor = System.Drawing.Color.Firebrick;
            this.tbTimeoutPostItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeoutPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbTimeoutPostItem.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbTimeoutPostItem.Location = new System.Drawing.Point(525, 268);
            this.tbTimeoutPostItem.Name = "tbTimeoutPostItem";
            this.tbTimeoutPostItem.Size = new System.Drawing.Size(63, 26);
            this.tbTimeoutPostItem.TabIndex = 20;
            this.tbTimeoutPostItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTimeout_KeyPress);
            // 
            // lblTimeoutPostItem
            // 
            this.lblTimeoutPostItem.AutoSize = true;
            this.lblTimeoutPostItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeoutPostItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblTimeoutPostItem.Location = new System.Drawing.Point(431, 269);
            this.lblTimeoutPostItem.Name = "lblTimeoutPostItem";
            this.lblTimeoutPostItem.Size = new System.Drawing.Size(88, 25);
            this.lblTimeoutPostItem.TabIndex = 19;
            this.lblTimeoutPostItem.Text = "Таймаут:";
            // 
            // ConnectsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(740, 580);
            this.Name = "ConnectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectsForm";
            this.Load += new System.EventHandler(this.ConnectsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectsForm_KeyDown);
            this.tabsControl.ResumeLayout(false);
            this.tabPostUnit.ResumeLayout(false);
            this.groupBoxPostUnit.ResumeLayout(false);
            this.groupBoxPostUnit.PerformLayout();
            this.tabPostItem.ResumeLayout(false);
            this.groupBoxPostItem.ResumeLayout(false);
            this.groupBoxPostItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabPostUnit;
        private System.Windows.Forms.TabPage tabPostItem;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBoxPostUnit;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbHostPostUnit;
        private System.Windows.Forms.Label lblHostPostUnit;
        private System.Windows.Forms.Button btnAutoPostUnit;
        private System.Windows.Forms.Button btnChoosePostUnit;
        private System.Windows.Forms.Label lblPostUnit;
        private System.Windows.Forms.Label lblLoginPostUnit;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbPathPostUnit;
        private System.Windows.Forms.Label lblPathPostUnit;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbPasswordPostUnit;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbLoginPostUnit;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbPortPostUnit;
        private System.Windows.Forms.Label lblPortPostUnit;
        private System.Windows.Forms.ComboBox cbServerTypePostUnit;
        private System.Windows.Forms.Label tbServerTypePostUnit;
        private Core.Libs.Widgets.ConnectWidget connectPostItem;
        private System.Windows.Forms.GroupBox groupBoxPostItem;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbPortPostItem;
        private System.Windows.Forms.Label lblPortPostItem;
        private System.Windows.Forms.ComboBox cbServerTypePostItem;
        private System.Windows.Forms.Label lblServerTypePostItem;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbPasswordPostItem;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbLoginPostItem;
        private System.Windows.Forms.Button btnChoosePostItem;
        private System.Windows.Forms.Label lblPasswordPostItem;
        private System.Windows.Forms.Label lblUserPostItem;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbPathPostItem;
        private System.Windows.Forms.Label lblPathPostItem;
        private System.Windows.Forms.Button btnAutoPostItem;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbHostPostItem;
        private System.Windows.Forms.Label lblHostPostItem;
        private Core.Libs.Widgets.ConnectWidget connectPostUnit;
        private System.Windows.Forms.ComboBox cbCryptPostUnit;
        private System.Windows.Forms.Label lblCryptPostUnit;
        private System.Windows.Forms.ComboBox cbCryptPostItem;
        private System.Windows.Forms.Label lblCryptPostItem;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbTimeoutPostUnit;
        private System.Windows.Forms.Label lblTimeoutPostUnit;
        private Wc32Api.Widgets.TextBoxs.BorderTextBox tbTimeoutPostItem;
        private System.Windows.Forms.Label lblTimeoutPostItem;
    }
}