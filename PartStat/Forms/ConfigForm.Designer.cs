namespace PartStat.Forms
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.groupBoxPay = new System.Windows.Forms.GroupBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.tbNds = new System.Windows.Forms.TextBox();
            this.lblNds = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.labelStep = new System.Windows.Forms.Label();
            this.tabControlConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxMail = new System.Windows.Forms.GroupBox();
            this.tbMailEndWeight = new System.Windows.Forms.TextBox();
            this.labelMailEndWeight = new System.Windows.Forms.Label();
            this.tbMailStartWeight = new System.Windows.Forms.TextBox();
            this.labelMailStartWeight = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxParcel = new System.Windows.Forms.GroupBox();
            this.tbParcelEndWeight = new System.Windows.Forms.TextBox();
            this.labelParcelEndWeight = new System.Windows.Forms.Label();
            this.tbParcelStartWeight = new System.Windows.Forms.TextBox();
            this.labelParcelStartWeight = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxPay.SuspendLayout();
            this.tabControlConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxMail.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxParcel.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.groupBoxPay.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPay.Name = "groupBoxPay";
            this.groupBoxPay.Size = new System.Drawing.Size(400, 235);
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
            this.tbValue.Size = new System.Drawing.Size(76, 29);
            this.tbValue.TabIndex = 0;
            this.tbValue.TabStop = false;
            this.tbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.ForeColor = System.Drawing.Color.DimGray;
            this.labelValue.Location = new System.Drawing.Point(6, 107);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(270, 21);
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
            this.tbNds.Size = new System.Drawing.Size(76, 29);
            this.tbNds.TabIndex = 0;
            this.tbNds.TabStop = false;
            this.tbNds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // lblNds
            // 
            this.lblNds.AutoSize = true;
            this.lblNds.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNds.ForeColor = System.Drawing.Color.DimGray;
            this.lblNds.Location = new System.Drawing.Point(6, 38);
            this.lblNds.Name = "lblNds";
            this.lblNds.Size = new System.Drawing.Size(45, 21);
            this.lblNds.TabIndex = 0;
            this.lblNds.Text = "НДС:";
            // 
            // tbStep
            // 
            this.tbStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbStep.BackColor = System.Drawing.Color.White;
            this.tbStep.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStep.ForeColor = System.Drawing.Color.DimGray;
            this.tbStep.Location = new System.Drawing.Point(16, 303);
            this.tbStep.MaxLength = 5;
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(76, 29);
            this.tbStep.TabIndex = 0;
            this.tbStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelStep
            // 
            this.labelStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStep.ForeColor = System.Drawing.Color.DimGray;
            this.labelStep.Location = new System.Drawing.Point(12, 274);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(267, 21);
            this.labelStep.TabIndex = 0;
            this.labelStep.Text = "Шаг заказных отправлений (грамм):";
            // 
            // tabControlConfig
            // 
            this.tabControlConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlConfig.Controls.Add(this.tabPage1);
            this.tabControlConfig.Controls.Add(this.tabPage2);
            this.tabControlConfig.Controls.Add(this.tabPage3);
            this.tabControlConfig.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlConfig.Location = new System.Drawing.Point(2, 2);
            this.tabControlConfig.Name = "tabControlConfig";
            this.tabControlConfig.SelectedIndex = 0;
            this.tabControlConfig.Size = new System.Drawing.Size(421, 406);
            this.tabControlConfig.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbStep);
            this.tabPage1.Controls.Add(this.groupBoxPay);
            this.tabPage1.Controls.Add(this.labelStep);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Плата";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxMail);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Письма";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.groupBoxMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.groupBoxMail.Location = new System.Drawing.Point(6, 6);
            this.groupBoxMail.Name = "groupBoxMail";
            this.groupBoxMail.Size = new System.Drawing.Size(400, 235);
            this.groupBoxMail.TabIndex = 0;
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
            this.tbMailEndWeight.Size = new System.Drawing.Size(76, 29);
            this.tbMailEndWeight.TabIndex = 0;
            this.tbMailEndWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelMailEndWeight
            // 
            this.labelMailEndWeight.AutoSize = true;
            this.labelMailEndWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMailEndWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelMailEndWeight.Location = new System.Drawing.Point(6, 107);
            this.labelMailEndWeight.Name = "labelMailEndWeight";
            this.labelMailEndWeight.Size = new System.Drawing.Size(209, 21);
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
            this.tbMailStartWeight.Size = new System.Drawing.Size(76, 29);
            this.tbMailStartWeight.TabIndex = 0;
            this.tbMailStartWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelMailStartWeight
            // 
            this.labelMailStartWeight.AutoSize = true;
            this.labelMailStartWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMailStartWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelMailStartWeight.Location = new System.Drawing.Point(6, 38);
            this.labelMailStartWeight.Name = "labelMailStartWeight";
            this.labelMailStartWeight.Size = new System.Drawing.Size(204, 21);
            this.labelMailStartWeight.TabIndex = 0;
            this.labelMailStartWeight.Text = "Минимальный вес (грамм):";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxParcel);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(413, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Бандероли";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.groupBoxParcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.groupBoxParcel.Location = new System.Drawing.Point(6, 6);
            this.groupBoxParcel.Name = "groupBoxParcel";
            this.groupBoxParcel.Size = new System.Drawing.Size(400, 235);
            this.groupBoxParcel.TabIndex = 0;
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
            this.tbParcelEndWeight.Size = new System.Drawing.Size(76, 29);
            this.tbParcelEndWeight.TabIndex = 0;
            this.tbParcelEndWeight.TabStop = false;
            // 
            // labelParcelEndWeight
            // 
            this.labelParcelEndWeight.AutoSize = true;
            this.labelParcelEndWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParcelEndWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelParcelEndWeight.Location = new System.Drawing.Point(6, 107);
            this.labelParcelEndWeight.Name = "labelParcelEndWeight";
            this.labelParcelEndWeight.Size = new System.Drawing.Size(209, 21);
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
            this.tbParcelStartWeight.Size = new System.Drawing.Size(76, 29);
            this.tbParcelStartWeight.TabIndex = 0;
            this.tbParcelStartWeight.TabStop = false;
            // 
            // labelParcelStartWeight
            // 
            this.labelParcelStartWeight.AutoSize = true;
            this.labelParcelStartWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParcelStartWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelParcelStartWeight.Location = new System.Drawing.Point(6, 38);
            this.labelParcelStartWeight.Name = "labelParcelStartWeight";
            this.labelParcelStartWeight.Size = new System.Drawing.Size(204, 21);
            this.labelParcelStartWeight.TabIndex = 0;
            this.labelParcelStartWeight.Text = "Минимальный вес (грамм):";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::PartStat.Properties.Resources.white_cancel_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PartStat.Properties.Resources.white_ok_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(292, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(424, 479);
            this.Controls.Add(this.tabControlConfig);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(440, 520);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigForm_KeyDown);
            this.groupBoxPay.ResumeLayout(false);
            this.groupBoxPay.PerformLayout();
            this.tabControlConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxMail.ResumeLayout(false);
            this.groupBoxMail.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBoxParcel.ResumeLayout(false);
            this.groupBoxParcel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPay;
        private System.Windows.Forms.Label lblNds;
        private System.Windows.Forms.TextBox tbNds;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.TabControl tabControlConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxMail;
        private System.Windows.Forms.TextBox tbMailEndWeight;
        private System.Windows.Forms.Label labelMailEndWeight;
        private System.Windows.Forms.TextBox tbMailStartWeight;
        private System.Windows.Forms.Label labelMailStartWeight;
        private System.Windows.Forms.GroupBox groupBoxParcel;
        private System.Windows.Forms.TextBox tbParcelEndWeight;
        private System.Windows.Forms.Label labelParcelEndWeight;
        private System.Windows.Forms.TextBox tbParcelStartWeight;
        private System.Windows.Forms.Label labelParcelStartWeight;
    }
}