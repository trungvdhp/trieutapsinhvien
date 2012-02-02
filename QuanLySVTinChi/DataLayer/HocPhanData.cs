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
    public class HocPhanData
    {
        /// <summary>
        /// Lấy danh sách sinh viên có đăng ký
        /// </summary>
        /// <param name="tuKhoa">Từ khóa - danh sách mã lớp tín chỉ học phần</param>
        /// <returns>Bảng danh sách sinh viên có đăng ký</returns>
        public DataTable LayDsSVTheoLop(TuKhoaInfo[] tuKhoa, String dieuKien)
        {
            DataService m_HocPhanData = new DataService();
            String m_sql = "";
            m_sql = "SELECT sv.Lop, sv.MaSV, sv.Ho, sv.Ten, dk.MaHP + '.N' + dk.MaNH AS MaLopHP, "
                + "hp.TenHP, hp.TCHT, tkb.Thu, tkb.TietBD, tkb.TietBD + tkb.SoTiet - 1 AS TietKT, tkb.NgayBD, tkb.NgayKT "
                + "FROM (HocPhan hp RIGHT JOIN (SinhVien sv INNER JOIN DangKy dk ON sv.MaSV = dk.MaSV) "
                + "ON (dk.MaHP = hp.MaHP)) LEFT JOIN ThoiKhoaBieu tkb ON (dk.MaHP = tkb.MaHP) AND (dk.MaNH = tkb.MaNH) WHERE ("
                + tuKhoa[0].ToString() + ")";    
            for (int i = 1; i < tuKhoa.Length; ++i)
                m_sql += dieuKien + "(" + tuKhoa[i].ToString() + ")";
            OleDbCommand cmd = new OleDbCommand(m_sql);
            for (int i = 0; i < tuKhoa.Length; ++i )
            {
                for (int j = 0; j < tuKhoa[i].Length; ++j)
                {
                    cmd.Parameters.Add(tuKhoa[i].Prefix + j, OleDbType.VarWChar).Value = tuKhoa[i][j];
                }
            }
            m_HocPhanData.Load(cmd);
            /*StreamWriter sw = new StreamWriter("truyvan1.sql", false,
                         Encoding.Unicode);
            sw.WriteLine(cmd.CommandText);
            sw.Close();*/
            return m_HocPhanData;
        }
    }
}
