namespace TrieuTapSinhVien
{
    partial class frmInLopNienChe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInLopNienChe));
            this.bsLopNienChe = new System.Windows.Forms.BindingSource(this.components);
            this.rpvLopNienChe = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bsLopNienChe)).BeginInit();
            this.SuspendLayout();
            // 
            // bsLopNienChe
            // 
            this.bsLopNienChe.DataSource = typeof(TrieuTapSinhVien.Bussiness.SinhVienInfo);
            // 
            // rpvLopNienChe
            // 
            this.rpvLopNienChe.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SinhVienInfo";
            reportDataSource1.Value = this.bsLopNienChe;
            this.rpvLopNienChe.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvLopNienChe.LocalReport.ReportEmbeddedResource = "TrieuTapSinhVien.Reports.rptLopNienChe.rdlc";
            this.rpvLopNienChe.Location = new System.Drawing.Point(0, 0);
            this.rpvLopNienChe.Name = "rpvLopNienChe";
            this.rpvLopNienChe.Size = new System.Drawing.Size(784, 561);
            this.rpvLopNienChe.TabIndex = 0;
            // 
            // frmInLopNienChe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rpvLopNienChe);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInLopNienChe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN DANH SÁCH SINH VIÊN LỚP NIÊN CHẾ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInLopNienChe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLopNienChe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rpvLopNienChe;
        public System.Windows.Forms.BindingSource bsLopNienChe;

    }
}