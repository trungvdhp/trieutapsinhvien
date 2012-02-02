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
    public class KhoaData
    {
        /// <summary>
        /// Lấy danh sách khoa
        /// </summary>
        /// <returns>Bảng danh sách các khoa</returns>
        public DataTable LayDsKhoa()
        {
            DataService m_KhoaData = new DataService();  
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Khoa");
            m_KhoaData.Load(cmd);
            /*StreamWriter sw = new StreamWriter("truyvan1.sql", false,
                         Encoding.Unicode);
            sw.WriteLine(cmd.CommandText);
            sw.Close();*/
            return m_KhoaData;
        }
    }
}
