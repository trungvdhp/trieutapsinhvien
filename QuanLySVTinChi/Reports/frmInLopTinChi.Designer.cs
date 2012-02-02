namespace TrieuTapSinhVien
{
    partial class frmInLopTinChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInLopTinChi));
            this.bsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.rpvLopTinChi = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bsLopTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvLopTinChi
            // 
            this.rpvLopTinChi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SinhVienInfo";
            reportDataSource1.Value = this.bsLopTinChi;
            this.rpvLopTinChi.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvLopTinChi.LocalReport.ReportEmbeddedResource = "TrieuTapSinhVien.Reports.rptLopTinChi.rdlc";
            this.rpvLopTinChi.Location = new System.Drawing.Point(0, 0);
            this.rpvLopTinChi.Name = "rpvLopTinChi";
            this.rpvLopTinChi.Size = new System.Drawing.Size(784, 561);
            this.rpvLopTinChi.TabIndex = 0;
            // 
            // frmInLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rpvLopTinChi);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInLopTinChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN DANH SÁCH SINH VIÊN THEO MÃ LỚP HỌC PHẦN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLopTinChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpvLopTinChi;
        public System.Windows.Forms.BindingSource bsLopTinChi;

    }
}