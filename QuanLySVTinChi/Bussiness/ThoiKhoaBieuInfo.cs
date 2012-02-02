using System;
using System.Collections.Generic;
using System.Text;

namespace TrieuTapSinhVien.Bussiness
{
    public class ThoiKhoaBieuInfo
    {
        public ThoiKhoaBieuInfo()
        {

        }

        private SinhVienInfo m_SinhVien;
        public SinhVienInfo SinhVien
        {
            get { return m_SinhVien; }
            set { m_SinhVien = value; }
        }

        private String m_MaLopHP;
        public String MaLopHP
        {
            get { return m_MaLopHP; }
            set { m_MaLopHP = value; }
        }

        private HocPhanInfo m_HocPhan;
        public HocPhanInfo HocPhan
        {
            get { return m_HocPhan; }
            set { m_HocPhan = value; }
        }

        private String m_Thu;
        public String Thu
        {
            get { return m_Thu; }
            set { m_Thu = value; }
        }

        private String m_TietBD;
        public String TietBD
        {
            get { return m_TietBD; }
            set { m_TietBD = value; }
        }

        private String m_TietKT;
        public String TietKT
        {
            get { return m_TietKT; }
            set { m_TietKT = value; }
        }

        private String m_NgayBD;
        public String NgayBD
        {
            get { return m_NgayBD; }
            set { m_NgayBD = value; }
        }

        private String m_NgayKT;
        public String NgayKT
        {
            get { return m_NgayKT; }
            set { m_NgayKT = value; }
        }

    }
}
