namespace ListEditor.Forms
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
            this.lblNDS = new System.Windows.Forms.Label();
            this.lblOpsNum = new System.Windows.Forms.Label();
            this.numericNDS = new System.Windows.Forms.NumericUpDown();
            this.numericOps = new System.Windows.Forms.NumericUpDown();
            this.lblIndexFile = new System.Windows.Forms.Label();
            this.tbIndexFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxRecount = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckIndex = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckPostMark = new System.Windows.Forms.CheckBox();
            this.checkBoxAllIndex = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericNDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOps)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNDS
            // 
            this.lblNDS.AutoSize = true;
            this.lblNDS.Location = new System.Drawing.Point(12, 9);
            this.lblNDS.Name = "lblNDS";
            this.lblNDS.Size = new System.Drawing.Size(45, 21);
            this.lblNDS.TabIndex = 0;
            this.lblNDS.Text = "НДС:";
            // 
            // lblOpsNum
            // 
            this.lblOpsNum.AutoSize = true;
            this.lblOpsNum.Location = new System.Drawing.Point(12, 73);
            this.lblOpsNum.Name = "lblOpsNum";
            this.lblOpsNum.Size = new System.Drawing.Size(103, 21);
            this.lblOpsNum.TabIndex = 0;
            this.lblOpsNum.Text = "Индекс ОПС:";
            // 
            // numericNDS
            // 
            this.numericNDS.Location = new System.Drawing.Point(16, 33);
            this.numericNDS.Name = "numericNDS";
            this.numericNDS.Size = new System.Drawing.Size(81, 27);
            this.numericNDS.TabIndex = 1;
            // 
            // numericOps
            // 
            this.numericOps.Location = new System.Drawing.Point(16, 97);
            this.numericOps.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericOps.Name = "numericOps";
            this.numericOps.Size = new System.Drawing.Size(99, 27);
            this.numericOps.TabIndex = 2;
            // 
            // lblIndexFile
            // 
            this.lblIndexFile.AutoSize = true;
            this.lblIndexFile.Location = new System.Drawing.Point(12, 138);
            this.lblIndexFile.Name = "lblIndexFile";
            this.lblIndexFile.Size = new System.Drawing.Size(172, 21);
            this.lblIndexFile.TabIndex = 5;
            this.lblIndexFile.Text = "Справочник индексов:";
            // 
            // tbIndexFile
            // 
            this.tbIndexFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIndexFile.Location = new System.Drawing.Point(16, 163);
            this.tbIndexFile.Name = "tbIndexFile";
            this.tbIndexFile.Size = new System.Drawing.Size(456, 27);
            this.tbIndexFile.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Image = global::ListEditor.Properties.Resources.OK_big;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(312, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::ListEditor.Properties.Resources.Remove_big;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxRecount
            // 
            this.checkBoxRecount.AutoSize = true;
            this.checkBoxRecount.Location = new System.Drawing.Point(16, 200);
            this.checkBoxRecount.Name = "checkBoxRecount";
            this.checkBoxRecount.Size = new System.Drawing.Size(240, 25);
            this.checkBoxRecount.TabIndex = 6;
            this.checkBoxRecount.Text = "Пересчитывать сумму списка";
            this.checkBoxRecount.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheckIndex
            // 
            this.checkBoxCheckIndex.AutoSize = true;
            this.checkBoxCheckIndex.Location = new System.Drawing.Point(16, 232);
            this.checkBoxCheckIndex.Name = "checkBoxCheckIndex";
            this.checkBoxCheckIndex.Size = new System.Drawing.Size(232, 25);
            this.checkBoxCheckIndex.TabIndex = 7;
            this.checkBoxCheckIndex.Text = "Исправлять пустые индексы";
            this.checkBoxCheckIndex.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheckPostMark
            // 
            this.checkBoxCheckPostMark.AutoSize = true;
            this.checkBoxCheckPostMark.Location = new System.Drawing.Point(16, 263);
            this.checkBoxCheckPostMark.Name = "checkBoxCheckPostMark";
            this.checkBoxCheckPostMark.Size = new System.Drawing.Size(354, 25);
            this.checkBoxCheckPostMark.TabIndex = 8;
            this.checkBoxCheckPostMark.Text = "Исправлять отметки у заказных отправлений";
            this.checkBoxCheckPostMark.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllIndex
            // 
            this.checkBoxAllIndex.AutoSize = true;
            this.checkBoxAllIndex.Location = new System.Drawing.Point(16, 294);
            this.checkBoxAllIndex.Name = "checkBoxAllIndex";
            this.checkBoxAllIndex.Size = new System.Drawing.Size(205, 25);
            this.checkBoxAllIndex.TabIndex = 9;
            this.checkBoxAllIndex.Text = "Исправлять все индексы";
            this.checkBoxAllIndex.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 389);
            this.Controls.Add(this.checkBoxAllIndex);
            this.Controls.Add(this.checkBoxCheckPostMark);
            this.Controls.Add(this.checkBoxCheckIndex);
            this.Controls.Add(this.checkBoxRecount);
            this.Controls.Add(this.tbIndexFile);
            this.Controls.Add(this.lblIndexFile);
            this.Controls.Add(this.numericOps);
            this.Controls.Add(this.numericNDS);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOpsNum);
            this.Controls.Add(this.lblNDS);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 430);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericNDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNDS;
        private System.Windows.Forms.Label lblOpsNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numericNDS;
        private System.Windows.Forms.NumericUpDown numericOps;
        private System.Windows.Forms.Label lblIndexFile;
        private System.Windows.Forms.TextBox tbIndexFile;
        private System.Windows.Forms.CheckBox checkBoxRecount;
        private System.Windows.Forms.CheckBox checkBoxCheckIndex;
        private System.Windows.Forms.CheckBox checkBoxCheckPostMark;
        private System.Windows.Forms.CheckBox checkBoxAllIndex;
    }
}