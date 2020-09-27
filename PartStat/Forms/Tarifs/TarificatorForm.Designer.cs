namespace PartStat.Forms.Tarifs
{
    partial class TarificatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarificatorForm));
            this.labelInfo = new System.Windows.Forms.Label();
            this.tbStartWeight = new System.Windows.Forms.TextBox();
            this.lblStartWeight = new System.Windows.Forms.Label();
            this.tbEndWeight = new System.Windows.Forms.TextBox();
            this.labelEndWeight = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.tbStepCost = new System.Windows.Forms.TextBox();
            this.labelStepCost = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(270, 30);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Тарификатор отправлений";
            // 
            // tbStartWeight
            // 
            this.tbStartWeight.BackColor = System.Drawing.Color.White;
            this.tbStartWeight.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStartWeight.ForeColor = System.Drawing.Color.DimGray;
            this.tbStartWeight.Location = new System.Drawing.Point(16, 73);
            this.tbStartWeight.MaxLength = 5;
            this.tbStartWeight.Name = "tbStartWeight";
            this.tbStartWeight.Size = new System.Drawing.Size(76, 29);
            this.tbStartWeight.TabIndex = 1;
            this.tbStartWeight.Enter += new System.EventHandler(this.tb_Enter);
            this.tbStartWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPressNumeric);
            // 
            // lblStartWeight
            // 
            this.lblStartWeight.AutoSize = true;
            this.lblStartWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartWeight.ForeColor = System.Drawing.Color.DimGray;
            this.lblStartWeight.Location = new System.Drawing.Point(12, 49);
            this.lblStartWeight.Name = "lblStartWeight";
            this.lblStartWeight.Size = new System.Drawing.Size(197, 21);
            this.lblStartWeight.TabIndex = 0;
            this.lblStartWeight.Text = "Минимальный вес, грамм:";
            // 
            // tbEndWeight
            // 
            this.tbEndWeight.BackColor = System.Drawing.Color.White;
            this.tbEndWeight.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEndWeight.ForeColor = System.Drawing.Color.DimGray;
            this.tbEndWeight.Location = new System.Drawing.Point(16, 139);
            this.tbEndWeight.MaxLength = 5;
            this.tbEndWeight.Name = "tbEndWeight";
            this.tbEndWeight.Size = new System.Drawing.Size(76, 29);
            this.tbEndWeight.TabIndex = 2;
            this.tbEndWeight.Enter += new System.EventHandler(this.tb_Enter);
            this.tbEndWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPressNumeric);
            // 
            // labelEndWeight
            // 
            this.labelEndWeight.AutoSize = true;
            this.labelEndWeight.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndWeight.ForeColor = System.Drawing.Color.DimGray;
            this.labelEndWeight.Location = new System.Drawing.Point(13, 115);
            this.labelEndWeight.Name = "labelEndWeight";
            this.labelEndWeight.Size = new System.Drawing.Size(202, 21);
            this.labelEndWeight.TabIndex = 0;
            this.labelEndWeight.Text = "Максимальный вес, грамм:";
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStep.ForeColor = System.Drawing.Color.DimGray;
            this.labelStep.Location = new System.Drawing.Point(13, 181);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(94, 21);
            this.labelStep.TabIndex = 0;
            this.labelStep.Text = "Шаг, грамм:";
            // 
            // tbStep
            // 
            this.tbStep.BackColor = System.Drawing.Color.White;
            this.tbStep.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStep.ForeColor = System.Drawing.Color.DimGray;
            this.tbStep.Location = new System.Drawing.Point(17, 205);
            this.tbStep.MaxLength = 5;
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(76, 29);
            this.tbStep.TabIndex = 3;
            this.tbStep.Enter += new System.EventHandler(this.tb_Enter);
            this.tbStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPressNumeric);
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.Color.White;
            this.tbCost.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCost.ForeColor = System.Drawing.Color.DimGray;
            this.tbCost.Location = new System.Drawing.Point(17, 271);
            this.tbCost.MaxLength = 5;
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(76, 29);
            this.tbCost.TabIndex = 4;
            this.tbCost.Enter += new System.EventHandler(this.tb_Enter);
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.ForeColor = System.Drawing.Color.DimGray;
            this.labelCost.Location = new System.Drawing.Point(13, 247);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(184, 21);
            this.labelCost.TabIndex = 0;
            this.labelCost.Text = "Начальная плата, рубли:";
            // 
            // tbStepCost
            // 
            this.tbStepCost.BackColor = System.Drawing.Color.White;
            this.tbStepCost.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStepCost.ForeColor = System.Drawing.Color.DimGray;
            this.tbStepCost.Location = new System.Drawing.Point(17, 337);
            this.tbStepCost.MaxLength = 5;
            this.tbStepCost.Name = "tbStepCost";
            this.tbStepCost.Size = new System.Drawing.Size(76, 29);
            this.tbStepCost.TabIndex = 5;
            this.tbStepCost.Enter += new System.EventHandler(this.tb_Enter);
            this.tbStepCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // labelStepCost
            // 
            this.labelStepCost.AutoSize = true;
            this.labelStepCost.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStepCost.ForeColor = System.Drawing.Color.DimGray;
            this.labelStepCost.Location = new System.Drawing.Point(13, 313);
            this.labelStepCost.Name = "labelStepCost";
            this.labelStepCost.Size = new System.Drawing.Size(155, 21);
            this.labelStepCost.TabIndex = 0;
            this.labelStepCost.Text = "Плата за шаг, рубли:";
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
            this.btnCancel.Location = new System.Drawing.Point(12, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 7;
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
            this.btnSave.Location = new System.Drawing.Point(265, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Добавить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TarificatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(394, 449);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbStepCost);
            this.Controls.Add(this.labelStepCost);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.tbEndWeight);
            this.Controls.Add(this.labelEndWeight);
            this.Controls.Add(this.tbStartWeight);
            this.Controls.Add(this.lblStartWeight);
            this.Controls.Add(this.labelInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(410, 490);
            this.Name = "TarificatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TarificatorForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TarificatorForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox tbStartWeight;
        private System.Windows.Forms.Label lblStartWeight;
        private System.Windows.Forms.TextBox tbEndWeight;
        private System.Windows.Forms.Label labelEndWeight;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox tbStepCost;
        private System.Windows.Forms.Label labelStepCost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}