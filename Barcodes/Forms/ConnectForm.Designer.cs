namespace Barcodes.Forms
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
            this.tbHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnGetHost = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.lblTestConnect = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHost.ForeColor = System.Drawing.Color.DimGray;
            this.tbHost.Location = new System.Drawing.Point(12, 34);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(451, 29);
            this.tbHost.TabIndex = 1;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHost.ForeColor = System.Drawing.Color.DimGray;
            this.lblHost.Location = new System.Drawing.Point(8, 9);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(60, 22);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Хост:";
            // 
            // btnGetHost
            // 
            this.btnGetHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnGetHost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGetHost.FlatAppearance.BorderSize = 0;
            this.btnGetHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetHost.ForeColor = System.Drawing.Color.White;
            this.btnGetHost.Location = new System.Drawing.Point(469, 34);
            this.btnGetHost.Name = "btnGetHost";
            this.btnGetHost.Size = new System.Drawing.Size(63, 29);
            this.btnGetHost.TabIndex = 0;
            this.btnGetHost.TabStop = false;
            this.btnGetHost.Text = "Авто";
            this.btnGetHost.UseVisualStyleBackColor = false;
            this.btnGetHost.Click += new System.EventHandler(this.btnGetHost_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.ForeColor = System.Drawing.Color.DimGray;
            this.lblPath.Location = new System.Drawing.Point(8, 76);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(110, 22);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Путь к БД:";
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.ForeColor = System.Drawing.Color.DimGray;
            this.tbPath.Location = new System.Drawing.Point(12, 101);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(473, 29);
            this.tbPath.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Location = new System.Drawing.Point(12, 169);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(255, 29);
            this.tbUser.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Location = new System.Drawing.Point(277, 169);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(255, 29);
            this.tbPass.TabIndex = 4;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(8, 144);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(140, 22);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Пользователь:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblPass.Location = new System.Drawing.Point(273, 144);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(80, 22);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Пароль:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.ForeColor = System.Drawing.Color.DimGray;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(12, 235);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(255, 30);
            this.cbType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.ForeColor = System.Drawing.Color.DimGray;
            this.lblType.Location = new System.Drawing.Point(8, 210);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(130, 22);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Тип сервера:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.ForeColor = System.Drawing.Color.DimGray;
            this.lblPort.Location = new System.Drawing.Point(273, 210);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(60, 22);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Порт:";
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPort.ForeColor = System.Drawing.Color.DimGray;
            this.tbPort.Location = new System.Drawing.Point(277, 236);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(76, 29);
            this.tbPort.TabIndex = 6;
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbStatus.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.tbStatus.Location = new System.Drawing.Point(12, 304);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(255, 29);
            this.tbStatus.TabIndex = 0;
            this.tbStatus.TabStop = false;
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStatus_KeyPress);
            // 
            // lblTestConnect
            // 
            this.lblTestConnect.AutoSize = true;
            this.lblTestConnect.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestConnect.ForeColor = System.Drawing.Color.DimGray;
            this.lblTestConnect.Location = new System.Drawing.Point(8, 279);
            this.lblTestConnect.Name = "lblTestConnect";
            this.lblTestConnect.Size = new System.Drawing.Size(220, 22);
            this.lblTestConnect.TabIndex = 1;
            this.lblTestConnect.Text = "Проверка подключения:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = global::Barcodes.Properties.Resources.loop_circular_4x;
            this.btnCheck.Location = new System.Drawing.Point(277, 304);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(56, 29);
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
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::Barcodes.Properties.Resources.circle_x_3x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
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
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Barcodes.Properties.Resources.circle_check_3x;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(422, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
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
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = global::Barcodes.Properties.Resources.folder_2x;
            this.btnChoose.Location = new System.Drawing.Point(491, 101);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(41, 29);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.TabStop = false;
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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
            this.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(560, 450);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подключение к БД";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button btnGetHost;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label lblTestConnect;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}