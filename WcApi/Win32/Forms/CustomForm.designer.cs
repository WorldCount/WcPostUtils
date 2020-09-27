namespace WcApi.Win32.Forms
{
    partial class CustomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.dragControl = new WcApi.Win32.Controls.DragControl();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnState);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Location = new System.Drawing.Point(2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(716, 44);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(678, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnState
            // 
            this.btnState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnState.BackColor = System.Drawing.Color.SeaGreen;
            this.btnState.FlatAppearance.BorderSize = 0;
            this.btnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnState.ForeColor = System.Drawing.Color.White;
            this.btnState.Image = ((System.Drawing.Image)(resources.GetObject("btnState.Image")));
            this.btnState.Location = new System.Drawing.Point(644, 8);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(28, 28);
            this.btnState.TabIndex = 0;
            this.btnState.TabStop = false;
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(610, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 28);
            this.btnMin.TabIndex = 0;
            this.btnMin.TabStop = false;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // dragControl
            // 
            this.dragControl.SelectControl = this.panelTop;
            // 
            // CustomForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Dis";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomForm_Paint);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelTop;
        private WcApi.Win32.Controls.DragControl dragControl;
    }
}

