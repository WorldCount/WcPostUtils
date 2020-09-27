namespace WcApi.Print
{
    partial class GridPrintPreviewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridPrintPreviewDialog));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripSplitButton();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPageSetup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripNumericCopy = new WcApi.Print.ToolStripNumericUpDown();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoom = new System.Windows.Forms.ToolStripSplitButton();
            this.itemActualSize = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFullPage = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPageWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTwoPages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item500 = new System.Windows.Forms.ToolStripMenuItem();
            this.item200 = new System.Windows.Forms.ToolStripMenuItem();
            this.item150 = new System.Windows.Forms.ToolStripMenuItem();
            this.item100 = new System.Windows.Forms.ToolStripMenuItem();
            this.item75 = new System.Windows.Forms.ToolStripMenuItem();
            this.item50 = new System.Windows.Forms.ToolStripMenuItem();
            this.item25 = new System.Windows.Forms.ToolStripMenuItem();
            this.item10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.txtStartPage = new System.Windows.Forms.ToolStripTextBox();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.preview = new WcApi.Print.GridPrintPreviewControl();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.btnPrint,
            this.toolStripSeparator2,
            this.btnPageSetup,
            this.toolStripSeparator3,
            this.toolStripNumericCopy,
            this.toolStripSeparator8,
            this.btnZoom,
            this.toolStripSeparator4,
            this.btnFirst,
            this.btnPrev,
            this.txtStartPage,
            this.lblPageCount,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator5,
            this.btnCancel,
            this.toolStripSeparator6});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(685, 31);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrintPreview});
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(40, 28);
            this.btnPrint.Text = "toolStripSplitButton1";
            this.btnPrint.ButtonClick += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Image = global::WcApi.Properties.Resources.Portable_Printer;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(187, 30);
            this.btnPrintPreview.Text = "Печать с диалогом";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPageSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnPageSetup.Image")));
            this.btnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(28, 28);
            this.btnPageSetup.Text = "Настройки";
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripNumericCopy
            // 
            this.toolStripNumericCopy.BackColor = System.Drawing.Color.Transparent;
            this.toolStripNumericCopy.DecimalPlaces = 0;
            this.toolStripNumericCopy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toolStripNumericCopy.Name = "toolStripNumericCopy";
            this.toolStripNumericCopy.NumBackColor = System.Drawing.SystemColors.Window;
            this.toolStripNumericCopy.Size = new System.Drawing.Size(101, 28);
            this.toolStripNumericCopy.Text = "Копии";
            this.toolStripNumericCopy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // btnZoom
            // 
            this.btnZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemActualSize,
            this.itemFullPage,
            this.itemPageWidth,
            this.itemTwoPages,
            this.toolStripSeparator1,
            this.item500,
            this.item200,
            this.item150,
            this.item100,
            this.item75,
            this.item50,
            this.item25,
            this.item10});
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(87, 28);
            this.btnZoom.Text = "Размер";
            this.btnZoom.ButtonClick += new System.EventHandler(this.btnZoom_ButtonClick);
            this.btnZoom.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnZoom_DropDownItemClicked);
            // 
            // itemActualSize
            // 
            this.itemActualSize.Image = ((System.Drawing.Image)(resources.GetObject("itemActualSize.Image")));
            this.itemActualSize.Name = "itemActualSize";
            this.itemActualSize.Size = new System.Drawing.Size(159, 30);
            this.itemActualSize.Text = "Фактический";
            // 
            // itemFullPage
            // 
            this.itemFullPage.Image = ((System.Drawing.Image)(resources.GetObject("itemFullPage.Image")));
            this.itemFullPage.Name = "itemFullPage";
            this.itemFullPage.Size = new System.Drawing.Size(159, 30);
            this.itemFullPage.Text = "Полный";
            // 
            // itemPageWidth
            // 
            this.itemPageWidth.Image = ((System.Drawing.Image)(resources.GetObject("itemPageWidth.Image")));
            this.itemPageWidth.Name = "itemPageWidth";
            this.itemPageWidth.Size = new System.Drawing.Size(159, 30);
            this.itemPageWidth.Text = "По ширине";
            // 
            // itemTwoPages
            // 
            this.itemTwoPages.Image = ((System.Drawing.Image)(resources.GetObject("itemTwoPages.Image")));
            this.itemTwoPages.Name = "itemTwoPages";
            this.itemTwoPages.Size = new System.Drawing.Size(159, 30);
            this.itemTwoPages.Text = "Две страницы";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // item500
            // 
            this.item500.Name = "item500";
            this.item500.Size = new System.Drawing.Size(159, 30);
            this.item500.Text = "500%";
            // 
            // item200
            // 
            this.item200.Name = "item200";
            this.item200.Size = new System.Drawing.Size(159, 30);
            this.item200.Text = "200%";
            // 
            // item150
            // 
            this.item150.Name = "item150";
            this.item150.Size = new System.Drawing.Size(159, 30);
            this.item150.Text = "150%";
            // 
            // item100
            // 
            this.item100.Name = "item100";
            this.item100.Size = new System.Drawing.Size(159, 30);
            this.item100.Text = "100%";
            // 
            // item75
            // 
            this.item75.Name = "item75";
            this.item75.Size = new System.Drawing.Size(159, 30);
            this.item75.Text = "75%";
            // 
            // item50
            // 
            this.item50.Name = "item50";
            this.item50.Size = new System.Drawing.Size(159, 30);
            this.item50.Text = "50%";
            // 
            // item25
            // 
            this.item25.Name = "item25";
            this.item25.Size = new System.Drawing.Size(159, 30);
            this.item25.Text = "25%";
            // 
            // item10
            // 
            this.item10.Name = "item10";
            this.item10.Size = new System.Drawing.Size(159, 30);
            this.item10.Text = "10%";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(28, 28);
            this.btnFirst.Text = "Первая страница";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 28);
            this.btnPrev.Text = "Предыдущая страница";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtStartPage
            // 
            this.txtStartPage.AutoSize = false;
            this.txtStartPage.Name = "txtStartPage";
            this.txtStartPage.Size = new System.Drawing.Size(32, 23);
            this.txtStartPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartPage.Enter += new System.EventHandler(this.txtStartPage_Enter);
            this.txtStartPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartPage_KeyPress);
            this.txtStartPage.Validating += new System.ComponentModel.CancelEventHandler(this.txtStartPage_Validating);
            // 
            // lblPageCount
            // 
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(0, 28);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 28);
            this.btnNext.Text = "Следующая страница";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(28, 28);
            this.btnLast.Text = "Последняя страница";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 28);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // preview
            // 
            this.preview.AutoScroll = true;
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Document = null;
            this.preview.Location = new System.Drawing.Point(0, 31);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(685, 270);
            this.preview.TabIndex = 1;
            this.preview.StartPageChanged += new System.EventHandler(this.preview_StartPageChanged);
            this.preview.PageCountChanged += new System.EventHandler(this.preview_PageCountChanged);
            // 
            // GridPrintPreviewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(685, 301);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Name = "GridPrintPreviewDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Печать";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridPrintPreviewDialog_KeyDown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnPageSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton btnZoom;
        private System.Windows.Forms.ToolStripMenuItem itemActualSize;
        private System.Windows.Forms.ToolStripMenuItem itemFullPage;
        private System.Windows.Forms.ToolStripMenuItem itemPageWidth;
        private System.Windows.Forms.ToolStripMenuItem itemTwoPages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem item500;
        private System.Windows.Forms.ToolStripMenuItem item200;
        private System.Windows.Forms.ToolStripMenuItem item150;
        private System.Windows.Forms.ToolStripMenuItem item100;
        private System.Windows.Forms.ToolStripMenuItem item75;
        private System.Windows.Forms.ToolStripMenuItem item50;
        private System.Windows.Forms.ToolStripMenuItem item25;
        private System.Windows.Forms.ToolStripMenuItem item10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripTextBox txtStartPage;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private GridPrintPreviewControl preview;
        private System.Windows.Forms.ToolStripLabel lblPageCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private ToolStripNumericUpDown toolStripNumericCopy;
        private System.Windows.Forms.ToolStripSplitButton btnPrint;
        private System.Windows.Forms.ToolStripMenuItem btnPrintPreview;
    }
}