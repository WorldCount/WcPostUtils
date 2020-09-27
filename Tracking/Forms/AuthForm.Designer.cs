namespace Tracking.Forms
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.gbAuth = new System.Windows.Forms.GroupBox();
            this.flagPassword = new System.Windows.Forms.Label();
            this.flagLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAuth
            // 
            this.gbAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAuth.Controls.Add(this.flagPassword);
            this.gbAuth.Controls.Add(this.flagLogin);
            this.gbAuth.Controls.Add(this.tbPassword);
            this.gbAuth.Controls.Add(this.tbLogin);
            this.gbAuth.Controls.Add(this.lblPassword);
            this.gbAuth.Controls.Add(this.lblLogin);
            this.gbAuth.Location = new System.Drawing.Point(12, 12);
            this.gbAuth.Name = "gbAuth";
            this.gbAuth.Size = new System.Drawing.Size(329, 163);
            this.gbAuth.TabIndex = 0;
            this.gbAuth.TabStop = false;
            this.gbAuth.Text = "Авторизация";
            // 
            // flagPassword
            // 
            this.flagPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.flagPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flagPassword.ForeColor = System.Drawing.Color.White;
            this.flagPassword.Location = new System.Drawing.Point(292, 120);
            this.flagPassword.Name = "flagPassword";
            this.flagPassword.Size = new System.Drawing.Size(27, 27);
            this.flagPassword.TabIndex = 0;
            this.flagPassword.Text = "RU";
            this.flagPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.flagPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.flag_Paint);
            // 
            // flagLogin
            // 
            this.flagLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.flagLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flagLogin.ForeColor = System.Drawing.Color.White;
            this.flagLogin.Location = new System.Drawing.Point(292, 57);
            this.flagLogin.Name = "flagLogin";
            this.flagLogin.Size = new System.Drawing.Size(27, 27);
            this.flagLogin.TabIndex = 0;
            this.flagLogin.Text = "RU";
            this.flagLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.flagLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.flag_Paint);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(6, 120);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(280, 27);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Location = new System.Drawing.Point(6, 57);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(280, 27);
            this.tbLogin.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 96);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 21);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 33);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 21);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логин";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(226, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 229);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbAuth);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(370, 270);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tracking: Auth";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.AuthForm_InputLanguageChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuthForm_KeyDown);
            this.gbAuth.ResumeLayout(false);
            this.gbAuth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAuth;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label flagPassword;
        private System.Windows.Forms.Label flagLogin;
    }
}