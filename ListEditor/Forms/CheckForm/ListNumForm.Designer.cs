namespace ListEditor.Forms.CheckForm
{
    partial class ListNumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListNumForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.radioInclude = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::ListEditor.Properties.Resources.OK_big;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(262, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Принять";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancel.Image = global::ListEditor.Properties.Resources.Remove_big;
            this.bntCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCancel.Location = new System.Drawing.Point(12, 137);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(160, 40);
            this.bntCancel.TabIndex = 4;
            this.bntCancel.Text = "Отмена";
            this.bntCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // radioInclude
            // 
            this.radioInclude.AutoSize = true;
            this.radioInclude.Checked = true;
            this.radioInclude.Location = new System.Drawing.Point(12, 12);
            this.radioInclude.Name = "radioInclude";
            this.radioInclude.Size = new System.Drawing.Size(298, 25);
            this.radioInclude.TabIndex = 0;
            this.radioInclude.TabStop = true;
            this.radioInclude.Text = "Начать нумерацию списков с номера";
            this.radioInclude.UseVisualStyleBackColor = true;
            this.radioInclude.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(12, 43);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(265, 25);
            this.radioAdd.TabIndex = 1;
            this.radioAdd.Text = "Добавить к номеру списка число";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown.Location = new System.Drawing.Point(12, 74);
            this.numericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(410, 31);
            this.numericUpDown.TabIndex = 2;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // ListNumForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntCancel;
            this.ClientSize = new System.Drawing.Size(434, 189);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.radioAdd);
            this.Controls.Add(this.radioInclude);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bntCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(450, 230);
            this.Name = "ListNumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Номер списка";
            this.Load += new System.EventHandler(this.ListNumForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListNumForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioInclude;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}