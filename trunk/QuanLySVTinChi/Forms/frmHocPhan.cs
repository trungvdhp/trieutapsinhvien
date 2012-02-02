using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrieuTapSinhVien.Bussiness;
using TrieuTapSinhVien.Controller;

namespace TrieuTapSinhVien
{
    public partial class frmDangKy : Form
    {
        HocPhanCtrl m_HocPhanCtrl = new HocPhanCtrl();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TuKhoaInfo[] tuKhoa = new TuKhoaInfo[4];
            for (int i = 0; i < 4; ++i)
            {
                tuKhoa[i] = new TuKhoaInfo(txtTuKhoa.Text, "sv."+dgvHocPhan.Columns[i].DataPropertyName);
            }
            m_HocPhanCtrl.HienThi(dgvHocPhan, bdnHocPhan, tuKhoa, dieuKienLocToolStripComboBox.Text == "Và" ? " AND " : " OR ");
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        private void dieuKienLocToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmInHocPhanDangKy frm = new frmInHocPhanDangKy();
            frm.bsHocPhanDangKy.DataSource = dgvHocPhan.DataSource;
            frm.rpvHocPhan.RefreshReport();
            frm.Show();
        }
    }
}
