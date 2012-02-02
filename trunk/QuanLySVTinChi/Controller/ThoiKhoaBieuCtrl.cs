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
    public class ThoiKhoaBieuCtrl
    {
        #region Fields
        ThoiKhoaBieuData   m_ThoiKhoaBieuData = new ThoiKhoaBieuData();
        #endregion
        #region Hien thi
        /// <summary>
        /// Hiển thị thời khóa biểu theo các trường tìm kiếm
        /// </summary>
        /// <param name="dGV">Lưới hiển thị</param>
        /// <param name="bN">Thanh điều khiển ràng buộc dữ liệu trên lưới</param>
        /// <param name="tuKhoa">Từ khóa - danh sách các từ khóa</param>
        public void HienThi(DataGridView dGV, BindingNavigator bN, TuKhoaInfo[] tuKhoa, String dieuKien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_ThoiKhoaBieuData.LayThoiKhoaBieu(tuKhoa, dieuKien) ;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
    }
}
