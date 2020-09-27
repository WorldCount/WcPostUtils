namespace ListEditor.Forms
{
    partial class EditListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditListForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblFilter = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcpnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtmRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtmRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.massDataGridViewTextBoxColumn,
            this.massRateDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.rcpnDataGridViewTextBoxColumn,
            this.indexToDataGridViewTextBoxColumn,
            this.placeToDataGridViewTextBoxColumn,
            this.regionToDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.rtmRowBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Location = new System.Drawing.Point(12, 45);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Size = new System.Drawing.Size(870, 287);
            this.dataGridView.TabIndex = 0;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 15);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(66, 21);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Фильтр:";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(84, 12);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(268, 27);
            this.tbFilter.TabIndex = 2;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::ListEditor.Properties.Resources.Remove;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(761, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.FillWeight = 187.7503F;
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "ШПИ";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // massDataGridViewTextBoxColumn
            // 
            this.massDataGridViewTextBoxColumn.DataPropertyName = "Mass";
            this.massDataGridViewTextBoxColumn.FillWeight = 53.0119F;
            this.massDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.massDataGridViewTextBoxColumn.Name = "massDataGridViewTextBoxColumn";
            this.massDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // massRateDataGridViewTextBoxColumn
            // 
            this.massRateDataGridViewTextBoxColumn.DataPropertyName = "MassRate";
            this.massRateDataGridViewTextBoxColumn.FillWeight = 78.52474F;
            this.massRateDataGridViewTextBoxColumn.HeaderText = "Плата";
            this.massRateDataGridViewTextBoxColumn.Name = "massRateDataGridViewTextBoxColumn";
            this.massRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.FillWeight = 51.96352F;
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Н/ПЛ";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 51.6433F;
            this.valueDataGridViewTextBoxColumn.HeaderText = "О/Ц";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rcpnDataGridViewTextBoxColumn
            // 
            this.rcpnDataGridViewTextBoxColumn.DataPropertyName = "Rcpn";
            this.rcpnDataGridViewTextBoxColumn.FillWeight = 118.8959F;
            this.rcpnDataGridViewTextBoxColumn.HeaderText = "Получатель";
            this.rcpnDataGridViewTextBoxColumn.Name = "rcpnDataGridViewTextBoxColumn";
            this.rcpnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indexToDataGridViewTextBoxColumn
            // 
            this.indexToDataGridViewTextBoxColumn.DataPropertyName = "IndexTo";
            this.indexToDataGridViewTextBoxColumn.FillWeight = 101.5228F;
            this.indexToDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.indexToDataGridViewTextBoxColumn.Name = "indexToDataGridViewTextBoxColumn";
            this.indexToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeToDataGridViewTextBoxColumn
            // 
            this.placeToDataGridViewTextBoxColumn.DataPropertyName = "PlaceTo";
            this.placeToDataGridViewTextBoxColumn.FillWeight = 118.8959F;
            this.placeToDataGridViewTextBoxColumn.HeaderText = "Город";
            this.placeToDataGridViewTextBoxColumn.Name = "placeToDataGridViewTextBoxColumn";
            this.placeToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionToDataGridViewTextBoxColumn
            // 
            this.regionToDataGridViewTextBoxColumn.DataPropertyName = "RegionTo";
            this.regionToDataGridViewTextBoxColumn.FillWeight = 118.8959F;
            this.regionToDataGridViewTextBoxColumn.HeaderText = "Область";
            this.regionToDataGridViewTextBoxColumn.Name = "regionToDataGridViewTextBoxColumn";
            this.regionToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rtmRowBindingSource
            // 
            this.rtmRowBindingSource.DataSource = typeof(ListEditor.Models.RTM.RtmRow);
            // 
            // EditListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(894, 393);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор списка";
            this.Load += new System.EventHandler(this.EditListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtmRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource rtmRowBindingSource;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn massDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn massRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcpnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionToDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}