namespace TestingApp.Forms
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
            this.btnTarificator = new System.Windows.Forms.Button();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnSerializer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTarificator
            // 
            this.btnTarificator.Location = new System.Drawing.Point(22, 21);
            this.btnTarificator.Name = "btnTarificator";
            this.btnTarificator.Size = new System.Drawing.Size(130, 40);
            this.btnTarificator.TabIndex = 0;
            this.btnTarificator.Text = "Tarificator";
            this.btnTarificator.UseVisualStyleBackColor = true;
            this.btnTarificator.Click += new System.EventHandler(this.btnTarificator_Click);
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(22, 87);
            this.tbBarcode.MaxLength = 14;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(220, 27);
            this.tbBarcode.TabIndex = 1;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(248, 80);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(130, 40);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "Генерировать";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(22, 149);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(766, 210);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // btnSerializer
            // 
            this.btnSerializer.Location = new System.Drawing.Point(158, 21);
            this.btnSerializer.Name = "btnSerializer";
            this.btnSerializer.Size = new System.Drawing.Size(130, 40);
            this.btnSerializer.TabIndex = 0;
            this.btnSerializer.Text = "Serializer";
            this.btnSerializer.UseVisualStyleBackColor = true;
            this.btnSerializer.Click += new System.EventHandler(this.btnSerializer_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnSerializer);
            this.Controls.Add(this.btnTarificator);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Name = "GeneralForm";
            this.Text = "TestingApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTarificator;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnSerializer;
    }
}

