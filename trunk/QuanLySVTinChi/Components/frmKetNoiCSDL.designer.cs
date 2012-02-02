namespace TrieuTapSinhVien
{
    partial class frmKetNoiCSDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetNoiCSDL));
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llblCapNhatCSDL = new System.Windows.Forms.LinkLabel();
            this.chkMatKhau = new System.Windows.Forms.CheckBox();
            this.txtCSDL = new System.Windows.Forms.TextBox();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(116, 52);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(289, 23);
            this.txtMatKhau.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label3.Location = new System.Drawing.Point(22, 19);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 16);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Cơ sở dữ liệu:";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuyBo.Location = new System.Drawing.Point(324, 8);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(80, 23);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKetNoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKetNoi.Location = new System.Drawing.Point(238, 8);
            this.btnKetNoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(80, 23);
            this.btnKetNoi.TabIndex = 4;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.llblCapNhatCSDL);
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnKetNoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 45);
            this.panel1.TabIndex = 6;
            // 
            // llblCapNhatCSDL
            // 
            this.llblCapNhatCSDL.AutoSize = true;
            this.llblCapNhatCSDL.Location = new System.Drawing.Point(21, 11);
            this.llblCapNhatCSDL.Name = "llblCapNhatCSDL";
            this.llblCapNhatCSDL.Size = new System.Drawing.Size(136, 16);
            this.llblCapNhatCSDL.TabIndex = 6;
            this.llblCapNhatCSDL.TabStop = true;
            this.llblCapNhatCSDL.Text = "Cập nhật cơ sở dữ liệu";
            this.llblCapNhatCSDL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCapNhatCSDL_LinkClicked);
            // 
            // chkMatKhau
            // 
            this.chkMatKhau.AutoSize = true;
            this.chkMatKhau.Location = new System.Drawing.Point(25, 55);
            this.chkMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMatKhau.Name = "chkMatKhau";
            this.chkMatKhau.Size = new System.Drawing.Size(84, 20);
            this.chkMatKhau.TabIndex = 2;
            this.chkMatKhau.Text = "Mật khẩu:";
            this.chkMatKhau.UseVisualStyleBackColor = true;
            this.chkMatKhau.CheckedChanged += new System.EventHandler(this.chkMatKhau_CheckedChanged);
            // 
            // txtCSDL
            // 
            this.txtCSDL.Location = new System.Drawing.Point(116, 16);
            this.txtCSDL.Name = "txtCSDL";
            this.txtCSDL.Size = new System.Drawing.Size(289, 23);
            this.txtCSDL.TabIndex = 0;
            // 
            // btnDuyet
            // 
            this.btnDuyet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDuyet.Location = new System.Drawing.Point(411, 16);
            this.btnDuyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(52, 23);
            this.btnDuyet.TabIndex = 1;
            this.btnDuyet.Text = "Mở...";
            this.btnDuyet.UseVisualStyleBackColor = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // frmKetNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(490, 133);
            this.Controls.Add(this.txtCSDL);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.chkMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKetNoiCSDL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU MS ACCESS";
            this.Load += new System.EventHandler(this.frmKetNoiCSDL_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKetNoiCSDL_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.CheckBox chkMatKhau;
        private System.Windows.Forms.TextBox txtCSDL;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.LinkLabel llblCapNhatCSDL;
    }
}