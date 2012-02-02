using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrieuTapSinhVien
{
    public partial class frmInHocPhanDangKy : Form
    {
        public frmInHocPhanDangKy()
        {
            InitializeComponent();
        }

        private void frmInHocPhanDangKy_Load(object sender, EventArgs e)
        {

            this.rpvHocPhan.RefreshReport();
        }
    }
}
