namespace OpenCloseDU
{
    partial class GenearlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenearlForm));
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelDB = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(12, 33);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(180, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть БД";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(12, 94);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть БД";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelDB
            // 
            this.labelDB.Location = new System.Drawing.Point(198, 33);
            this.labelDB.Name = "labelDB";
            this.labelDB.Size = new System.Drawing.Size(284, 40);
            this.labelDB.TabIndex = 2;
            this.labelDB.Text = "textDB";
            this.labelDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(201, 94);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(281, 40);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "textDB";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(302, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GenearlForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(494, 259);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(510, 300);
            this.MinimumSize = new System.Drawing.Size(510, 300);
            this.Name = "GenearlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenCloseDU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelDB;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnExit;
    }
}

