namespace LK.Forms.DataForms
{
    partial class FirmsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmsForm));
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnSave = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnCancel = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnUpdate = new Wc32Api.Widgets.Buttons.WcButton();
            this.tbFilter = new LK.Core.Libs.Widget.BorderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(136, 28);
            this.labelInfo.TabIndex = 18;
            this.labelInfo.Text = "Организации";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.kppDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn});
            this.dataGridView.ContextMenuStrip = this.contextMenu;
            this.dataGridView.DataSource = this.firmBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView.Location = new System.Drawing.Point(12, 51);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(860, 325);
            this.dataGridView.TabIndex = 19;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseUp);
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
            // 
            // checkDataGridViewCheckBoxColumn
            // 
            this.checkDataGridViewCheckBoxColumn.DataPropertyName = "Check";
            this.checkDataGridViewCheckBoxColumn.HeaderText = "Отм";
            this.checkDataGridViewCheckBoxColumn.Name = "checkDataGridViewCheckBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "Сокращение";
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "Inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            this.innDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kppDataGridViewTextBoxColumn
            // 
            this.kppDataGridViewTextBoxColumn.DataPropertyName = "Kpp";
            this.kppDataGridViewTextBoxColumn.HeaderText = "КПП";
            this.kppDataGridViewTextBoxColumn.Name = "kppDataGridViewTextBoxColumn";
            this.kppDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractDataGridViewTextBoxColumn
            // 
            this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
            this.contractDataGridViewTextBoxColumn.HeaderText = "Договор";
            this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
            this.contractDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.checkAllMenuItem,
            this.uncheckAllMenuItem,
            this.toolStripSeparator1,
            this.removeSelectMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(227, 110);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // checkAllMenuItem
            // 
            this.checkAllMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAllMenuItem.Name = "checkAllMenuItem";
            this.checkAllMenuItem.Size = new System.Drawing.Size(226, 24);
            this.checkAllMenuItem.Text = "Отметить все";
            this.checkAllMenuItem.Click += new System.EventHandler(this.checkAllMenuItem_Click);
            // 
            // uncheckAllMenuItem
            // 
            this.uncheckAllMenuItem.Name = "uncheckAllMenuItem";
            this.uncheckAllMenuItem.Size = new System.Drawing.Size(226, 24);
            this.uncheckAllMenuItem.Text = "Снять все отметки";
            this.uncheckAllMenuItem.Click += new System.EventHandler(this.uncheckAllMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // removeSelectMenuItem
            // 
            this.removeSelectMenuItem.Name = "removeSelectMenuItem";
            this.removeSelectMenuItem.Size = new System.Drawing.Size(226, 24);
            this.removeSelectMenuItem.Text = "Удалить выделенные";
            this.removeSelectMenuItem.Click += new System.EventHandler(this.removeSelectMenuItem_Click);
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataSource = typeof(LK.Core.Models.DB.Firm);
            this.firmBindingSource.Filter = "";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.lblCount.Location = new System.Drawing.Point(752, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(120, 28);
            this.lblCount.TabIndex = 28;
            this.lblCount.Text = "0 шт";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilter.ForeColor = System.Drawing.Color.Gray;
            this.lblFilter.Location = new System.Drawing.Point(481, 10);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(69, 21);
            this.lblFilter.TabIndex = 29;
            this.lblFilter.Text = "Фильтр:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.BorderRadius = 4;
            this.btnSave.BorderThickness = 1F;
            this.btnSave.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::LK.Properties.Resources.save_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(752, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSave.Size = new System.Drawing.Size(120, 46);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 4;
            this.btnCancel.BorderThickness = 1F;
            this.btnCancel.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::LK.Properties.Resources.close_window_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(626, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(120, 46);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.BorderRadius = 4;
            this.btnUpdate.BorderThickness = 1F;
            this.btnUpdate.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(12, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnUpdate.Size = new System.Drawing.Size(150, 46);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Загрузить из БД";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbFilter.BorderHeight = 2;
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFilter.EnterColor = System.Drawing.Color.Firebrick;
            this.tbFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbFilter.LeaveColor = System.Drawing.Color.SteelBlue;
            this.tbFilter.Location = new System.Drawing.Point(556, 9);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(190, 26);
            this.tbFilter.TabIndex = 30;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // FirmsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FirmsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FirmsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FirmsForm_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FirmsForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirmsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridView;
        private Wc32Api.Widgets.Buttons.WcButton btnUpdate;
        private Wc32Api.Widgets.Buttons.WcButton btnSave;
        private Wc32Api.Widgets.Buttons.WcButton btnCancel;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFilter;
        private Core.Libs.Widget.BorderTextBox tbFilter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem checkAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeSelectMenuItem;
    }
}