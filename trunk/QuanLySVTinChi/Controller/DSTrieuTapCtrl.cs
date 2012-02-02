using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using TrieuTapSinhVien.Bussiness;
using TrieuTapSinhVien.DataLayer;
using TrieuTapSinhVien.Components;

namespace TrieuTapSinhVien.Controller
{
    public class DSTrieuTapCtrl
    {
        #region Fields
        DSTrieuTapData   m_DSTrieuTapData = new DSTrieuTapData();
        #endregion
        #region Hien thi
        /// <summary>
        /// Hiển thị danh sách các sinh viên cần triệu tập
        /// </summary>
        /// <param name="dGV">Lưới hiển thị</param>
        /// <param name="bN">Thanh điều khiển ràng buộc dữ liệu trên lưới</param>
        /// <param name="tuKhoa">Từ khóa - danh sách mã lớp</param>
        /// <param name="dieuKien">Điều kiện về lịch triệu tập</param>
        public void HienThi(DataGridView dGV, BindingNavigator bN, TuKhoaInfo tuKhoa, String dieuKien)
        {
            DataTable dt1 = m_DSTrieuTapData.LayDSSVKhongTrieuTap(tuKhoa,dieuKien);
            DataTable dt2 = m_DSTrieuTapData.LayDsSVTheoLop(tuKhoa);
            if (dt1.Rows.Count > 0)
            {
                int min = Convert.ToInt32(dt1.Rows[0][0].ToString());
                int max = min;
                int t;

                //Tìm mã sinh viên lớn nhất và nhỏ nhất trong danh sách sinh viên không triệu tập
                foreach (DataRow dr in dt1.Rows)
                {
                    t = Convert.ToInt32(dr[0].ToString());
                    if (t < min) min = t;
                    if (t > max) max = t;
                }

                //Đánh chỉ số cho các mã sinh viên này
                bool[] a = new bool[max - min + 1];

                foreach (DataRow dr in dt1.Rows)
                {
                    t = Convert.ToInt32(dr[0].ToString());
                    a[t - min] = true;
                }

                //Lưu lại danh sách các sinh viên cần xóa đi trong danh sách sinh viên có đăng ký
                List<DataRow> lst = new List<DataRow>();

                foreach (DataRow dr in dt2.Rows)
                {
                    t = Convert.ToInt32(dr[1].ToString());
                    if (t - min >= 0 && t - min <= max - min && a[t - min] == true)
                        lst.Add(dr);
                }

                //Xóa các sinh viên không triệu tập
                foreach (DataRow dr in lst)
                {
                    dt2.Rows.Remove(dr);
                }
            }

            //Gán dữ liệu 
            BindingSource bS = new BindingSource();
            bS.DataSource = dt2;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
    }
}
