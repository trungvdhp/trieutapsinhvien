namespace TrieuTapSinhVien
{
    partial class frmAboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutBox));
            this.labelCopyright = new System.Windows.Forms.LinkLabel();
            this.labelProductName = new System.Windows.Forms.LinkLabel();
            this.labelCompanyName = new System.Windows.Forms.LinkLabel();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelCopyright.LinkColor = System.Drawing.Color.Blue;
            this.labelCopyright.Location = new System.Drawing.Point(122, 61);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(62, 16);
            this.labelCopyright.TabIndex = 27;
            this.labelCopyright.TabStop = true;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelCopyright_LinkClicked);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelProductName.LinkColor = System.Drawing.Color.Blue;
            this.labelProductName.Location = new System.Drawing.Point(122, 11);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(88, 16);
            this.labelProductName.TabIndex = 26;
            this.labelProductName.TabStop = true;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelProductName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelProductName_LinkClicked);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.labelCompanyName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelCompanyName.LinkColor = System.Drawing.Color.Blue;
            this.labelCompanyName.Location = new System.Drawing.Point(122, 86);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(98, 16);
            this.labelCompanyName.TabIndex = 28;
            this.labelCompanyName.TabStop = true;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCompanyName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelCompanyName_LinkClicked);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.Azure;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(222, 114);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(70, 25);
            this.okButton.TabIndex = 29;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(0, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 35);
            this.label2.TabIndex = 75;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelVersion.LinkColor = System.Drawing.Color.Blue;
            this.labelVersion.Location = new System.Drawing.Point(122, 36);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(51, 16);
            this.labelVersion.TabIndex = 76;
            this.labelVersion.TabStop = true;
            this.labelVersion.Text = "Version";
            this.labelVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelVersion_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrieuTapSinhVien.Properties.Resources.Logo_Vimaru;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // frmAboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(302, 145);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAboutBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrieuTapSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel labelCopyright;
        private System.Windows.Forms.LinkLabel labelProductName;
        private System.Windows.Forms.LinkLabel labelCompanyName;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel labelVersion;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
