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
    public class LopNienCheCtrl
    {
        #region Fields
        LopNienCheData   m_LopNienCheData = new LopNienCheData();
        #endregion
        #region Hien thi
        /// <summary>
        /// Hiển thị danh sách các sinh viên thuộc lớp
        /// </summary>
        /// <param name="dGV">Lưới hiển thị</param>
        /// <param name="bN">Thanh điều khiển ràng buộc dữ liệu trên lưới</param>
        /// <param name="tuKhoa">Từ khóa - danh sách mã lớp</param>
        /// <param name="coDangKy">coDangKy = true lấy danh SV có đăng ký, ngược lại lấy danh sách tất cả SV</param>
        public void HienThi(DataGridView dGV, BindingNavigator bN, TuKhoaInfo tuKhoa, Boolean coDangKy)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_LopNienCheData.LayDsSVTheoLop(tuKhoa, coDangKy);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
    }
}
