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
    public partial class frmLopNienChe : Form
    {
        LopNienCheCtrl m_LopNienCheCtrl = new LopNienCheCtrl();
        public frmLopNienChe()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmInLopNienChe frm = new frmInLopNienChe();
            frm.bsLopNienChe.DataSource = dgvLopNienChe.DataSource;
            frm.rpvLopNienChe.RefreshReport();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TuKhoaInfo tuKhoa = new TuKhoaInfo(txtTuKhoa.Text, "Lop");
            m_LopNienCheCtrl.HienThi(dgvLopNienChe, bdnLopNienChe, tuKhoa, dieuKienLocToolStripComboBox.Text == "Có đăng ký" ? true : false);
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
