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
    public class HocPhanCtrl
    {
        #region Fields
        HocPhanData   m_HocPhanData = new HocPhanData();
        #endregion
        #region Hien thi
        /// <summary>
        /// Hiển thị danh sách các học phần mà sinh viên đã đăng ký
        /// </summary>
        /// <param name="dGV">Lưới hiển thị</param>
        /// <param name="bN">Thanh điều khiển ràng buộc dữ liệu trên lưới</param>
        /// <param name="tuKhoa">Từ khóa - thông tin tìm kiếm như Lớp, Mã sinh viên, Họ, Tên</param>
        public void HienThi(DataGridView dGV, BindingNavigator bN, TuKhoaInfo[] tuKhoa, String dieuKien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocPhanData.LayDsSVTheoLop(tuKhoa, dieuKien) ;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
    }
}
