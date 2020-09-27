namespace TelegramBot
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.textBoxKey.Location = new System.Drawing.Point(16, 33);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(411, 27);
            this.textBoxKey.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 66);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(176, 45);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Подключиться";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(86, 21);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Ключ бота";
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(439, 206);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxKey);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelInfo;
    }
}

