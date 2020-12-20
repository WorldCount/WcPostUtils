namespace TestingApp.Libs.Widgets
{
    partial class TextBoxControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelField = new System.Windows.Forms.Label();
            this.textField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelField
            // 
            this.labelField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelField.AutoSize = true;
            this.labelField.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelField.ForeColor = System.Drawing.Color.White;
            this.labelField.Location = new System.Drawing.Point(3, 8);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(45, 19);
            this.labelField.TabIndex = 1;
            this.labelField.Text = "ШПИ:";
            // 
            // textField
            // 
            this.textField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textField.BackColor = System.Drawing.Color.White;
            this.textField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textField.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.textField.Location = new System.Drawing.Point(54, 3);
            this.textField.MaxLength = 14;
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(153, 29);
            this.textField.TabIndex = 14;
            // 
            // TextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textField);
            this.Controls.Add(this.labelField);
            this.Name = "TextBoxControl";
            this.Size = new System.Drawing.Size(213, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.TextBox textField;
    }
}
