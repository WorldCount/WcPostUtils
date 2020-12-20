namespace LK.Forms
{
    partial class LoginForm
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num4 = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelApp = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.timerError = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.LightGray;
            this.num1.Font = new System.Drawing.Font("Segoe UI", 48.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num1.Location = new System.Drawing.Point(135, 211);
            this.num1.MaxLength = 1;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(76, 93);
            this.num1.TabIndex = 1;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num1.UseSystemPasswordChar = true;
            this.num1.WordWrap = false;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            this.num1.Enter += new System.EventHandler(this.num1_Enter);
            this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.num1.Leave += new System.EventHandler(this.num1_Leave);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.LightGray;
            this.num2.Font = new System.Drawing.Font("Segoe UI", 48.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num2.Location = new System.Drawing.Point(220, 211);
            this.num2.MaxLength = 1;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(76, 93);
            this.num2.TabIndex = 2;
            this.num2.TabStop = false;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num2.UseSystemPasswordChar = true;
            this.num2.WordWrap = false;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            this.num2.Enter += new System.EventHandler(this.num2_Enter);
            this.num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.num2.Leave += new System.EventHandler(this.num2_Leave);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.LightGray;
            this.num3.Font = new System.Drawing.Font("Segoe UI", 48.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num3.Location = new System.Drawing.Point(305, 211);
            this.num3.MaxLength = 1;
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(76, 93);
            this.num3.TabIndex = 3;
            this.num3.TabStop = false;
            this.num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num3.UseSystemPasswordChar = true;
            this.num3.WordWrap = false;
            this.num3.TextChanged += new System.EventHandler(this.num3_TextChanged);
            this.num3.Enter += new System.EventHandler(this.num3_Enter);
            this.num3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.num3.Leave += new System.EventHandler(this.num3_Leave);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.LightGray;
            this.num4.Font = new System.Drawing.Font("Segoe UI", 48.22641F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num4.Location = new System.Drawing.Point(390, 211);
            this.num4.MaxLength = 1;
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(76, 93);
            this.num4.TabIndex = 4;
            this.num4.TabStop = false;
            this.num4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num4.UseSystemPasswordChar = true;
            this.num4.WordWrap = false;
            this.num4.TextChanged += new System.EventHandler(this.num4_TextChanged);
            this.num4.Enter += new System.EventHandler(this.num4_Enter);
            this.num4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.num4.Leave += new System.EventHandler(this.num4_Leave);
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(221, 176);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(158, 28);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Введите ПИН:";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelApp
            // 
            this.labelApp.BackColor = System.Drawing.Color.Teal;
            this.labelApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelApp.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelApp.ForeColor = System.Drawing.Color.White;
            this.labelApp.Location = new System.Drawing.Point(81, 11);
            this.labelApp.Name = "labelApp";
            this.labelApp.Size = new System.Drawing.Size(422, 59);
            this.labelApp.TabIndex = 7;
            this.labelApp.Text = "Личный кабинет";
            this.labelApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.Firebrick;
            this.labelError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(1, 340);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(598, 50);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "Неверный пин!";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerError
            // 
            this.timerError.Interval = 3000;
            this.timerError.Tick += new System.EventHandler(this.timerError_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::LK.Properties.Resources.white_delete_30;
            this.btnClose.Location = new System.Drawing.Point(544, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Teal;
            this.panelInfo.Controls.Add(this.labelApp);
            this.panelInfo.Location = new System.Drawing.Point(1, 82);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(598, 82);
            this.panelInfo.TabIndex = 9;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfo_Paint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartStat 4";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelApp;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Timer timerError;
        private System.Windows.Forms.Panel panelInfo;
    }
}