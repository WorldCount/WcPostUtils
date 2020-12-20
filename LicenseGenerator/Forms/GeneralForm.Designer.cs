namespace LicenseGenerator.Forms
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
            this.groupBoxKey = new System.Windows.Forms.GroupBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.btnGetHost = new System.Windows.Forms.Button();
            this.lblAuthKey = new System.Windows.Forms.Label();
            this.tbAuthKey = new System.Windows.Forms.TextBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.tbAppName = new System.Windows.Forms.TextBox();
            this.lblAppId = new System.Windows.Forms.Label();
            this.tbAppId = new System.Windows.Forms.TextBox();
            this.btnGetId = new System.Windows.Forms.Button();
            this.btnGenLicense = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblLicense = new System.Windows.Forms.Label();
            this.tbLicenseKey = new System.Windows.Forms.TextBox();
            this.groupBoxKey.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKey
            // 
            this.groupBoxKey.Controls.Add(this.btnGetId);
            this.groupBoxKey.Controls.Add(this.btnGetHost);
            this.groupBoxKey.Controls.Add(this.tbAppId);
            this.groupBoxKey.Controls.Add(this.lblAppId);
            this.groupBoxKey.Controls.Add(this.tbAppName);
            this.groupBoxKey.Controls.Add(this.lblAppName);
            this.groupBoxKey.Controls.Add(this.tbAuthKey);
            this.groupBoxKey.Controls.Add(this.lblAuthKey);
            this.groupBoxKey.Controls.Add(this.tbHost);
            this.groupBoxKey.Controls.Add(this.lblIp);
            this.groupBoxKey.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxKey.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxKey.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKey.Name = "groupBoxKey";
            this.groupBoxKey.Size = new System.Drawing.Size(776, 192);
            this.groupBoxKey.TabIndex = 0;
            this.groupBoxKey.TabStop = false;
            this.groupBoxKey.Text = "Генератор ключа";
            // 
            // tbHost
            // 
            this.tbHost.BackColor = System.Drawing.Color.White;
            this.tbHost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHost.ForeColor = System.Drawing.Color.DimGray;
            this.tbHost.Location = new System.Drawing.Point(10, 62);
            this.tbHost.MaxLength = 100;
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(186, 29);
            this.tbHost.TabIndex = 1;
            this.tbHost.TabStop = false;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIp.ForeColor = System.Drawing.Color.DimGray;
            this.lblIp.Location = new System.Drawing.Point(6, 39);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(70, 20);
            this.lblIp.TabIndex = 2;
            this.lblIp.Text = "IP-адрес:";
            // 
            // btnGetHost
            // 
            this.btnGetHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnGetHost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGetHost.FlatAppearance.BorderSize = 0;
            this.btnGetHost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnGetHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetHost.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetHost.ForeColor = System.Drawing.Color.White;
            this.btnGetHost.Location = new System.Drawing.Point(202, 62);
            this.btnGetHost.Name = "btnGetHost";
            this.btnGetHost.Size = new System.Drawing.Size(63, 29);
            this.btnGetHost.TabIndex = 3;
            this.btnGetHost.TabStop = false;
            this.btnGetHost.Text = "Авто";
            this.btnGetHost.UseVisualStyleBackColor = false;
            this.btnGetHost.Click += new System.EventHandler(this.btnGetHost_Click);
            // 
            // lblAuthKey
            // 
            this.lblAuthKey.AutoSize = true;
            this.lblAuthKey.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthKey.ForeColor = System.Drawing.Color.DimGray;
            this.lblAuthKey.Location = new System.Drawing.Point(309, 39);
            this.lblAuthKey.Name = "lblAuthKey";
            this.lblAuthKey.Size = new System.Drawing.Size(71, 20);
            this.lblAuthKey.TabIndex = 2;
            this.lblAuthKey.Text = "Auth Key:";
            // 
            // tbAuthKey
            // 
            this.tbAuthKey.BackColor = System.Drawing.Color.White;
            this.tbAuthKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAuthKey.ForeColor = System.Drawing.Color.DimGray;
            this.tbAuthKey.Location = new System.Drawing.Point(313, 62);
            this.tbAuthKey.MaxLength = 100;
            this.tbAuthKey.Name = "tbAuthKey";
            this.tbAuthKey.Size = new System.Drawing.Size(329, 29);
            this.tbAuthKey.TabIndex = 1;
            this.tbAuthKey.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppName.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppName.Location = new System.Drawing.Point(6, 111);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(135, 20);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Имя приложения:";
            // 
            // tbAppName
            // 
            this.tbAppName.BackColor = System.Drawing.Color.White;
            this.tbAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAppName.ForeColor = System.Drawing.Color.DimGray;
            this.tbAppName.Location = new System.Drawing.Point(10, 134);
            this.tbAppName.MaxLength = 100;
            this.tbAppName.Name = "tbAppName";
            this.tbAppName.Size = new System.Drawing.Size(255, 29);
            this.tbAppName.TabIndex = 1;
            this.tbAppName.TabStop = false;
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppId.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppId.Location = new System.Drawing.Point(309, 111);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(57, 20);
            this.lblAppId.TabIndex = 2;
            this.lblAppId.Text = "App Id:";
            // 
            // tbAppId
            // 
            this.tbAppId.BackColor = System.Drawing.Color.White;
            this.tbAppId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAppId.ForeColor = System.Drawing.Color.DimGray;
            this.tbAppId.Location = new System.Drawing.Point(313, 134);
            this.tbAppId.MaxLength = 100;
            this.tbAppId.Name = "tbAppId";
            this.tbAppId.Size = new System.Drawing.Size(329, 29);
            this.tbAppId.TabIndex = 1;
            this.tbAppId.TabStop = false;
            // 
            // btnGetId
            // 
            this.btnGetId.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetId.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGetId.FlatAppearance.BorderSize = 0;
            this.btnGetId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnGetId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetId.ForeColor = System.Drawing.Color.White;
            this.btnGetId.Location = new System.Drawing.Point(648, 134);
            this.btnGetId.Name = "btnGetId";
            this.btnGetId.Size = new System.Drawing.Size(112, 29);
            this.btnGetId.TabIndex = 4;
            this.btnGetId.TabStop = false;
            this.btnGetId.Text = "Получить";
            this.btnGetId.UseVisualStyleBackColor = false;
            this.btnGetId.Click += new System.EventHandler(this.btnGetId_Click);
            // 
            // btnGenLicense
            // 
            this.btnGenLicense.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenLicense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenLicense.FlatAppearance.BorderSize = 0;
            this.btnGenLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnGenLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenLicense.ForeColor = System.Drawing.Color.White;
            this.btnGenLicense.Location = new System.Drawing.Point(216, 63);
            this.btnGenLicense.Name = "btnGenLicense";
            this.btnGenLicense.Size = new System.Drawing.Size(129, 29);
            this.btnGenLicense.TabIndex = 4;
            this.btnGenLicense.TabStop = false;
            this.btnGenLicense.Text = "Генерировать";
            this.btnGenLicense.UseVisualStyleBackColor = false;
            this.btnGenLicense.Click += new System.EventHandler(this.btnGenLicense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLicenseKey);
            this.groupBox1.Controls.Add(this.lblLicense);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.btnGenLicense);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генератор лицензии";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(6, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(10, 63);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker.TabIndex = 6;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLicense.ForeColor = System.Drawing.Color.DimGray;
            this.lblLicense.Location = new System.Drawing.Point(6, 118);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(81, 20);
            this.lblLicense.TabIndex = 7;
            this.lblLicense.Text = "Лицензия:";
            // 
            // tbLicenseKey
            // 
            this.tbLicenseKey.BackColor = System.Drawing.Color.White;
            this.tbLicenseKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLicenseKey.ForeColor = System.Drawing.Color.DimGray;
            this.tbLicenseKey.Location = new System.Drawing.Point(6, 141);
            this.tbLicenseKey.MaxLength = 500;
            this.tbLicenseKey.Name = "tbLicenseKey";
            this.tbLicenseKey.Size = new System.Drawing.Size(754, 29);
            this.tbLicenseKey.TabIndex = 8;
            this.tbLicenseKey.TabStop = false;
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxKey);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LicenseGenerator";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.groupBoxKey.ResumeLayout(false);
            this.groupBoxKey.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKey;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Button btnGetHost;
        private System.Windows.Forms.TextBox tbAuthKey;
        private System.Windows.Forms.Label lblAuthKey;
        private System.Windows.Forms.TextBox tbAppName;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.TextBox tbAppId;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.Button btnGetId;
        private System.Windows.Forms.Button btnGenLicense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbLicenseKey;
        private System.Windows.Forms.Label lblLicense;
    }
}

