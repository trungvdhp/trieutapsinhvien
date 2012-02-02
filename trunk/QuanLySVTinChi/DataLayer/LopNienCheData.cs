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
    public class LopNienCheData
    {
        /// <summary>
        /// Lấy danh sách sinh viên có đăng ký
        /// </summary>
        /// <param name="tuKhoa">Từ khóa - danh sách mã lớp</param>
        /// <returns>Bảng danh sách sinh viên có đăng ký</returns>
        public DataTable LayDsSVTheoLop(TuKhoaInfo tuKhoa, Boolean coDangKy)
        {
            DataService m_LopNienCheData = new DataService();
            String m_sql = "";
            if (!coDangKy)
                m_sql = "SELECT DISTINCT Lop, MaSV, Ho, Ten FROM SinhVien sv WHERE " + tuKhoa.ToString();
            else
                m_sql = "SELECT DISTINCT Lop, dk.MaSV, Ho, Ten FROM DangKy dk INNER JOIN SinhVien sv ON dk.MaSV = sv.MaSV WHERE " + tuKhoa.ToString();
            OleDbCommand cmd = new OleDbCommand(m_sql);
            for (int i = 0; i < tuKhoa.Length; ++i )
            {
                cmd.Parameters.Add(tuKhoa.Field + i, OleDbType.VarChar).Value = tuKhoa[i];
            }
            m_LopNienCheData.Load(cmd);
            /*StreamWriter sw = new StreamWriter("truyvan1.sql", false,
                         Encoding.Unicode);
            sw.WriteLine(cmd.CommandText);
            sw.Close();*/
            return m_LopNienCheData;
        }
    }
}
