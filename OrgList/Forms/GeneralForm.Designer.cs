namespace OrgList.Forms
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
            this.components = new System.ComponentModel.Container();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.panelList = new System.Windows.Forms.Panel();
            this.tabAddress = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.tabAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.status.Location = new System.Drawing.Point(0, 373);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(783, 24);
            this.status.TabIndex = 0;
            this.status.Text = "Статус";
            // 
            // statusText
            // 
            this.statusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(596, 19);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.ForeColor = System.Drawing.Color.DarkGray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(138, 19);
            this.statusAuthor.Text = "WorldCount, 2019 ©";
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.configMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(783, 29);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Меню";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(59, 25);
            this.fileMenuItem.Text = "Файл";
            // 
            // configMenuItem
            // 
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(99, 25);
            this.configMenuItem.Text = "Настройки";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabList);
            this.tabControl.Controls.Add(this.tabAddress);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(120, 35);
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(783, 344);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 3;
            // 
            // tabList
            // 
            this.tabList.BackColor = System.Drawing.Color.White;
            this.tabList.Controls.Add(this.dataGridViewList);
            this.tabList.Controls.Add(this.panelList);
            this.tabList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tabList.Location = new System.Drawing.Point(4, 39);
            this.tabList.Margin = new System.Windows.Forms.Padding(10);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(10);
            this.tabList.Size = new System.Drawing.Size(775, 301);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "Списки";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(775, 253);
            this.dataGridViewList.TabIndex = 1;
            // 
            // panelList
            // 
            this.panelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelList.BackColor = System.Drawing.Color.DimGray;
            this.panelList.Location = new System.Drawing.Point(0, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(778, 48);
            this.panelList.TabIndex = 0;
            // 
            // tabAddress
            // 
            this.tabAddress.BackColor = System.Drawing.Color.White;
            this.tabAddress.Controls.Add(this.panel1);
            this.tabAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tabAddress.Location = new System.Drawing.Point(4, 39);
            this.tabAddress.Name = "tabAddress";
            this.tabAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddress.Size = new System.Drawing.Size(775, 299);
            this.tabAddress.TabIndex = 1;
            this.tabAddress.Text = "Адреса";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 48);
            this.panel1.TabIndex = 1;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 397);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.tabAddress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabAddress;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewList;
    }
}

