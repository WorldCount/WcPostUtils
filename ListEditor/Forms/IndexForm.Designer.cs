namespace ListEditor.Forms
{
    partial class IndexForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.dataGridIndex = new System.Windows.Forms.DataGridView();
            this.lblIndex = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.labelSub = new System.Windows.Forms.Label();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lblFindText = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridIndex
            // 
            this.dataGridIndex.AllowUserToAddRows = false;
            this.dataGridIndex.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIndex.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridIndex.AutoGenerateColumns = false;
            this.dataGridIndex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIndex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIndex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.subDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn});
            this.dataGridIndex.DataSource = this.indexBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIndex.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridIndex.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dataGridIndex.Location = new System.Drawing.Point(12, 125);
            this.dataGridIndex.Name = "dataGridIndex";
            this.dataGridIndex.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIndex.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIndex.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridIndex.Size = new System.Drawing.Size(769, 241);
            this.dataGridIndex.TabIndex = 0;
            this.dataGridIndex.TabStop = false;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(12, 13);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(63, 21);
            this.lblIndex.TabIndex = 2;
            this.lblIndex.Text = "Индекс";
            // 
            // tbIndex
            // 
            this.tbIndex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIndex.Location = new System.Drawing.Point(86, 10);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(100, 27);
            this.tbIndex.TabIndex = 1;
            this.tbIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(211, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 21);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbName.Location = new System.Drawing.Point(258, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(409, 27);
            this.tbName.TabIndex = 2;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(192, 54);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(60, 21);
            this.labelRegion.TabIndex = 8;
            this.labelRegion.Text = "Регион";
            // 
            // tbRegion
            // 
            this.tbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRegion.Location = new System.Drawing.Point(258, 51);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(409, 27);
            this.tbRegion.TabIndex = 4;
            this.tbRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(12, 54);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(68, 21);
            this.labelSub.TabIndex = 9;
            this.labelSub.Text = "Главное";
            // 
            // tbSub
            // 
            this.tbSub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSub.Location = new System.Drawing.Point(86, 51);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(100, 27);
            this.tbSub.TabIndex = 3;
            this.tbSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Image = global::ListEditor.Properties.Resources.Cloud_Error;
            this.btnClear.Location = new System.Drawing.Point(684, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 33);
            this.btnClear.TabIndex = 0;
            this.btnClear.TabStop = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Image = global::ListEditor.Properties.Resources.Cloud_Refresh;
            this.btnFind.Location = new System.Drawing.Point(684, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 33);
            this.btnFind.TabIndex = 6;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Image = global::ListEditor.Properties.Resources.Cloud_Download;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(12, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 39);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::ListEditor.Properties.Resources.Button_Close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(667, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Закрыть";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(39, 95);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(36, 21);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Тип";
            // 
            // tbType
            // 
            this.tbType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbType.Location = new System.Drawing.Point(86, 92);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 27);
            this.tbType.TabIndex = 5;
            this.tbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // lblFindText
            // 
            this.lblFindText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFindText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFindText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFindText.Location = new System.Drawing.Point(577, 92);
            this.lblFindText.Name = "lblFindText";
            this.lblFindText.Size = new System.Drawing.Size(90, 27);
            this.lblFindText.TabIndex = 6;
            this.lblFindText.Text = "0";
            this.lblFindText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFind
            // 
            this.lblFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFind.Location = new System.Drawing.Point(192, 92);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(379, 27);
            this.lblFind.TabIndex = 5;
            this.lblFind.Text = "Найдено:";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subDataGridViewTextBoxColumn
            // 
            this.subDataGridViewTextBoxColumn.DataPropertyName = "Sub";
            this.subDataGridViewTextBoxColumn.HeaderText = "Подчинен";
            this.subDataGridViewTextBoxColumn.Name = "subDataGridViewTextBoxColumn";
            this.subDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Регион";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indexBindingSource
            // 
            this.indexBindingSource.DataSource = typeof(ListEditor.Models.Index);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 423);
            this.Controls.Add(this.lblFindText);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridIndex);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(680, 460);
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Индексы";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IndexForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridIndex;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.TextBox tbSub;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource indexBindingSource;
        private System.Windows.Forms.Label lblFindText;
        private System.Windows.Forms.Label lblFind;
    }
}