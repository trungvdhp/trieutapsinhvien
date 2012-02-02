using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using TrieuTapSinhVien.Properties;

namespace TrieuTapSinhVien.Components
{
    public class KetNoiCSDL
    {
        #region Fields
        public static string m_Condition;
        public static OleDbConnection m_Connection = new OleDbConnection();
        public static string m_ConnectionString;
        public static string m_SqlString;
        private static bool m_ConnectionState;
        public static string databasename;
        public static string password;
        public static bool security;
        #endregion

        #region  Methods
        public static bool DaKetNoi
        {
            get
            {
                return m_ConnectionState;
            }
        }

        public static bool DongKetNoi()
        {
            try
            {
                m_Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đóng kết nối.\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool HuyKetNoi()
        {
            try
            {
                m_Connection.Dispose();
                databasename = "";
                password = "";
                security = true;
                m_ConnectionString = "";
                MessageBox.Show("Hủy kết nối thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                m_ConnectionState = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hủy kết nối." + ex.ToString(), "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Lấy chuỗi kết nối
        /// </summary>
        /// <param name="tencsdl">Đường dẫn tới cơ sở dữ liệu</param>
        /// <param name="matkhau">Mật khẩu</param>
        /// <param name="kieuxacthuc">Kiểu xác thực có mật khẩu = true</param>
        public static void LayChuoiKetNoi(string tencsdl, string matkhau, bool kieuxacthuc)
        {
            try
            {
                databasename = tencsdl;
                password = matkhau;
                security = kieuxacthuc;
                m_ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + databasename;
                if (security == false)
                {
                    m_ConnectionString = m_ConnectionString + ";Persist Security Info=False;";
                }
                else
                {
                    m_ConnectionString = m_ConnectionString + ";Jet OLEDB:Database Password=" + password;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy file cấu hình. Vui lòng khởi động lại chương trình.\n" 
                    + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Lưu chuỗi kết nối vào Settings
        /// </summary>
        public static void LuuChuoiKetNoi()
        {
            try
            {
                Settings.Default.Database = databasename;
                Settings.Default.Password = password;
                Settings.Default.Security = security;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy file cấu hình. Vui lòng khởi động lại chương trình.\n"
                    + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hiển thị thông tin kết nối lên các đối tượng
        /// </summary>
        /// <param name="tencsdl">Đối tượng hiển thị đường dẫn cơ sở dữ liệu</param>
        /// <param name="matkhau">Đối tượng hiển thị mật khẩu</param>
        /// <param name="kieuxacthuc">Biến xác định kiểu xác thực</param>
        public static void HienThiThongTinKetNoi(object tencsdl, object matkhau, object kieuxacthuc)
        {
            try
            {
                ((TextBox)tencsdl).Text = databasename;
                ((TextBox)matkhau).Text = password;
                ((CheckBox)kieuxacthuc).Checked = security;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gán thông tin kết nối.\n" + ex.ToString(), "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void MoKetNoi()
        {
            if (!MoLaiKetNoi())
            {
                new frmKetNoiCSDL().ShowDialog();
            }
        }

        public static bool MoLaiKetNoi()
        {
            m_Connection = new OleDbConnection();
            m_Connection.ConnectionString = m_ConnectionString;
            //MessageBox.Show(m_ConnectionString);
            try
            {
                m_Connection.Open();
                m_ConnectionState = true;
                return true;
            }
            catch//(Exception e)
            {
                //MessageBox.Show(e.Message);
                m_ConnectionState = false;
                return false;
            }
        }
        #endregion  
    }
}
