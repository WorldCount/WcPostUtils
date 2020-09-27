namespace Installer.Forms
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.buttonAccept = new System.Windows.Forms.Button();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAccept.Location = new System.Drawing.Point(371, 421);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(106, 36);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApp.Location = new System.Drawing.Point(12, 9);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(38, 21);
            this.lblApp.TabIndex = 2;
            this.lblApp.Text = "ПО:";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAppName.Location = new System.Drawing.Point(54, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(87, 21);
            this.lblAppName.TabIndex = 3;
            this.lblAppName.Text = "AppName";
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInfo.Font = new System.Drawing.Font("Consolas", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo.ForeColor = System.Drawing.Color.Silver;
            this.tbInfo.Location = new System.Drawing.Point(12, 43);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.tbInfo.Size = new System.Drawing.Size(825, 372);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.TabStop = false;
            this.tbInfo.Text = "";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 469);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.buttonAccept);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обновления";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.RichTextBox tbInfo;
    }
}