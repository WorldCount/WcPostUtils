
namespace DwUtils.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabReceived = new System.Windows.Forms.TabPage();
            this.tabOrgsDoc = new System.Windows.Forms.TabPage();
            this.tabReceivedDoc = new System.Windows.Forms.TabPage();
            this.tabActiveUsers = new System.Windows.Forms.TabPage();
            this.menuBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(800, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(122, 24);
            this.exitMenuItem.Text = "Выход";
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 28);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 44);
            this.panelGeneral.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabReceived);
            this.tabControl.Controls.Add(this.tabReceivedDoc);
            this.tabControl.Controls.Add(this.tabOrgsDoc);
            this.tabControl.Controls.Add(this.tabActiveUsers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 72);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 356);
            this.tabControl.TabIndex = 3;
            // 
            // tabReceived
            // 
            this.tabReceived.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReceived.Location = new System.Drawing.Point(4, 29);
            this.tabReceived.Name = "tabReceived";
            this.tabReceived.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceived.Size = new System.Drawing.Size(792, 323);
            this.tabReceived.TabIndex = 0;
            this.tabReceived.Text = "На вручение";
            // 
            // tabOrgsDoc
            // 
            this.tabOrgsDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrgsDoc.Location = new System.Drawing.Point(4, 29);
            this.tabOrgsDoc.Name = "tabOrgsDoc";
            this.tabOrgsDoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrgsDoc.Size = new System.Drawing.Size(792, 323);
            this.tabOrgsDoc.TabIndex = 1;
            this.tabOrgsDoc.Text = "Накладные на организации";
            // 
            // tabReceivedDoc
            // 
            this.tabReceivedDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReceivedDoc.Location = new System.Drawing.Point(4, 29);
            this.tabReceivedDoc.Name = "tabReceivedDoc";
            this.tabReceivedDoc.Size = new System.Drawing.Size(792, 323);
            this.tabReceivedDoc.TabIndex = 2;
            this.tabReceivedDoc.Text = "Накладные на прибытие";
            // 
            // tabActiveUsers
            // 
            this.tabActiveUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabActiveUsers.Location = new System.Drawing.Point(4, 29);
            this.tabActiveUsers.Name = "tabActiveUsers";
            this.tabActiveUsers.Size = new System.Drawing.Size(792, 323);
            this.tabActiveUsers.TabIndex = 3;
            this.tabActiveUsers.Text = "Подключенные пользователи";
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "GeneralForm";
            this.Text = "DwUtils";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabReceived;
        private System.Windows.Forms.TabPage tabOrgsDoc;
        private System.Windows.Forms.TabPage tabReceivedDoc;
        private System.Windows.Forms.TabPage tabActiveUsers;
    }
}

