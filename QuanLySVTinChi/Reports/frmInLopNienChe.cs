using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrieuTapSinhVien
{
    public partial class frmInLopNienChe : Form
    {
        public frmInLopNienChe()
        {
            InitializeComponent();
        }

        private void frmInLopNienChe_Load(object sender, EventArgs e)
        {

            this.rpvLopNienChe.RefreshReport();
        }
    }
}
