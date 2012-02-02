using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Text;
using System.IO;
using TrieuTapSinhVien.Components;
using TrieuTapSinhVien.Bussiness;

namespace TrieuTapSinhVien.DataLayer
{
    public class ThoiKhoaBieuData
    {
        /// <summary>
        /// Lấy danh sách sinh viên có đăng ký
        /// </summary>
        /// <param name="tuKhoa">Từ khóa - danh sách mã lớp tín chỉ học phần</param>
        /// <returns>Bảng danh sách sinh viên có đăng ký</returns>
        public DataTable LayThoiKhoaBieu(TuKhoaInfo[] tuKhoa, String dieuKien)
        {
            DataService m_ThoiKhoaBieuData = new DataService();
            String m_sql = "";
            m_sql = "SELECT tkb.MaHP+'.N'+MaNH AS MaLopHP, TenHP, DoiTuong, BoMon, Thu, TietBD, TietBD+SoTiet-1 AS TietKT, NgayBD, NgayKT FROM ThoiKhoaBieu tkb LEFT JOIN HocPhan hp ON tkb.MaHP = hp.MaHP WHERE (" + tuKhoa[0].ToString() + ")";
            for (int i = 1; i < tuKhoa.Length; ++i)
                m_sql += dieuKien + "(" + tuKhoa[i].ToString() + ")";
            OleDbCommand cmd = new OleDbCommand(m_sql);
            for (int i = 0; i < tuKhoa.Length; ++i )
            {
                for (int j = 0; j < tuKhoa[i].Length; ++j )
                    cmd.Parameters.Add(tuKhoa[i].Prefix + j, OleDbType.VarWChar).Value = tuKhoa[i][j];
            }
            m_ThoiKhoaBieuData.Load(cmd);
            /*StreamWriter sw = new StreamWriter("truyvan1.sql", false,
                         Encoding.Unicode);
            sw.WriteLine(cmd.CommandText);
            sw.Close();*/
            return m_ThoiKhoaBieuData;
        }
    }
}
