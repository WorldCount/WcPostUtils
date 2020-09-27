namespace ListEditor.Forms.CheckForm
{
    partial class PostMarkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostMarkForm));
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnUncheck = new System.Windows.Forms.Button();
            this.lblMask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(16, 52);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(627, 244);
            this.checkedListBox.TabIndex = 0;
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Image = global::ListEditor.Properties.Resources.OK_big;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Location = new System.Drawing.Point(483, 306);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 40);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Принять";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::ListEditor.Properties.Resources.Remove_big;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(16, 306);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(16, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(130, 30);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Tag = "";
            this.btnCheck.Text = "Отметить все";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnUncheck
            // 
            this.btnUncheck.Location = new System.Drawing.Point(513, 12);
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(130, 30);
            this.btnUncheck.TabIndex = 2;
            this.btnUncheck.Text = "Снять отметки";
            this.btnUncheck.UseVisualStyleBackColor = true;
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // lblMask
            // 
            this.lblMask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMask.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMask.Location = new System.Drawing.Point(183, 306);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(293, 40);
            this.lblMask.TabIndex = 3;
            this.lblMask.Text = "0";
            this.lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PostMarkForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(656, 360);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.btnUncheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.checkedListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PostMarkForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отметки";
            this.Load += new System.EventHandler(this.PostMarkForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PostMarkForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnUncheck;
        private System.Windows.Forms.Label lblMask;
    }
}