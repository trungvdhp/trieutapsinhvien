namespace TrieuTapSinhVien
{
    partial class frmInDSTrieuTap
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInDSTrieuTap));
            this.bsDSTrieuTap = new System.Windows.Forms.BindingSource(this.components);
            this.bsLichTrieuTap = new System.Windows.Forms.BindingSource(this.components);
            this.rpvDanhSachTrieuTap = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSTrieuTap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLichTrieuTap)).BeginInit();
            this.SuspendLayout();
            // 
            // bsDSTrieuTap
            // 
            this.bsDSTrieuTap.DataSource = typeof(TrieuTapSinhVien.Bussiness.SinhVienInfo);
            // 
            // bsLichTrieuTap
            // 
            this.bsLichTrieuTap.DataSource = typeof(TrieuTapSinhVien.Bussiness.NgayTrieuTapInfo);
            // 
            // rpvDanhSachTrieuTap
            // 
            this.rpvDanhSachTrieuTap.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SinhVienInfo";
            reportDataSource1.Value = this.bsDSTrieuTap;
            reportDataSource2.Name = "QuanLySVTinChi_Bussiness_NgayTrieuTapInfo";
            reportDataSource2.Value = this.bsLichTrieuTap;
            this.rpvDanhSachTrieuTap.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDanhSachTrieuTap.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvDanhSachTrieuTap.LocalReport.ReportEmbeddedResource = "TrieuTapSinhVien.Reports.rptDSTrieuTap.rdlc";
            this.rpvDanhSachTrieuTap.Location = new System.Drawing.Point(0, 0);
            this.rpvDanhSachTrieuTap.Name = "rpvDanhSachTrieuTap";
            this.rpvDanhSachTrieuTap.Size = new System.Drawing.Size(784, 561);
            this.rpvDanhSachTrieuTap.TabIndex = 8;
            // 
            // frmInDSTrieuTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rpvDanhSachTrieuTap);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInDSTrieuTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN DANH SÁCH TRIỆU TẬP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInDSTrieuTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDSTrieuTap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLichTrieuTap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpvDanhSachTrieuTap;
        public System.Windows.Forms.BindingSource bsDSTrieuTap;
        public System.Windows.Forms.BindingSource bsLichTrieuTap;

    }
}