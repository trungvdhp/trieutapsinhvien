using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrieuTapSinhVien.Controller;
using TrieuTapSinhVien.Components;
using TrieuTapSinhVien.Bussiness;
using TrieuTapSinhVien.Properties;

namespace TrieuTapSinhVien
{
    public partial class frmTrieuTapSV : Form
    {
        DSTrieuTapCtrl m_DSTrieuTapCTrl = new DSTrieuTapCtrl();
        //List các danh sách triệu tập
        List<DataTable[]> lstTrieuTap = new List<DataTable[]>();
        DataTable dtLich = new DataTable();
        public frmTrieuTapSV()
        {
            InitializeComponent();
        }

        private DataTable TaoBangSinhVien()
        {
            DataTable dt = new DataTable();
            foreach(DataGridViewColumn col in dgvDSTrieuTap.Columns)
            {
                dt.Columns.Add(col.DataPropertyName);
            }
            return dt;
        }

        private DataTable TaoBangLich()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgvLichTrieuTap.Columns)
            {
                dt.Columns.Add(col.DataPropertyName);
            }
            dt.Columns[0].DataType = System.Type.GetType("System.DateTime");
            dt.Columns[0].DefaultValue = DateTime.Now;

            dt.Columns[1].DefaultValue = "0";
            dt.Columns[2].DefaultValue = "1";
            dt.Columns[3].DefaultValue = "và";
            return dt;
        }

        private void KhoiTaoLuoi()
        {
            //Khởi tạo lưới lịch triệu tập
            BindingSource bS1 = new BindingSource();
            bS1.DataSource = TaoBangLich();
            dgvLichTrieuTap.DataSource = bS1;
            //Khởi tạo lưới danh sách triệu tập sinh viên
            BindingSource bS2 = new BindingSource();
            bS2.DataSource = TaoBangSinhVien();
            bdnDSTrieuTap.BindingSource = bS2;
            dgvDSTrieuTap.DataSource = bS2;
        }

        private void frmTrieuTapSV_Load(object sender, EventArgs e)
        {
                BindingSource bS = new BindingSource();
                bS.DataSource = dtLich;
                bdnLichTrieuTap.BindingSource = bS;
                bindingNavigatorAddNewItem.PerformClick();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            frmInDSTrieuTap frm = new frmInDSTrieuTap();
            frm.bsDSTrieuTap.DataSource = dgvDSTrieuTap.DataSource;
            frm.bsLichTrieuTap.DataSource = dgvLichTrieuTap.DataSource;
            frm.rpvDanhSachTrieuTap.RefreshReport();
            frm.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            lstTrieuTap.Add(new DataTable[]{TaoBangLich(), TaoBangSinhVien()});
            KhoiTaoLuoi();
            txtTuKhoa.Clear();
            dtLich.NewRow();
            if (dtLich.Rows.Count == 0)
                refreshToolStripButton.Enabled = searchToolStripButton.Enabled = true;
        }

        private void dgvLichTrieuTap_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bindingNavigatorPositionItem1_TextChanged(object sender, EventArgs e)
        {
        }

        private LichTrieuTapInfo KiemTraLich()
        {
            LichTrieuTapInfo lst = new LichTrieuTapInfo();
            NgayTrieuTapInfo p1, p2;
            DateTime t1,t2;
            int u,v;
            dgvLichTrieuTap.EndEdit(DataGridViewDataErrorContexts.Commit);
            for (int i = 0; i < dgvLichTrieuTap.RowCount-1; ++i )
            {
                u = 0;
                v = 1;
                try
                {
                    u = Convert.ToInt32(dgvLichTrieuTap.Rows[i].Cells[1].Value.ToString());
                    v = Convert.ToInt32(dgvLichTrieuTap.Rows[i].Cells[2].Value.ToString());
                }
                catch { }
                t1 = (DateTime)dgvLichTrieuTap.Rows[i].Cells[0].Value;
                //Kiểm tra tính hợp lệ của tiết bắt đầu và tiết kết thúc
                if(u==0) v=0;
                if(u>v)
                {
                    MessageBox.Show("Tiết bắt đầu lớn hơn tiết kết thúc!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvLichTrieuTap.CurrentCell = dgvLichTrieuTap.Rows[i].Cells[1];
                    return new LichTrieuTapInfo();
                }

                p1 = new NgayTrieuTapInfo(t1, u, v);

                if (dgvLichTrieuTap.Rows[i].Cells[3].Value != null && dgvLichTrieuTap.Rows[i].Cells[3].Value.ToString() == "tới" && i!= dgvLichTrieuTap.RowCount-2)
                {
                    t2 = (DateTime)dgvLichTrieuTap.Rows[i + 1].Cells[0].Value;
                    p2 = new NgayTrieuTapInfo(t2, u, v);
                    if (p1 >= p2)
                    {
                        MessageBox.Show("Ngày triệu tập sớm hơn hoặc trùng ngày triệu tập ở hàng trên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvLichTrieuTap.CurrentCell = dgvLichTrieuTap.Rows[i + 1].Cells[0];
                        return new LichTrieuTapInfo();
                    }
                    else
                    {
                        lst.Add(p1, p2);
                    }
                }
                else
                {
                    lst.Add(p1);
                }
            }
            return lst;
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                LichTrieuTapInfo lst = KiemTraLich();
                if (lst.Count > 0)
                {
                    TuKhoaInfo tuKhoa = new TuKhoaInfo(txtTuKhoa.Text, "Lop");
                    m_DSTrieuTapCTrl.HienThi(dgvDSTrieuTap, bdnDSTrieuTap, tuKhoa, lst.ToString());
                    int index = Convert.ToInt32(bdnLichTrieuTap.PositionItem.Text) - 1;
                    BindingSource bS1 = (BindingSource)dgvLichTrieuTap.DataSource;
                    lstTrieuTap[index][0] = (DataTable)bS1.DataSource;
                    lstTrieuTap[index][0].TableName = txtTuKhoa.Text;
                    BindingSource bS = bdnDSTrieuTap.BindingSource;
                    lstTrieuTap[index][1] = (DataTable)bS.DataSource;
                }
            }
            catch{}
        }

        private void bindingNavigatorMoveNextItem1_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(bdnLichTrieuTap.PositionItem.Text) - 1;

            //Load dữ liệu cho lưới lịch triệu tập
            BindingSource bS1 = new BindingSource();
            bS1.DataSource = lstTrieuTap[index][0].Copy();
            dgvLichTrieuTap.DataSource = bS1;

            //Load lại lần nữa cho an toàn
            bS1.DataSource = lstTrieuTap[index][0].Copy();
            dgvLichTrieuTap.DataSource = bS1;

            txtTuKhoa.Text = lstTrieuTap[index][0].TableName;
            //Load dữ liệu cho lưới danh sách sinh viên cần triệu tập
            BindingSource bS = new BindingSource();
            bS.DataSource = lstTrieuTap[index][1];
            bdnDSTrieuTap.BindingSource = bS;
            dgvDSTrieuTap.DataSource = bS;
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn bạn muốn xóa lịch triệu tập này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt16(bdnLichTrieuTap.PositionItem.Text);
                lstTrieuTap.RemoveAt(id);
                if (id > 0)
                {
                    bindingNavigatorMoveNextItem1_Click(sender, e);
                }
                else
                    refreshToolStripButton.Enabled = searchToolStripButton.Enabled = false;
            }
        }

        private void deleteAllToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn bạn muốn xóa toàn bộ các lịch triệu tập đã soạn thảo không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstTrieuTap.Clear();
                dtLich.Clear();
                KhoiTaoLuoi();
                refreshToolStripButton.Enabled = searchToolStripButton.Enabled = false;
            }
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem1_Click(sender, e);
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchToolStripButton.PerformClick();
        }

        private void btnKetNoiCSDL_Click(object sender, EventArgs e)
        {
            Form frm = new frmKetNoiCSDL();
            frm.ShowDialog();
        }
    }
}
