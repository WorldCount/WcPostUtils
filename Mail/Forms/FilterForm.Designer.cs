namespace Mail.Forms
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewRules = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelRules = new System.Windows.Forms.Label();
            this.buttonAddRules = new System.Windows.Forms.Button();
            this.buttonDelRules = new System.Windows.Forms.Button();
            this.buttonEditRules = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox.DataSource = this.filterBindingSource;
            this.comboBox.DisplayMember = "Name";
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 33);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(323, 28);
            this.comboBox.TabIndex = 0;
            this.comboBox.ValueMember = "Id";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // filterBindingSource
            // 
            this.filterBindingSource.DataSource = typeof(Mail.Libs.Models.Filter);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.Location = new System.Drawing.Point(561, 27);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(104, 38);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(341, 27);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 38);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewRules
            // 
            this.dataGridViewRules.AllowUserToAddRows = false;
            this.dataGridViewRules.AllowUserToDeleteRows = false;
            this.dataGridViewRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRules.AutoGenerateColumns = false;
            this.dataGridViewRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.EmailText});
            this.dataGridViewRules.DataSource = this.emailBindingSource;
            this.dataGridViewRules.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewRules.MultiSelect = false;
            this.dataGridViewRules.Name = "dataGridViewRules";
            this.dataGridViewRules.ReadOnly = true;
            this.dataGridViewRules.RowHeadersWidth = 45;
            this.dataGridViewRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRules.Size = new System.Drawing.Size(482, 245);
            this.dataGridViewRules.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmailText
            // 
            this.EmailText.DataPropertyName = "Text";
            this.EmailText.HeaderText = "Почта";
            this.EmailText.MinimumWidth = 6;
            this.EmailText.Name = "EmailText";
            this.EmailText.ReadOnly = true;
            // 
            // emailBindingSource
            // 
            this.emailBindingSource.DataSource = typeof(Mail.Libs.Models.Email);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(12, 9);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(145, 21);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Название фильтра:";
            // 
            // labelRules
            // 
            this.labelRules.AutoSize = true;
            this.labelRules.Location = new System.Drawing.Point(12, 117);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(138, 21);
            this.labelRules.TabIndex = 4;
            this.labelRules.Text = "Правила фильтра:";
            // 
            // buttonAddRules
            // 
            this.buttonAddRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRules.Location = new System.Drawing.Point(500, 141);
            this.buttonAddRules.Name = "buttonAddRules";
            this.buttonAddRules.Size = new System.Drawing.Size(165, 38);
            this.buttonAddRules.TabIndex = 5;
            this.buttonAddRules.Text = "Добавить";
            this.buttonAddRules.UseVisualStyleBackColor = true;
            this.buttonAddRules.Click += new System.EventHandler(this.buttonAddRules_Click);
            // 
            // buttonDelRules
            // 
            this.buttonDelRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelRules.Location = new System.Drawing.Point(500, 229);
            this.buttonDelRules.Name = "buttonDelRules";
            this.buttonDelRules.Size = new System.Drawing.Size(165, 38);
            this.buttonDelRules.TabIndex = 5;
            this.buttonDelRules.Text = "Удалить";
            this.buttonDelRules.UseVisualStyleBackColor = true;
            this.buttonDelRules.Click += new System.EventHandler(this.buttonDelRules_Click);
            // 
            // buttonEditRules
            // 
            this.buttonEditRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditRules.Location = new System.Drawing.Point(500, 185);
            this.buttonEditRules.Name = "buttonEditRules";
            this.buttonEditRules.Size = new System.Drawing.Size(165, 38);
            this.buttonEditRules.TabIndex = 5;
            this.buttonEditRules.Text = "Изменить";
            this.buttonEditRules.UseVisualStyleBackColor = true;
            this.buttonEditRules.Click += new System.EventHandler(this.buttonEditRules_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(451, 27);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(104, 38);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(500, 348);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(165, 38);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 398);
            this.Controls.Add(this.buttonEditRules);
            this.Controls.Add(this.buttonDelRules);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddRules);
            this.Controls.Add(this.labelRules);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.dataGridViewRules);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mail: Filter";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridView dataGridViewRules;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.BindingSource emailBindingSource;
        private System.Windows.Forms.Button buttonAddRules;
        private System.Windows.Forms.Button buttonDelRules;
        private System.Windows.Forms.Button buttonEditRules;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.BindingSource filterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailText;
    }
}