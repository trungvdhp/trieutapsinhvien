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
    public class KhoaCtrl
    {
        #region Fields
        KhoaData   m_KhoaData = new KhoaData();
        #endregion
        #region Hien thi
        /// <summary>
        /// Hiển thị danh sách các khoa lên lưới
        /// </summary>
        /// <param name="dGV">Lưới danh sách các khoa</param>
        /// <param name="bN"></param>
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhoaData.LayDsKhoa();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
    }
}
