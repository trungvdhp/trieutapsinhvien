using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrieuTapSinhVien.Controller;

namespace TrieuTapSinhVien
{
    public partial class frmKhoa : Form
    {
        KhoaCtrl m_KhoaCtrl = new KhoaCtrl();
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            m_KhoaCtrl.HienThi(dgvKhoa, bindingNavigatorKhoa);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmKhoa_Load(sender, e);
        }

    }
}
