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
    public partial class frmThoiKhoaBieu : Form
    {
        ThoiKhoaBieuCtrl m_ThoiKhoaBieuCtrl = new ThoiKhoaBieuCtrl();
        public frmThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TuKhoaInfo[] tuKhoa = new TuKhoaInfo[4];
            tuKhoa[0] = new TuKhoaInfo(txtTuKhoa.Text, "(tkb.MaHP+'.N'+MaNH)", "MaLopHP");
            for(int i=1; i<4; ++i)
            {
                tuKhoa[i] = new TuKhoaInfo(txtTuKhoa.Text, dgvThoiKhoaBieu.Columns[i].DataPropertyName);
            }
            m_ThoiKhoaBieuCtrl.HienThi(dgvThoiKhoaBieu, bdnThoiKhoaBieu, tuKhoa, dieuKienLocToolStripComboBox.Text == "Và" ? " AND " : " OR ");
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
