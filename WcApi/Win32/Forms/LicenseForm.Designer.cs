namespace WcApi.Win32.Forms
{
    partial class LicenseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInfoTo = new System.Windows.Forms.Label();
            this.labelInfoToday = new System.Windows.Forms.Label();
            this.labelLicenseTo = new System.Windows.Forms.Label();
            this.labelToday = new System.Windows.Forms.Label();
            this.labelInfoId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelInfoLicenseKey = new System.Windows.Forms.Label();
            this.textBoxLicenseKey = new System.Windows.Forms.TextBox();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelInfoMail = new System.Windows.Forms.Label();
            this.linkLabelMail = new System.Windows.Forms.LinkLabel();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonMail = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTitle.Location = new System.Drawing.Point(146, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(73, 40);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Упс!";
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(146, 58);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(584, 167);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Упс! Что-то пошло не так!\r\nСкорее всего, ваша лицензия истекла и вы пользуетесь н" +
    "елицензионной копией программы. \r\n\r\n";
            // 
            // labelInfoTo
            // 
            this.labelInfoTo.AutoSize = true;
            this.labelInfoTo.Location = new System.Drawing.Point(45, 240);
            this.labelInfoTo.Name = "labelInfoTo";
            this.labelInfoTo.Size = new System.Drawing.Size(237, 21);
            this.labelInfoTo.TabIndex = 3;
            this.labelInfoTo.Text = "Действие текущей лизензии до:";
            // 
            // labelInfoToday
            // 
            this.labelInfoToday.AutoSize = true;
            this.labelInfoToday.Location = new System.Drawing.Point(172, 270);
            this.labelInfoToday.Name = "labelInfoToday";
            this.labelInfoToday.Size = new System.Drawing.Size(110, 21);
            this.labelInfoToday.TabIndex = 4;
            this.labelInfoToday.Text = "Текущая дата:";
            // 
            // labelLicenseTo
            // 
            this.labelLicenseTo.AutoSize = true;
            this.labelLicenseTo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLicenseTo.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLicenseTo.Location = new System.Drawing.Point(309, 240);
            this.labelLicenseTo.Name = "labelLicenseTo";
            this.labelLicenseTo.Size = new System.Drawing.Size(97, 21);
            this.labelLicenseTo.TabIndex = 5;
            this.labelLicenseTo.Text = "Нет данных";
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToday.ForeColor = System.Drawing.Color.Firebrick;
            this.labelToday.Location = new System.Drawing.Point(309, 270);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(72, 21);
            this.labelToday.TabIndex = 6;
            this.labelToday.Text = "Сегодня";
            // 
            // labelInfoId
            // 
            this.labelInfoId.AutoSize = true;
            this.labelInfoId.Location = new System.Drawing.Point(96, 353);
            this.labelInfoId.Name = "labelInfoId";
            this.labelInfoId.Size = new System.Drawing.Size(62, 21);
            this.labelInfoId.TabIndex = 7;
            this.labelInfoId.Text = "Ваш ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(164, 350);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(399, 27);
            this.textBoxId.TabIndex = 8;
            // 
            // labelInfoLicenseKey
            // 
            this.labelInfoLicenseKey.AutoSize = true;
            this.labelInfoLicenseKey.Location = new System.Drawing.Point(33, 402);
            this.labelInfoLicenseKey.Name = "labelInfoLicenseKey";
            this.labelInfoLicenseKey.Size = new System.Drawing.Size(125, 21);
            this.labelInfoLicenseKey.TabIndex = 9;
            this.labelInfoLicenseKey.Text = "Ключ лицензии:";
            // 
            // textBoxLicenseKey
            // 
            this.textBoxLicenseKey.Location = new System.Drawing.Point(164, 399);
            this.textBoxLicenseKey.Name = "textBoxLicenseKey";
            this.textBoxLicenseKey.Size = new System.Drawing.Size(399, 27);
            this.textBoxLicenseKey.TabIndex = 10;
            // 
            // buttonActivate
            // 
            this.buttonActivate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonActivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.buttonActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonActivate.Location = new System.Drawing.Point(569, 392);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(161, 40);
            this.buttonActivate.TabIndex = 12;
            this.buttonActivate.Text = "Активировать";
            this.buttonActivate.UseVisualStyleBackColor = false;
            this.buttonActivate.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClosed += new System.EventHandler(this.notifyIcon_BalloonTipClosed);
            // 
            // labelInfoMail
            // 
            this.labelInfoMail.AutoSize = true;
            this.labelInfoMail.Location = new System.Drawing.Point(88, 316);
            this.labelInfoMail.Name = "labelInfoMail";
            this.labelInfoMail.Size = new System.Drawing.Size(462, 21);
            this.labelInfoMail.TabIndex = 14;
            this.labelInfoMail.Text = "Чтобы получить ключ, отправьте указанный ниже ID на почту:";
            // 
            // linkLabelMail
            // 
            this.linkLabelMail.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabelMail.AutoSize = true;
            this.linkLabelMail.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabelMail.Location = new System.Drawing.Point(556, 316);
            this.linkLabelMail.Name = "linkLabelMail";
            this.linkLabelMail.Size = new System.Drawing.Size(174, 21);
            this.linkLabelMail.TabIndex = 15;
            this.linkLabelMail.TabStop = true;
            this.linkLabelMail.Text = "world.count@yandex.ru";
            this.linkLabelMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMail_LinkClicked);
            // 
            // buttonCommit
            // 
            this.buttonCommit.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCommit.FlatAppearance.BorderSize = 0;
            this.buttonCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.buttonCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommit.ForeColor = System.Drawing.Color.White;
            this.buttonCommit.Location = new System.Drawing.Point(317, 442);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(132, 40);
            this.buttonCommit.TabIndex = 16;
            this.buttonCommit.Text = "Понятно";
            this.buttonCommit.UseVisualStyleBackColor = false;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // buttonMail
            // 
            this.buttonMail.BackColor = System.Drawing.Color.SlateGray;
            this.buttonMail.FlatAppearance.BorderSize = 0;
            this.buttonMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.buttonMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMail.Image = ((System.Drawing.Image)(resources.GetObject("buttonMail.Image")));
            this.buttonMail.Location = new System.Drawing.Point(613, 344);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(38, 38);
            this.buttonMail.TabIndex = 13;
            this.buttonMail.UseVisualStyleBackColor = false;
            this.buttonMail.Click += new System.EventHandler(this.buttonMail_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.SlateGray;
            this.buttonCopy.FlatAppearance.BorderSize = 0;
            this.buttonCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopy.Image")));
            this.buttonCopy.Location = new System.Drawing.Point(569, 344);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(38, 38);
            this.buttonCopy.TabIndex = 13;
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::WcApi.Properties.Resources.cat;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 128);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(767, 491);
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.linkLabelMail);
            this.Controls.Add(this.labelInfoMail);
            this.Controls.Add(this.buttonMail);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonActivate);
            this.Controls.Add(this.textBoxLicenseKey);
            this.Controls.Add(this.labelInfoLicenseKey);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelInfoId);
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.labelLicenseTo);
            this.Controls.Add(this.labelInfoToday);
            this.Controls.Add(this.labelInfoTo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(783, 532);
            this.MinimumSize = new System.Drawing.Size(783, 532);
            this.Name = "LicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mail: License";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LicenseForm_FormClosing);
            this.Load += new System.EventHandler(this.LicenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelInfoTo;
        private System.Windows.Forms.Label labelInfoToday;
        private System.Windows.Forms.Label labelLicenseTo;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Label labelInfoId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelInfoLicenseKey;
        private System.Windows.Forms.TextBox textBoxLicenseKey;
        private System.Windows.Forms.Button buttonActivate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonMail;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label labelInfoMail;
        private System.Windows.Forms.LinkLabel linkLabelMail;
        private System.Windows.Forms.Button buttonCommit;
    }
}