namespace PartStat.Forms
{
    partial class ColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorForm));
            this.groupBoxWarn = new System.Windows.Forms.GroupBox();
            this.textBoxWarnExample = new System.Windows.Forms.TextBox();
            this.labelWarnFore = new System.Windows.Forms.Label();
            this.labelWarnBack = new System.Windows.Forms.Label();
            this.pictureBoxWarnFore = new System.Windows.Forms.PictureBox();
            this.pictureBoxWarnBack = new System.Windows.Forms.PictureBox();
            this.groupBoxError = new System.Windows.Forms.GroupBox();
            this.textBoxErrorExample = new System.Windows.Forms.TextBox();
            this.labelErrorFore = new System.Windows.Forms.Label();
            this.labelErrorBack = new System.Windows.Forms.Label();
            this.pictureBoxErrorFore = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorBack = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxWarn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarnFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarnBack)).BeginInit();
            this.groupBoxError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorBack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxWarn
            // 
            this.groupBoxWarn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWarn.Controls.Add(this.textBoxWarnExample);
            this.groupBoxWarn.Controls.Add(this.labelWarnFore);
            this.groupBoxWarn.Controls.Add(this.labelWarnBack);
            this.groupBoxWarn.Controls.Add(this.pictureBoxWarnFore);
            this.groupBoxWarn.Controls.Add(this.pictureBoxWarnBack);
            this.groupBoxWarn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.groupBoxWarn.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWarn.Name = "groupBoxWarn";
            this.groupBoxWarn.Size = new System.Drawing.Size(356, 163);
            this.groupBoxWarn.TabIndex = 0;
            this.groupBoxWarn.TabStop = false;
            this.groupBoxWarn.Text = "Замечания";
            // 
            // textBoxWarnExample
            // 
            this.textBoxWarnExample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWarnExample.BackColor = System.Drawing.Color.White;
            this.textBoxWarnExample.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWarnExample.Location = new System.Drawing.Point(15, 115);
            this.textBoxWarnExample.Name = "textBoxWarnExample";
            this.textBoxWarnExample.ReadOnly = true;
            this.textBoxWarnExample.Size = new System.Drawing.Size(323, 29);
            this.textBoxWarnExample.TabIndex = 0;
            this.textBoxWarnExample.TabStop = false;
            this.textBoxWarnExample.Text = "Простой текст для примера";
            this.textBoxWarnExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWarnFore
            // 
            this.labelWarnFore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarnFore.ForeColor = System.Drawing.Color.DimGray;
            this.labelWarnFore.Location = new System.Drawing.Point(258, 34);
            this.labelWarnFore.Name = "labelWarnFore";
            this.labelWarnFore.Size = new System.Drawing.Size(80, 23);
            this.labelWarnFore.TabIndex = 0;
            this.labelWarnFore.Text = "Текст";
            this.labelWarnFore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWarnBack
            // 
            this.labelWarnBack.ForeColor = System.Drawing.Color.DimGray;
            this.labelWarnBack.Location = new System.Drawing.Point(15, 34);
            this.labelWarnBack.Name = "labelWarnBack";
            this.labelWarnBack.Size = new System.Drawing.Size(80, 23);
            this.labelWarnBack.TabIndex = 0;
            this.labelWarnBack.Text = "Фон";
            this.labelWarnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWarnFore
            // 
            this.pictureBoxWarnFore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxWarnFore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWarnFore.Location = new System.Drawing.Point(258, 60);
            this.pictureBoxWarnFore.Name = "pictureBoxWarnFore";
            this.pictureBoxWarnFore.Size = new System.Drawing.Size(80, 40);
            this.pictureBoxWarnFore.TabIndex = 2;
            this.pictureBoxWarnFore.TabStop = false;
            this.pictureBoxWarnFore.Click += new System.EventHandler(this.pictureBoxWarnFore_Click);
            this.pictureBoxWarnFore.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // pictureBoxWarnBack
            // 
            this.pictureBoxWarnBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWarnBack.Location = new System.Drawing.Point(15, 60);
            this.pictureBoxWarnBack.Name = "pictureBoxWarnBack";
            this.pictureBoxWarnBack.Size = new System.Drawing.Size(80, 40);
            this.pictureBoxWarnBack.TabIndex = 2;
            this.pictureBoxWarnBack.TabStop = false;
            this.pictureBoxWarnBack.Click += new System.EventHandler(this.pictureBoxWarnBack_Click);
            this.pictureBoxWarnBack.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // groupBoxError
            // 
            this.groupBoxError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxError.Controls.Add(this.textBoxErrorExample);
            this.groupBoxError.Controls.Add(this.labelErrorFore);
            this.groupBoxError.Controls.Add(this.labelErrorBack);
            this.groupBoxError.Controls.Add(this.pictureBoxErrorFore);
            this.groupBoxError.Controls.Add(this.pictureBoxErrorBack);
            this.groupBoxError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.groupBoxError.Location = new System.Drawing.Point(12, 181);
            this.groupBoxError.Name = "groupBoxError";
            this.groupBoxError.Size = new System.Drawing.Size(356, 163);
            this.groupBoxError.TabIndex = 0;
            this.groupBoxError.TabStop = false;
            this.groupBoxError.Text = "Ошибки";
            // 
            // textBoxErrorExample
            // 
            this.textBoxErrorExample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxErrorExample.BackColor = System.Drawing.Color.White;
            this.textBoxErrorExample.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxErrorExample.Location = new System.Drawing.Point(15, 115);
            this.textBoxErrorExample.Name = "textBoxErrorExample";
            this.textBoxErrorExample.ReadOnly = true;
            this.textBoxErrorExample.Size = new System.Drawing.Size(323, 29);
            this.textBoxErrorExample.TabIndex = 0;
            this.textBoxErrorExample.TabStop = false;
            this.textBoxErrorExample.Text = "Простой текст для примера";
            this.textBoxErrorExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelErrorFore
            // 
            this.labelErrorFore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorFore.ForeColor = System.Drawing.Color.DimGray;
            this.labelErrorFore.Location = new System.Drawing.Point(258, 34);
            this.labelErrorFore.Name = "labelErrorFore";
            this.labelErrorFore.Size = new System.Drawing.Size(80, 23);
            this.labelErrorFore.TabIndex = 0;
            this.labelErrorFore.Text = "Текст";
            this.labelErrorFore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelErrorBack
            // 
            this.labelErrorBack.ForeColor = System.Drawing.Color.DimGray;
            this.labelErrorBack.Location = new System.Drawing.Point(15, 34);
            this.labelErrorBack.Name = "labelErrorBack";
            this.labelErrorBack.Size = new System.Drawing.Size(80, 23);
            this.labelErrorBack.TabIndex = 0;
            this.labelErrorBack.Text = "Фон";
            this.labelErrorBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxErrorFore
            // 
            this.pictureBoxErrorFore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxErrorFore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxErrorFore.Location = new System.Drawing.Point(258, 60);
            this.pictureBoxErrorFore.Name = "pictureBoxErrorFore";
            this.pictureBoxErrorFore.Size = new System.Drawing.Size(80, 40);
            this.pictureBoxErrorFore.TabIndex = 2;
            this.pictureBoxErrorFore.TabStop = false;
            this.pictureBoxErrorFore.Click += new System.EventHandler(this.pictureBoxErrorFore_Click);
            this.pictureBoxErrorFore.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // pictureBoxErrorBack
            // 
            this.pictureBoxErrorBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxErrorBack.Location = new System.Drawing.Point(15, 60);
            this.pictureBoxErrorBack.Name = "pictureBoxErrorBack";
            this.pictureBoxErrorBack.Size = new System.Drawing.Size(80, 40);
            this.pictureBoxErrorBack.TabIndex = 2;
            this.pictureBoxErrorBack.TabStop = false;
            this.pictureBoxErrorBack.Click += new System.EventHandler(this.pictureBoxErrorBack_Click);
            this.pictureBoxErrorBack.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PartStat.Properties.Resources.white_ok_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(241, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(18, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 409);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxError);
            this.Controls.Add(this.groupBoxWarn);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "ColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ColorForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorForm_KeyDown);
            this.groupBoxWarn.ResumeLayout(false);
            this.groupBoxWarn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarnFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarnBack)).EndInit();
            this.groupBoxError.ResumeLayout(false);
            this.groupBoxError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWarn;
        private System.Windows.Forms.Label labelWarnBack;
        private System.Windows.Forms.PictureBox pictureBoxWarnBack;
        private System.Windows.Forms.Label labelWarnFore;
        private System.Windows.Forms.PictureBox pictureBoxWarnFore;
        private System.Windows.Forms.TextBox textBoxWarnExample;
        private System.Windows.Forms.GroupBox groupBoxError;
        private System.Windows.Forms.TextBox textBoxErrorExample;
        private System.Windows.Forms.Label labelErrorFore;
        private System.Windows.Forms.Label labelErrorBack;
        private System.Windows.Forms.PictureBox pictureBoxErrorFore;
        private System.Windows.Forms.PictureBox pictureBoxErrorBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}