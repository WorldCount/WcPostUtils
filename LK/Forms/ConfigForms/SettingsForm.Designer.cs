namespace LK.Forms.ConfigForms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePay = new System.Windows.Forms.TabPage();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.labelStep = new System.Windows.Forms.Label();
            this.groupBoxPay = new System.Windows.Forms.GroupBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.tbNds = new System.Windows.Forms.TextBox();
            this.lblNds = new System.Windows.Forms.Label();
            this.tabPageMail = new System.Windows.Forms.TabPage();
            this.groupBoxMail = new System.Windows.Forms.GroupBox();
            this.tbMailEndWeight = new System.Windows.Forms.TextBox();
            this.labelMailEndWeight = new System.Windows.Forms.Label();
            this.tbMailStartWeight = new System.Windows.Forms.TextBox();
            this.labelMailStartWeight = new System.Windows.Forms.Label();
            this.tabPageParcel = new System.Windows.Forms.TabPage();
            this.groupBoxParcel = new System.Windows.Forms.GroupBox();
            this.tbParcelEndWeight = new System.Windows.Forms.TextBox();
            this.labelParcelEndWeight = new System.Windows.Forms.Label();
            this.tbParcelStartWeight = new System.Windows.Forms.TextBox();
            this.labelParcelStartWeight = new System.Windows.Forms.Label();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.groupBoxDebug = new System.Windows.Forms.GroupBox();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.labelDebug = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxExport = new System.Windows.Forms.GroupBox();
            this.btnExportDir = new System.Windows.Forms.Button();
            this.labelExportPath = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnSave = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnCancel = new Wc32Api.Widgets.Buttons.WcButton();
            this.tbExportPathNew = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPagePay.SuspendLayout();
            this.groupBoxPay.SuspendLayout();
            this.tabPageMail.SuspendLayout();
            this.groupBoxMail.SuspendLayout();
            this.tabPageParcel.SuspendLayout();
            this.groupBoxParcel.SuspendLayout();
            this.tabPageDebug.SuspendLayout();
            this.groupBoxDebug.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxExport.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePay);
            this.tabControl.Controls.Add(this.tabPageMail);
            this.tabControl.Controls.Add(this.tabPageParcel);
            this.tabControl.Controls.Add(this.tabPageDebug);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(494, 403);
            this.tabControl.TabIndex = 0;
            // 
            // tabPagePay
            // 
            this.tabPagePay.Controls.Add(this.tbStep);
            this.tabPagePay.Controls.Add(this.labelStep);
            this.tabPagePay.Controls.Add(this.groupBoxPay);
            this.tabPagePay.ImageIndex = 0;
            this.tabPagePay.Location = new System.Drawing.Point(4, 29);
            this.tabPagePay.Name = "tabPagePay";
            this.tabPagePay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePay.Size = new System.Drawing.Size(486, 370);
            this.tabPagePay.TabIndex = 0;
            this.tabPagePay.Text = "Плата";
            this.tabPagePay.UseVisualStyleBackColor = true;
            // 
            // tbStep
            // 
            this.tbStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbStep.BackColor = System.Drawing.Color.White;
            this.tbStep.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStep.ForeColor = System.Drawing.Color.DimGray;
            this.tbStep.Location = new System.Drawing.Point(18, 222);
            this.tbStep.MaxLength = 5;
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(76, 27);
            this.tbStep.TabIndex = 3;
            this.tbStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelStep
            // 
            this.labelStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStep.ForeColor = System.Drawing.Color.DimGray;
            this.labelStep.Location = new System.Drawing.Point(14, 199);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(263, 20);
            this.labelStep.TabIndex = 3;
            this.labelStep.Text = "Шаг заказных отправлений (грамм):";
            // 
            // groupBoxPay
            // 
            this.groupBoxPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPay.Controls.Add(this.tbValue);
            this.groupBoxPay.Controls.Add(this.labelValue);
            this.groupBoxPay.Controls.Add(this.tbNds);
            this.groupBoxPay.Controls.Add(this.lblNds);
            this.groupBoxPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPay.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxPay.Location = new System.Drawing.Point(8, 6);
            this.groupBoxPay.Name = "groupBoxPay";
            this.groupBoxPay.Size = new System.Drawing.Size(470, 174);
            this.groupBoxPay.TabIndex = 0;
            this.groupBoxPay.TabStop = false;
            this.groupBoxPay.Text = "Плата";
            // 
            // tbValue
            // 
            this.tbValue.BackColor = System.Drawing.Color.White;
            this.tbValue.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValue.ForeColor = System.Drawing.Color.DimGray;
            this.tbValue.Location = new System.Drawing.Point(10, 131);
            this.tbValue.MaxLength = 5;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(76, 27);
            this.tbValue.TabIndex = 2;
            this.tbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.ForeColor = System.Drawing.Color.DimGray;
            this.labelValue.Location = new System.Drawing.Point(6, 107);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(261, 20);
            this.labelValue.TabIndex = 0;
            this.labelValue.Text = "Сбор с ОЦ за 1 руб в коп. (без НДС):";
            // 
            // tbNds
            // 
            this.tbNds.BackColor = System.Drawing.Color.White;
            this.tbNds.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNds.ForeColor = System.Drawing.Color.DimGray;
            this.tbNds.Location = new System.Drawing.Point(10, 62);
            this.tbNds.MaxLength = 5;
            this.tbNds.Name = "tbNds";
            this.tbNds.Size = new System.Drawing.Size(76, 27);
            this.tbNds.TabIndex = 1;
            this.tbNds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // lblNds
            // 
            this.lblNds.AutoSize = true;
            this.lblNds.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNds.ForeColor = System.Drawing.Color.DimGray;
            this.lblNds.Location = new System.Drawing.Point(6, 38);
            this.lblNds.Name = "lblNds";
            this.lblNds.Size = new System.Drawing.Size(42, 20);
            this.lblNds.TabIndex = 0;
            this.lblNds.Text = "НДС:";
            // 
            // tabPageMail
            // 
            this.tabPageMail.Controls.Add(this.groupBoxMail);
            this.tabPageMail.ImageIndex = 1;
            this.tabPageMail.Location = new System.Drawing.Point(4, 22);
            this.tabPageMail.Name = "tabPageMail";
            this.tabPageMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMail.Size = new System.Drawing.Size(486, 377);
            this.tabPageMail.TabIndex = 1;
            this.tabPageMail.Text = "Письма";
            this.tabPageMail.UseVisualStyleBackColor = true;
            // 
            // groupBoxMail
            // 
            this.groupBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMail.Controls.Add(this.tbMailEndWeight);
            this.groupBoxMail.Controls.Add(this.labelMailEndWeight);
            this.groupBoxMail.Controls.Add(this.tbMailStartWeight);
            this.groupBoxMail.Controls.Add(this.labelMailStartWeight);
            this.groupBoxMail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMail.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxMail.Location = new System.Drawing.Point(8, 6);
            this.groupBoxMail.Name = "groupBoxMail";
            this.groupBoxMail.Size = new System.Drawing.Size(470, 216);
            this.groupBoxMail.TabIndex = 1;
            this.groupBoxMail.TabStop = false;
            this.groupBoxMail.Text = "Письма";
            // 
            // tbMailEndWeight
            // 
            this.tbMailEndWeight.BackColor = System.Drawing.Color.White;
            this.tbMailEndWeight.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMailEndWeight.ForeColor = System.Drawing.Color.DimGray;
            this.tbMailEndWeight.Location = new System.Drawing.Point(10, 131);
            this.tbMailEndWeight.MaxLength = 5;
            this.tbMailEndWeight.Name = "tbMailEndWeight";
            this.tbMailEndWeight.Size = new System.Drawing.Size(76, 27);
            this.tbMailEndWeight.TabIndex = 5;
            this.tbMailEndWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelMailEndWeight
            // 
            this.labelMailEndWeight.AutoSize = true;
            this.labelMailEndWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMailEndWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelMailEndWeight.Location = new System.Drawing.Point(6, 107);
            this.labelMailEndWeight.Name = "labelMailEndWeight";
            this.labelMailEndWeight.Size = new System.Drawing.Size(206, 20);
            this.labelMailEndWeight.TabIndex = 0;
            this.labelMailEndWeight.Text = "Максимальный вес (грамм):";
            // 
            // tbMailStartWeight
            // 
            this.tbMailStartWeight.BackColor = System.Drawing.Color.White;
            this.tbMailStartWeight.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMailStartWeight.ForeColor = System.Drawing.Color.DimGray;
            this.tbMailStartWeight.Location = new System.Drawing.Point(10, 62);
            this.tbMailStartWeight.MaxLength = 5;
            this.tbMailStartWeight.Name = "tbMailStartWeight";
            this.tbMailStartWeight.Size = new System.Drawing.Size(76, 27);
            this.tbMailStartWeight.TabIndex = 4;
            this.tbMailStartWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelMailStartWeight
            // 
            this.labelMailStartWeight.AutoSize = true;
            this.labelMailStartWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMailStartWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelMailStartWeight.Location = new System.Drawing.Point(6, 38);
            this.labelMailStartWeight.Name = "labelMailStartWeight";
            this.labelMailStartWeight.Size = new System.Drawing.Size(202, 20);
            this.labelMailStartWeight.TabIndex = 0;
            this.labelMailStartWeight.Text = "Минимальный вес (грамм):";
            // 
            // tabPageParcel
            // 
            this.tabPageParcel.Controls.Add(this.groupBoxParcel);
            this.tabPageParcel.ImageIndex = 2;
            this.tabPageParcel.Location = new System.Drawing.Point(4, 29);
            this.tabPageParcel.Name = "tabPageParcel";
            this.tabPageParcel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParcel.Size = new System.Drawing.Size(486, 370);
            this.tabPageParcel.TabIndex = 2;
            this.tabPageParcel.Text = "Бандероли";
            this.tabPageParcel.UseVisualStyleBackColor = true;
            // 
            // groupBoxParcel
            // 
            this.groupBoxParcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParcel.Controls.Add(this.tbParcelEndWeight);
            this.groupBoxParcel.Controls.Add(this.labelParcelEndWeight);
            this.groupBoxParcel.Controls.Add(this.tbParcelStartWeight);
            this.groupBoxParcel.Controls.Add(this.labelParcelStartWeight);
            this.groupBoxParcel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxParcel.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxParcel.Location = new System.Drawing.Point(8, 6);
            this.groupBoxParcel.Name = "groupBoxParcel";
            this.groupBoxParcel.Size = new System.Drawing.Size(472, 202);
            this.groupBoxParcel.TabIndex = 1;
            this.groupBoxParcel.TabStop = false;
            this.groupBoxParcel.Text = "Бандероли";
            // 
            // tbParcelEndWeight
            // 
            this.tbParcelEndWeight.BackColor = System.Drawing.Color.White;
            this.tbParcelEndWeight.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbParcelEndWeight.ForeColor = System.Drawing.Color.DimGray;
            this.tbParcelEndWeight.Location = new System.Drawing.Point(10, 131);
            this.tbParcelEndWeight.MaxLength = 5;
            this.tbParcelEndWeight.Name = "tbParcelEndWeight";
            this.tbParcelEndWeight.Size = new System.Drawing.Size(76, 27);
            this.tbParcelEndWeight.TabIndex = 7;
            this.tbParcelEndWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelParcelEndWeight
            // 
            this.labelParcelEndWeight.AutoSize = true;
            this.labelParcelEndWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParcelEndWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelParcelEndWeight.Location = new System.Drawing.Point(6, 107);
            this.labelParcelEndWeight.Name = "labelParcelEndWeight";
            this.labelParcelEndWeight.Size = new System.Drawing.Size(206, 20);
            this.labelParcelEndWeight.TabIndex = 0;
            this.labelParcelEndWeight.Text = "Максимальный вес (грамм):";
            // 
            // tbParcelStartWeight
            // 
            this.tbParcelStartWeight.BackColor = System.Drawing.Color.White;
            this.tbParcelStartWeight.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbParcelStartWeight.ForeColor = System.Drawing.Color.DimGray;
            this.tbParcelStartWeight.Location = new System.Drawing.Point(10, 62);
            this.tbParcelStartWeight.MaxLength = 5;
            this.tbParcelStartWeight.Name = "tbParcelStartWeight";
            this.tbParcelStartWeight.Size = new System.Drawing.Size(76, 27);
            this.tbParcelStartWeight.TabIndex = 6;
            this.tbParcelStartWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelParcelStartWeight
            // 
            this.labelParcelStartWeight.AutoSize = true;
            this.labelParcelStartWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParcelStartWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelParcelStartWeight.Location = new System.Drawing.Point(6, 38);
            this.labelParcelStartWeight.Name = "labelParcelStartWeight";
            this.labelParcelStartWeight.Size = new System.Drawing.Size(202, 20);
            this.labelParcelStartWeight.TabIndex = 0;
            this.labelParcelStartWeight.Text = "Минимальный вес (грамм):";
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.groupBoxDebug);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 29);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebug.Size = new System.Drawing.Size(486, 370);
            this.tabPageDebug.TabIndex = 3;
            this.tabPageDebug.Text = "Отладка";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // groupBoxDebug
            // 
            this.groupBoxDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDebug.Controls.Add(this.checkBoxLog);
            this.groupBoxDebug.Controls.Add(this.labelDebug);
            this.groupBoxDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDebug.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxDebug.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDebug.Name = "groupBoxDebug";
            this.groupBoxDebug.Size = new System.Drawing.Size(472, 209);
            this.groupBoxDebug.TabIndex = 2;
            this.groupBoxDebug.TabStop = false;
            this.groupBoxDebug.Text = "Отладка";
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLog.Location = new System.Drawing.Point(12, 62);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(105, 25);
            this.checkBoxLog.TabIndex = 1;
            this.checkBoxLog.Text = "Вести логи";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDebug.ForeColor = System.Drawing.Color.DimGray;
            this.labelDebug.Location = new System.Drawing.Point(6, 38);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(172, 20);
            this.labelDebug.TabIndex = 0;
            this.labelDebug.Text = "Включить логирование";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxExport);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(486, 370);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Экспорт";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxExport
            // 
            this.groupBoxExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExport.Controls.Add(this.tbExportPathNew);
            this.groupBoxExport.Controls.Add(this.btnExportDir);
            this.groupBoxExport.Controls.Add(this.labelExportPath);
            this.groupBoxExport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxExport.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxExport.Location = new System.Drawing.Point(8, 6);
            this.groupBoxExport.Name = "groupBoxExport";
            this.groupBoxExport.Size = new System.Drawing.Size(470, 128);
            this.groupBoxExport.TabIndex = 2;
            this.groupBoxExport.TabStop = false;
            this.groupBoxExport.Text = "Выгрузка файла";
            // 
            // btnExportDir
            // 
            this.btnExportDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportDir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExportDir.FlatAppearance.BorderSize = 0;
            this.btnExportDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnExportDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportDir.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportDir.ForeColor = System.Drawing.Color.White;
            this.btnExportDir.Image = global::LK.Properties.Resources.folder_3_24;
            this.btnExportDir.Location = new System.Drawing.Point(424, 53);
            this.btnExportDir.Name = "btnExportDir";
            this.btnExportDir.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExportDir.Size = new System.Drawing.Size(40, 40);
            this.btnExportDir.TabIndex = 9;
            this.btnExportDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportDir.UseVisualStyleBackColor = false;
            this.btnExportDir.Click += new System.EventHandler(this.btnExportDir_Click);
            // 
            // labelExportPath
            // 
            this.labelExportPath.AutoSize = true;
            this.labelExportPath.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExportPath.ForeColor = System.Drawing.Color.DimGray;
            this.labelExportPath.Location = new System.Drawing.Point(6, 38);
            this.labelExportPath.Name = "labelExportPath";
            this.labelExportPath.Size = new System.Drawing.Size(182, 20);
            this.labelExportPath.TabIndex = 0;
            this.labelExportPath.Text = "Выгружать файл в папку:";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnSave);
            this.panelButton.Controls.Add(this.btnCancel);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 403);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(494, 68);
            this.panelButton.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.BorderRadius = 4F;
            this.btnSave.BorderSize = 0;
            this.btnSave.DisableBackgroundColor = System.Drawing.Color.DimGray;
            this.btnSave.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::LK.Properties.Resources.save_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(362, 10);
            this.btnSave.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnSave.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSave.Size = new System.Drawing.Size(120, 46);
            this.btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 4F;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.DisableBackgroundColor = System.Drawing.Color.DimGray;
            this.btnCancel.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::LK.Properties.Resources.close_window_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(236, 10);
            this.btnCancel.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnCancel.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(120, 46);
            this.btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbExportPathNew
            // 
            this.tbExportPathNew.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbExportPathNew.ForeColor = System.Drawing.Color.DimGray;
            this.tbExportPathNew.Location = new System.Drawing.Point(10, 61);
            this.tbExportPathNew.Name = "tbExportPathNew";
            this.tbExportPathNew.Size = new System.Drawing.Size(408, 26);
            this.tbExportPathNew.TabIndex = 10;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelButton);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(510, 510);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.tabPagePay.ResumeLayout(false);
            this.tabPagePay.PerformLayout();
            this.groupBoxPay.ResumeLayout(false);
            this.groupBoxPay.PerformLayout();
            this.tabPageMail.ResumeLayout(false);
            this.groupBoxMail.ResumeLayout(false);
            this.groupBoxMail.PerformLayout();
            this.tabPageParcel.ResumeLayout(false);
            this.groupBoxParcel.ResumeLayout(false);
            this.groupBoxParcel.PerformLayout();
            this.tabPageDebug.ResumeLayout(false);
            this.groupBoxDebug.ResumeLayout(false);
            this.groupBoxDebug.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBoxExport.ResumeLayout(false);
            this.groupBoxExport.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePay;
        private System.Windows.Forms.TabPage tabPageMail;
        private System.Windows.Forms.Panel panelButton;
        private Wc32Api.Widgets.Buttons.WcButton btnSave;
        private Wc32Api.Widgets.Buttons.WcButton btnCancel;
        private System.Windows.Forms.GroupBox groupBoxMail;
        private System.Windows.Forms.TextBox tbMailEndWeight;
        private System.Windows.Forms.Label labelMailEndWeight;
        private System.Windows.Forms.TextBox tbMailStartWeight;
        private System.Windows.Forms.Label labelMailStartWeight;
        private System.Windows.Forms.TabPage tabPageParcel;
        private System.Windows.Forms.GroupBox groupBoxParcel;
        private System.Windows.Forms.TextBox tbParcelEndWeight;
        private System.Windows.Forms.Label labelParcelEndWeight;
        private System.Windows.Forms.TextBox tbParcelStartWeight;
        private System.Windows.Forms.Label labelParcelStartWeight;
        private System.Windows.Forms.GroupBox groupBoxPay;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox tbNds;
        private System.Windows.Forms.Label lblNds;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.GroupBox groupBoxDebug;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxExport;
        private System.Windows.Forms.Label labelExportPath;
        private System.Windows.Forms.Button btnExportDir;
        private System.Windows.Forms.TextBox tbExportPathNew;
    }
}