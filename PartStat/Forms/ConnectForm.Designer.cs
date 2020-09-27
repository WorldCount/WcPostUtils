namespace PartStat.Forms
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnGetHost = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTestConnect = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.ForeColor = System.Drawing.Color.DimGray;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(16, 235);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(255, 30);
            this.cbType.TabIndex = 5;
            // 
            // btnGetHost
            // 
            this.btnGetHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnGetHost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGetHost.FlatAppearance.BorderSize = 0;
            this.btnGetHost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnGetHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetHost.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetHost.ForeColor = System.Drawing.Color.White;
            this.btnGetHost.Location = new System.Drawing.Point(473, 34);
            this.btnGetHost.Name = "btnGetHost";
            this.btnGetHost.Size = new System.Drawing.Size(63, 31);
            this.btnGetHost.TabIndex = 0;
            this.btnGetHost.TabStop = false;
            this.btnGetHost.Text = "Авто";
            this.btnGetHost.UseVisualStyleBackColor = false;
            this.btnGetHost.Click += new System.EventHandler(this.btnGetHost_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblPass.Location = new System.Drawing.Point(277, 143);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 21);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Пароль:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.ForeColor = System.Drawing.Color.DimGray;
            this.lblPort.Location = new System.Drawing.Point(277, 210);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(49, 21);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Порт:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.ForeColor = System.Drawing.Color.DimGray;
            this.lblType.Location = new System.Drawing.Point(12, 209);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 21);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Тип сервера:";
            // 
            // lblTestConnect
            // 
            this.lblTestConnect.AutoSize = true;
            this.lblTestConnect.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestConnect.ForeColor = System.Drawing.Color.DimGray;
            this.lblTestConnect.Location = new System.Drawing.Point(12, 278);
            this.lblTestConnect.Name = "lblTestConnect";
            this.lblTestConnect.Size = new System.Drawing.Size(186, 21);
            this.lblTestConnect.TabIndex = 0;
            this.lblTestConnect.Text = "Проверка подключения:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(12, 143);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(112, 21);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Пользователь:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.ForeColor = System.Drawing.Color.DimGray;
            this.lblPath.Location = new System.Drawing.Point(12, 75);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(83, 21);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Путь к БД:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHost.ForeColor = System.Drawing.Color.DimGray;
            this.lblHost.Location = new System.Drawing.Point(12, 8);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(45, 21);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Хост:";
            // 
            // tbPort
            // 
            this.tbPort.BackColor = System.Drawing.Color.White;
            this.tbPort.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPort.ForeColor = System.Drawing.Color.DimGray;
            this.tbPort.Location = new System.Drawing.Point(281, 236);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(76, 29);
            this.tbPort.TabIndex = 6;
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.White;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Location = new System.Drawing.Point(281, 169);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(255, 31);
            this.tbPass.TabIndex = 4;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.White;
            this.tbStatus.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.tbStatus.Location = new System.Drawing.Point(16, 304);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(255, 29);
            this.tbStatus.TabIndex = 0;
            this.tbStatus.TabStop = false;
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStatus_KeyPress);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.White;
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Location = new System.Drawing.Point(16, 169);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(255, 31);
            this.tbUser.TabIndex = 3;
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.BackColor = System.Drawing.Color.White;
            this.tbPath.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.ForeColor = System.Drawing.Color.DimGray;
            this.tbPath.Location = new System.Drawing.Point(16, 101);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(473, 31);
            this.tbPath.TabIndex = 2;
            // 
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.BackColor = System.Drawing.Color.White;
            this.tbHost.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHost.ForeColor = System.Drawing.Color.DimGray;
            this.tbHost.Location = new System.Drawing.Point(16, 34);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(451, 31);
            this.tbHost.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = global::PartStat.Properties.Resources.white_synchronize_24;
            this.btnCheck.Location = new System.Drawing.Point(281, 304);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(29, 29);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.TabStop = false;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::PartStat.Properties.Resources.white_cancel_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(16, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PartStat.Properties.Resources.white_ok_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(416, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Принять";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = global::PartStat.Properties.Resources.white_folder_24;
            this.btnChoose.Location = new System.Drawing.Point(495, 101);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(41, 31);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.TabStop = false;
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 409);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnGetHost);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTestConnect);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbHost);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditConnectForm";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnGetHost;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTestConnect;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbHost;
    }
}