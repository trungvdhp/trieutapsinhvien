using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrieuTapSinhVien.Properties;
using TrieuTapSinhVien.Components;
using TrieuTapSinhVien.Controller;
using TrieuTapSinhVien.Bussiness;

namespace TrieuTapSinhVien
{
    public partial class frmMain : Form
    {
        #region Fields
        frmKetNoiCSDL m_FrmKetNoiCSDL = null;
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer.Start();
            KetNoiCSDL.LayChuoiKetNoi(Settings.Default.Database,Settings.Default.Password, Settings.Default.Security);
            KetNoiCSDL.MoKetNoi();
            if (KetNoiCSDL.DaKetNoi)
            {
                KetNoiCSDL.DongKetNoi();
                lblTinhTrangKetNoi.Text = "  Đã kết nối đến cơ sở dữ liệu " + Settings.Default.Database;
            }
        }
        #endregion

        #region Add TabPage
        private void AddTab(Form frm)
        {
            if (KetNoiCSDL.DaKetNoi == false)
            {
                ketNoiCSDLToolStripMenuItem.PerformClick();
                return;
            }
            TabPage tp = GetNewTabPage(frm.Text);
            if (tp.Text == "New")
            {
                tabControl.Visible 
                    = dongTrangHienTaiToolStripMenuItem.Visible
                    = closeCurrentPageToolStripMenuItem.Visible
                    = dongTatCaTrangKhacToolStripMenuItem.Visible 
                    = closeOtherPagesToolStripMenuItem.Visible
                    = dongTatCaToolStripMenuItem.Visible 
                    = closeAllPagesToolStripMenuItem.Visible
                    = btnDongTab.Visible = true;
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                tp.Text = frm.Text;
                tp.Controls.Add(frm);
                tabControl.TabPages.Add(tp);
                frm.Show();
            }
            tabControl.SelectTab(tp);
        }

        private TabPage GetNewTabPage(string name)
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Text == name)
                    return tabPage;
            }
            return new TabPage("New");
        }
        #endregion

        #region Tình trạng
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("h:mm:ss tt  d/MM/yyyy");
        }
        #endregion

        #region Đóng TabPage
        private void btnDongTab_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có thực sự muốn đóng trang " + tabControl1.SelectedTab.Text,
            //"Xác nhận đóng trang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            if(tabControl.TabCount >0)
            {
                int i = tabControl.SelectedIndex;
                tabControl.SelectedTab.Dispose();
                if (tabControl.TabCount == 0) 
                    btnDongTab.Visible = tabControl.Visible 
                        = dongTrangHienTaiToolStripMenuItem.Visible
                        = closeCurrentPageToolStripMenuItem.Visible
                        = dongTatCaTrangKhacToolStripMenuItem.Visible 
                        = closeOtherPagesToolStripMenuItem.Visible
                        = dongTatCaToolStripMenuItem.Visible
                        = closeAllPagesToolStripMenuItem.Visible
                        = false;
                if (i > 0)
                    tabControl.SelectTab(i - 1);
            }
            //}
        }
        #endregion

        #region Show form
        #region Hệ thống
        private void ketNoiCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_FrmKetNoiCSDL == null || m_FrmKetNoiCSDL.IsDisposed)
                m_FrmKetNoiCSDL = new frmKetNoiCSDL();
            if (m_FrmKetNoiCSDL.ShowDialog() == DialogResult.OK)
            {
                lblTinhTrangKetNoi.Text = "  Đã kết nối đến cơ sở dữ liệu " + Settings.Default.Database;
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        #region Triệu tập
        private void trieuTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmTrieuTapSV());
        }
        #endregion

        #region Lớp tín chỉ
        private void lopTinChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmLopTinChi());
        }
        #endregion

        #region Lớp niên chế
        private void lopNienCheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmLopNienChe());
        }
        #endregion

        #region Khoa
        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmKhoa());
        }
        #endregion

        #region Hiển thị
        private void thanhCongCuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolBarToolStripMenuItem.Checked = thanhCongCuToolStripMenuItem.Checked =
                toolStrip.Visible = !toolStrip.Visible;
            if (toolStrip.Visible == false)
                btnDongTab.Location = new Point(btnDongTab.Location.X, btnDongTab.Location.Y - 25);
            else
                btnDongTab.Location = new Point(btnDongTab.Location.X, btnDongTab.Location.Y + 25);
        }

        private void thanhTinhTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBarToolStripMenuItem.Checked = thanhTinhTrangToolStripMenuItem.Checked =
                statusStrip.Visible = !statusStrip.Visible;
        }

        private void dongTrangHienTaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDongTab.PerformClick();
        }

        private void thanhTrinhDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuBarToolStripMenuItem.Checked = thanhTrinhDonToolStripMenuItem.Checked =
                menuStrip.Visible = !menuStrip.Visible;
            if (menuStrip.Visible == false)
                btnDongTab.Location = new Point(btnDongTab.Location.X, btnDongTab.Location.Y - 25);
            else
                btnDongTab.Location = new Point(btnDongTab.Location.X, btnDongTab.Location.Y + 25);
        }

        private void dongTatCaTrangKhacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.TabCount > 1)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn đóng tất cả các trang khác?",
                    "Xác nhận đóng trang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TabPage tp = tabControl.SelectedTab;
                        foreach (TabPage tabPage in tabControl.TabPages)
                        {
                            if (string.Compare(tabPage.Text, tp.Text) != 0)
                                tabControl.TabPages.Remove(tabPage);
                        }
                    }
                }
            }
            catch { }
        }

        private void dongTatCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount > 0)
            {
                if (MessageBox.Show("Bạn có thực sự muốn đóng tất cả các trang?",
                    "Xác nhận đóng trang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tabControl.TabPages.Clear();
                    btnDongTab.Visible = tabControl.Visible
                        = dongTrangHienTaiToolStripMenuItem.Visible
                        = closeCurrentPageToolStripMenuItem.Visible
                        = dongTatCaTrangKhacToolStripMenuItem.Visible
                        = closeOtherPagesToolStripMenuItem.Visible
                        = dongTatCaToolStripMenuItem.Visible
                        = closeAllPagesToolStripMenuItem.Visible
                        = false;
                }
            }
        }
        #endregion

        #region Trợ giúp
        private void huongDanSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("HuongDan.htm");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy tệp tin HuongDan.htm, có thể bạn đã dời nó khỏi thư mục chạy của chương trình!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void thongTinPhanMemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox frm = new frmAboutBox();
            frm.ShowDialog();
        }
        #endregion

        #endregion

        private void thoiKhoaBieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmThoiKhoaBieu());
        }

        private void danhSachHocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmDangKy());
        }
    }
}
