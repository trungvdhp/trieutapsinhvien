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
    public class LopTinChiCtrl
    {
        #region Fields
        LopTinChiData   m_LopTinChiData = new LopTinChiData();
        #endregion
        #region Hien thi
        /// <summary>
        /// Hiển thị danh sách các sinh viên thuộc lớp tín chỉ
        /// </summary>
        /// <param name="dGV">Lưới hiển thị</param>
        /// <param name="bN">Thanh điều khiển ràng buộc dữ liệu trên lưới</param>
        /// <param name="tuKhoa">Từ khóa - danh sách mã lớp tín chỉ học phần hoặc tên học phần</param>
        public void HienThi(DataGridView dGV, BindingNavigator bN, TuKhoaInfo[] tuKhoa, String dieuKien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_LopTinChiData.LayDsSVTheoLop(tuKhoa, dieuKien) ;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
    }
}
