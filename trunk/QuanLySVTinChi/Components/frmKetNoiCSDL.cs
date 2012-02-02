using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrieuTapSinhVien.Components;
using TrieuTapSinhVien.Properties;
using System.Data.SqlClient;

namespace TrieuTapSinhVien
{
    public partial class frmKetNoiCSDL : Form
    {
        public frmKetNoiCSDL()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (txtCSDL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCSDL.Select();
                return;
            }
            if (chkMatKhau.Checked == false)
                KetNoiCSDL.LayChuoiKetNoi(txtCSDL.Text, "", false);
            else
            {
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Select();
                    return;
                }
                KetNoiCSDL.LayChuoiKetNoi(txtCSDL.Text,txtMatKhau.Text, true);
            }
            KetNoiCSDL.MoLaiKetNoi();
            if (KetNoiCSDL.DaKetNoi)
            {
                MessageBox.Show("Kết nối CSDL thành công", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                KetNoiCSDL.DongKetNoi();
                KetNoiCSDL.LuuChuoiKetNoi();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến máy chủ.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                KetNoiCSDL.LayChuoiKetNoi(Settings.Default.Database,Settings.Default.Password, Settings.Default.Security);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmKetNoiCSDL_KeyDown(object sender, KeyEventArgs e)
        {
             if(e.KeyCode == Keys.Enter)
                btnKetNoi_Click(sender, e);
             else if(e.KeyCode == Keys.Escape)
                btnHuyBo_Click(sender, e);
        }

        private void chkMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = chkMatKhau.Checked;
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "Access 2002 - 2003 Database(*.mdb)|*.mdb";
            open.InitialDirectory = Settings.Default.Database;
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtCSDL.Text = open.FileName;
            }
        }

        private void frmKetNoiCSDL_Load(object sender, EventArgs e)
        {
            KetNoiCSDL.HienThiThongTinKetNoi(txtCSDL,txtMatKhau,chkMatKhau);
        }

        private void llblCapNhatCSDL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mediafire.com/?54h4qd3rw4bvs");
        }
    }
}
