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
    public class DSTrieuTapData
    {
        /// <summary>
        /// Lấy danh sách sinh viên có đăng ký
        /// </summary>
        /// <param name="tuKhoa">Từ khóa - danh sách mã lớp</param>
        /// <returns>Bảng danh sách sinh viên có đăng ký</returns>
        public DataTable LayDsSVTheoLop(TuKhoaInfo tuKhoa)
        {
            DataService m_DSTrieuTapData = new DataService();
            OleDbCommand cmd = new OleDbCommand(
            "SELECT DISTINCT Lop, dk.MaSV, Ho, Ten FROM DangKy dk INNER JOIN (SELECT * FROM SinhVien WHERE " + tuKhoa.ToString() + ") " + 
            "AS sv ON dk.MaSV = sv.MaSV");

            for (int i = 0; i < tuKhoa.Length; ++i )
            {
                cmd.Parameters.Add(tuKhoa.Field + i, OleDbType.VarChar).Value = tuKhoa[i];
            }
            m_DSTrieuTapData.Load(cmd);
            /*StreamWriter sw = new StreamWriter("D:\\truyvan1.sql", false,
                         Encoding.Unicode);
            sw.WriteLine(cmd.CommandText);
            sw.Close();*/
            return m_DSTrieuTapData;
        }

        /// <summary>
        /// Lấy danh sách sinh viên không triệu tập
        /// </summary>
        /// <param name="tuKhoa">Từ khóa - danh sách mã lớp</param>
        /// <param name="dieuKien">Điều kiện về lịch triệu tập</param>
        /// <returns>Bảng danh sách sinh viên không triệu tập</returns>
        public DataTable LayDSSVKhongTrieuTap(TuKhoaInfo tuKhoa, String dieuKien)
        {
            DataService m_DSTrieuTapData = new DataService();
            String my_sql = "SELECT DISTINCT dk.MaSV FROM (DangKy AS dk INNER JOIN (SELECT MaSV FROM SinhVien WHERE " + tuKhoa.ToString() + ") " + 
                "AS sv ON dk.MaSV = sv.MaSV) INNER JOIN (SELECT MaHP, MaNH FROM ThoiKhoaBieu tkb WHERE " + dieuKien + ") AS B2 ON dk.MaHP = B2.MaHP AND dk.MaNH=B2.MaNH";
            OleDbCommand cmd = new OleDbCommand(
            my_sql);
            for (int i = 0; i < tuKhoa.Length; ++i)
            {
                cmd.Parameters.Add(tuKhoa.Field + i, OleDbType.VarChar).Value = tuKhoa[i];
            }
            /*StreamWriter sw = new StreamWriter("truyvan2.sql", false,
                        Encoding.Unicode);
            sw.WriteLine(cmd.CommandText);
            sw.Close();*/
            m_DSTrieuTapData.Load(cmd);
            return m_DSTrieuTapData;
        }
    }
}
