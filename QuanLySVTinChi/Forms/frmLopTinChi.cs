using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrieuTapSinhVien.Controller;
using TrieuTapSinhVien.Bussiness;

namespace TrieuTapSinhVien
{
    public partial class frmLopTinChi : Form
    {
        LopTinChiCtrl m_LopTinChiCtrl = new LopTinChiCtrl();
        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmInLopTinChi frm = new frmInLopTinChi();
            frm.bsLopTinChi.DataSource = dgvLopTinChi.DataSource;
            frm.rpvLopTinChi.RefreshReport();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TuKhoaInfo[] tuKhoa = new TuKhoaInfo[2];
            tuKhoa[0] = new TuKhoaInfo(txtTuKhoa.Text, "(dk.MaHP+'.N'+MaNH)", "MaLopHP");
            tuKhoa[1] = new TuKhoaInfo(txtTuKhoa.Text, "TenHP");
            m_LopTinChiCtrl.HienThi(dgvLopTinChi, bdnLopTinChi, tuKhoa, dieuKienLocToolStripComboBox.Text == "Và" ? " AND " : " OR ");
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
    }
}
