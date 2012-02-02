namespace TrieuTapSinhVien
{
    partial class frmInHocPhanDangKy
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInHocPhanDangKy));
            this.rpvHocPhan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsHocPhanDangKy = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsHocPhanDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvHocPhan
            // 
            this.rpvHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ThoiKhoaBieuInfo";
            reportDataSource1.Value = this.bsHocPhanDangKy;
            this.rpvHocPhan.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvHocPhan.LocalReport.ReportEmbeddedResource = "TrieuTapSinhVien.Reports.rptHocPhanDangKy.rdlc";
            this.rpvHocPhan.Location = new System.Drawing.Point(0, 0);
            this.rpvHocPhan.Name = "rpvHocPhan";
            this.rpvHocPhan.Size = new System.Drawing.Size(784, 561);
            this.rpvHocPhan.TabIndex = 0;
            // 
            // bsHocPhanDangKy
            // 
            this.bsHocPhanDangKy.DataSource = typeof(TrieuTapSinhVien.Bussiness.ThoiKhoaBieuInfo);
            // 
            // frmInHocPhanDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rpvHocPhan);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInHocPhanDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN DANH SÁCH CÁC HỌC PHẦN ĐÃ ĐĂNG KÝ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInHocPhanDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsHocPhanDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource bsHocPhanDangKy;
        public Microsoft.Reporting.WinForms.ReportViewer rpvHocPhan;

    }
}