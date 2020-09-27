namespace AOP.Forms
{
    partial class RpoListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.lblRcpn = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.tbRcpn = new System.Windows.Forms.TextBox();
            this.tbMass = new System.Windows.Forms.TextBox();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcpnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(168, 335);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(418, 40);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Image = global::AOP.Properties.Resources.OK;
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(592, 335);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(150, 40);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.TabStop = false;
            this.btnAccept.Text = "Принять";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::AOP.Properties.Resources.Remove;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.placeToDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.massDataGridViewTextBoxColumn,
            this.rcpnDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.rpoBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dataGridView.Location = new System.Drawing.Point(12, 118);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowTemplate.Height = 50;
            this.dataGridView.Size = new System.Drawing.Size(730, 211);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // tbComment
            // 
            this.tbComment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbComment.Location = new System.Drawing.Point(10, 56);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(179, 27);
            this.tbComment.TabIndex = 1;
            this.tbComment.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters.Controls.Add(this.lblRcpn);
            this.groupBoxFilters.Controls.Add(this.lblMass);
            this.groupBoxFilters.Controls.Add(this.lblComment);
            this.groupBoxFilters.Controls.Add(this.tbRcpn);
            this.groupBoxFilters.Controls.Add(this.tbMass);
            this.groupBoxFilters.Controls.Add(this.tbComment);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(730, 100);
            this.groupBoxFilters.TabIndex = 5;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтры";
            // 
            // lblRcpn
            // 
            this.lblRcpn.AutoSize = true;
            this.lblRcpn.Location = new System.Drawing.Point(286, 32);
            this.lblRcpn.Name = "lblRcpn";
            this.lblRcpn.Size = new System.Drawing.Size(97, 21);
            this.lblRcpn.TabIndex = 5;
            this.lblRcpn.Text = "Получатель:";
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(191, 32);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(37, 21);
            this.lblMass.TabIndex = 5;
            this.lblMass.Text = "Вес:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(6, 32);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(104, 21);
            this.lblComment.TabIndex = 5;
            this.lblComment.Text = "Примечание:";
            // 
            // tbRcpn
            // 
            this.tbRcpn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRcpn.Location = new System.Drawing.Point(290, 56);
            this.tbRcpn.Name = "tbRcpn";
            this.tbRcpn.Size = new System.Drawing.Size(252, 27);
            this.tbRcpn.TabIndex = 3;
            this.tbRcpn.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(195, 56);
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(89, 27);
            this.tbMass.TabIndex = 2;
            this.tbMass.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMass_KeyPress);
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.Width = 80;
            // 
            // placeToDataGridViewTextBoxColumn
            // 
            this.placeToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.placeToDataGridViewTextBoxColumn.DataPropertyName = "PlaceTo";
            this.placeToDataGridViewTextBoxColumn.HeaderText = "Город";
            this.placeToDataGridViewTextBoxColumn.Name = "placeToDataGridViewTextBoxColumn";
            this.placeToDataGridViewTextBoxColumn.Width = 140;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 140;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // massDataGridViewTextBoxColumn
            // 
            this.massDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.massDataGridViewTextBoxColumn.DataPropertyName = "Mass";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.massDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.massDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.massDataGridViewTextBoxColumn.Name = "massDataGridViewTextBoxColumn";
            this.massDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.massDataGridViewTextBoxColumn.Width = 50;
            // 
            // rcpnDataGridViewTextBoxColumn
            // 
            this.rcpnDataGridViewTextBoxColumn.DataPropertyName = "Rcpn";
            this.rcpnDataGridViewTextBoxColumn.HeaderText = "Получатель";
            this.rcpnDataGridViewTextBoxColumn.Name = "rcpnDataGridViewTextBoxColumn";
            // 
            // rpoBindingSource
            // 
            this.rpoBindingSource.DataSource = typeof(AOP.Models.Rpo);
            this.rpoBindingSource.DataSourceChanged += new System.EventHandler(this.rpoBindingSource_DataSourceChanged);
            // 
            // RpoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 387);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RpoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RpoListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RpoListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RpoListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.BindingSource rpoBindingSource;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.TextBox tbMass;
        private System.Windows.Forms.Label lblRcpn;
        private System.Windows.Forms.TextBox tbRcpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn massDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcpnDataGridViewTextBoxColumn;
    }
}