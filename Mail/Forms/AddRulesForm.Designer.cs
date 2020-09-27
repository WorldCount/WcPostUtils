namespace Mail.Forms
{
    partial class AddRulesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRulesForm));
            this.labelInfoFilter = new System.Windows.Forms.Label();
            this.labelInfoMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelMailError = new System.Windows.Forms.Label();
            this.labelInfoName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNameError = new System.Windows.Forms.Label();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfoFilter
            // 
            this.labelInfoFilter.AutoSize = true;
            this.labelInfoFilter.Location = new System.Drawing.Point(12, 9);
            this.labelInfoFilter.Name = "labelInfoFilter";
            this.labelInfoFilter.Size = new System.Drawing.Size(144, 21);
            this.labelInfoFilter.TabIndex = 0;
            this.labelInfoFilter.Text = "Название правила:";
            // 
            // labelInfoMail
            // 
            this.labelInfoMail.AutoSize = true;
            this.labelInfoMail.Location = new System.Drawing.Point(12, 167);
            this.labelInfoMail.Name = "labelInfoMail";
            this.labelInfoMail.Size = new System.Drawing.Size(57, 21);
            this.labelInfoMail.TabIndex = 0;
            this.labelInfoMail.Text = "Почта:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(16, 191);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(450, 27);
            this.textBoxMail.TabIndex = 2;
            this.textBoxMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMail_KeyDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(16, 267);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 38);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(362, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 38);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelMailError
            // 
            this.labelMailError.ForeColor = System.Drawing.Color.Red;
            this.labelMailError.Location = new System.Drawing.Point(16, 221);
            this.labelMailError.Name = "labelMailError";
            this.labelMailError.Size = new System.Drawing.Size(450, 21);
            this.labelMailError.TabIndex = 0;
            this.labelMailError.Text = "Error";
            // 
            // labelInfoName
            // 
            this.labelInfoName.AutoSize = true;
            this.labelInfoName.Location = new System.Drawing.Point(12, 78);
            this.labelInfoName.Name = "labelInfoName";
            this.labelInfoName.Size = new System.Drawing.Size(44, 21);
            this.labelInfoName.TabIndex = 0;
            this.labelInfoName.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(450, 27);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // labelNameError
            // 
            this.labelNameError.ForeColor = System.Drawing.Color.Red;
            this.labelNameError.Location = new System.Drawing.Point(16, 132);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(450, 21);
            this.labelNameError.TabIndex = 0;
            this.labelNameError.Text = "Error";
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.DataSource = this.filterBindingSource;
            this.comboBoxFilters.DisplayMember = "Name";
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(16, 33);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(450, 28);
            this.comboBoxFilters.TabIndex = 5;
            this.comboBoxFilters.ValueMember = "Id";
            // 
            // filterBindingSource
            // 
            this.filterBindingSource.DataSource = typeof(Mail.Libs.Models.Filter);
            // 
            // AddRulesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(478, 324);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.labelNameError);
            this.Controls.Add(this.labelMailError);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelInfoName);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelInfoMail);
            this.Controls.Add(this.labelInfoFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddRulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mail: AddRules";
            this.Load += new System.EventHandler(this.AddRulesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddRulesForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoFilter;
        private System.Windows.Forms.Label labelInfoMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelMailError;
        private System.Windows.Forms.Label labelInfoName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNameError;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.BindingSource filterBindingSource;
    }
}