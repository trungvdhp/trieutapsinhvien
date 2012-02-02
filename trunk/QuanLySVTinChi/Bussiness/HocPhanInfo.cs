using System;
using System.Collections.Generic;
using System.Text;

namespace TrieuTapSinhVien.Bussiness
{
    public class HocPhanInfo
    {
        public HocPhanInfo()
        {

        }

        private String m_MaHP;
        public String MaHP
        {
            get { return m_MaHP; }
            set { m_MaHP = value; }
        }

        private String m_TenHP;
        public String TenHP
        {
            get { return m_TenHP; }
            set { m_TenHP = value; }
        }

        private String m_TCHT;
        public String TCHT
        {
            get { return m_TCHT; }
            set { m_TCHT = value; }
        }

        private String m_DoiTuong;
        public String DoiTuong
        {
            get { return m_DoiTuong; }
            set { m_DoiTuong = value; }
        }

        private String m_BoMon;
        public String BoMon
        {
            get { return m_BoMon; }
            set { m_BoMon = value; }
        }
    }
}
