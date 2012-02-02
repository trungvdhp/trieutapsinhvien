using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrieuTapSinhVien
{
    public partial class frmInLopTinChi : Form
    {
        public frmInLopTinChi()
        {
            InitializeComponent();
        }

        private void frmInLopTinChi_Load(object sender, EventArgs e)
        {

            this.rpvLopTinChi.RefreshReport();
        }
    }
}
