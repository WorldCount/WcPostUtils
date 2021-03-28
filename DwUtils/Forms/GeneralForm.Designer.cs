
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabReceived = new System.Windows.Forms.TabPage();
            this.tabReceivedDoc = new System.Windows.Forms.TabPage();
            this.tabOrgsDoc = new System.Windows.Forms.TabPage();
            this.tabActiveUsers = new System.Windows.Forms.TabPage();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelInfoLicense = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.connectWidget1 = new DwUtils.Core.Libs.Widgets.ConnectWidget();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.tabReceived.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.connectsMenuItem,
            this.settingsMenuItem,
            this.infosMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(800, 40);
            this.menuBar.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Image = global::DwUtils.Properties.Resources.File;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(81, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::DwUtils.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(130, 30);
            this.exitMenuItem.Text = "Выход";
            // 
            // connectsMenuItem
            // 
            this.connectsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authMenuItem,
            this.databaseToolStripMenuItem});
            this.connectsMenuItem.Image = global::DwUtils.Properties.Resources.Server;
            this.connectsMenuItem.Name = "connectsMenuItem";
            this.connectsMenuItem.Size = new System.Drawing.Size(142, 36);
            this.connectsMenuItem.Text = "Подключения";
            // 
            // authMenuItem
            // 
            this.authMenuItem.Image = global::DwUtils.Properties.Resources.Suit;
            this.authMenuItem.Name = "authMenuItem";
            this.authMenuItem.Size = new System.Drawing.Size(263, 30);
            this.authMenuItem.Text = "Авторизация на Почта.Ру";
            this.authMenuItem.Click += new System.EventHandler(this.authMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Image = global::DwUtils.Properties.Resources.Lan_Socket;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.databaseToolStripMenuItem.Text = "Подключение к БД";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Image = global::DwUtils.Properties.Resources.Button_Settings;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(120, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.Image = global::DwUtils.Properties.Resources._4_Leaf_Clover;
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(84, 36);
            this.infosMenuItem.Text = "Инфо";
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(671, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.Gray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(114, 17);
            this.statusAuthor.Text = "WorldCount, 2020 ©";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 44);
            this.panelGeneral.TabIndex = 2;
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabReceived);
            this.tabsControl.Controls.Add(this.tabReceivedDoc);
            this.tabsControl.Controls.Add(this.tabOrgsDoc);
            this.tabsControl.Controls.Add(this.tabActiveUsers);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabsControl.Location = new System.Drawing.Point(0, 84);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(800, 344);
            this.tabsControl.TabIndex = 3;
            // 
            // tabReceived
            // 
            this.tabReceived.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReceived.Controls.Add(this.connectWidget1);
            this.tabReceived.Location = new System.Drawing.Point(4, 29);
            this.tabReceived.Name = "tabReceived";
            this.tabReceived.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceived.Size = new System.Drawing.Size(792, 311);
            this.tabReceived.TabIndex = 0;
            this.tabReceived.Text = "На вручение";
            // 
            // tabReceivedDoc
            // 
            this.tabReceivedDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReceivedDoc.Location = new System.Drawing.Point(4, 29);
            this.tabReceivedDoc.Name = "tabReceivedDoc";
            this.tabReceivedDoc.Size = new System.Drawing.Size(792, 311);
            this.tabReceivedDoc.TabIndex = 2;
            this.tabReceivedDoc.Text = "Накладные на прибытие";
            // 
            // tabOrgsDoc
            // 
            this.tabOrgsDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrgsDoc.Location = new System.Drawing.Point(4, 29);
            this.tabOrgsDoc.Name = "tabOrgsDoc";
            this.tabOrgsDoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrgsDoc.Size = new System.Drawing.Size(792, 311);
            this.tabOrgsDoc.TabIndex = 1;
            this.tabOrgsDoc.Text = "Накладные на организации";
            // 
            // tabActiveUsers
            // 
            this.tabActiveUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabActiveUsers.Location = new System.Drawing.Point(4, 29);
            this.tabActiveUsers.Name = "tabActiveUsers";
            this.tabActiveUsers.Size = new System.Drawing.Size(792, 311);
            this.tabActiveUsers.TabIndex = 3;
            this.tabActiveUsers.Text = "Подключенные пользователи";
            // 
            // labelLicense
            // 
            this.labelLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLicense.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLicense.Location = new System.Drawing.Point(704, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(96, 40);
            this.labelLicense.TabIndex = 12;
            this.labelLicense.Text = "01.01.0001";
            this.labelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoLicense
            // 
            this.labelInfoLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoLicense.Location = new System.Drawing.Point(585, 0);
            this.labelInfoLicense.Name = "labelInfoLicense";
            this.labelInfoLicense.Size = new System.Drawing.Size(113, 40);
            this.labelInfoLicense.TabIndex = 11;
            this.labelInfoLicense.Text = "Лицензия до:";
            this.labelInfoLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // connectWidget1
            // 
            this.connectWidget1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.connectWidget1.BorderColor = System.Drawing.Color.Gray;
            this.connectWidget1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.connectWidget1.BorderWidth = 1;
            this.connectWidget1.ErrorStatusColor = System.Drawing.Color.Firebrick;
            this.connectWidget1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectWidget1.Location = new System.Drawing.Point(368, 95);
            this.connectWidget1.Message = "Сообщение";
            this.connectWidget1.MessageColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.connectWidget1.Name = "connectWidget1";
            this.connectWidget1.Size = new System.Drawing.Size(246, 41);
            this.connectWidget1.StatusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(178)))), ((int)(((byte)(189)))));
            this.connectWidget1.StatusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.connectWidget1.StatusBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.connectWidget1.StatusBorderWidth = 1;
            this.connectWidget1.SuccessStatusColor = System.Drawing.Color.SeaGreen;
            this.connectWidget1.TabIndex = 0;
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelInfoLicense);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DwUtils";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabsControl.ResumeLayout(false);
            this.tabReceived.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabReceived;
        private System.Windows.Forms.TabPage tabOrgsDoc;
        private System.Windows.Forms.TabPage tabReceivedDoc;
        private System.Windows.Forms.TabPage tabActiveUsers;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Label labelInfoLicense;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.ToolStripMenuItem connectsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private Core.Libs.Widgets.ConnectWidget connectWidget1;
    }
}

