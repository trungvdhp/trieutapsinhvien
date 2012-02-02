using System;
using System.Collections.Generic;
using System.Text;

namespace TrieuTapSinhVien.Bussiness
{
    public class SinhVienInfo
    {
        public SinhVienInfo()
        {

        }

        private String m_MaSV;
        public String MaSV
        {
            get { return m_MaSV; }
            set { m_MaSV = value; }
        }

        private String m_Ho;
        public String Ho
        {
            get { return m_Ho; }
            set { m_Ho = value; }
        }

        private String m_Ten;
        public String Ten
        {
            get { return m_Ten; }
            set { m_Ten = value; }
        }

        private String m_Lop;
        public String Lop
        {
            get { return m_Lop; }
            set { m_Lop = value; }
        }

        private String m_MaLopHP;
        public String MaLopHP
        {
            get { return m_MaLopHP; }
            set { m_MaLopHP = value; }
        }

        private String m_TenHP;
        public String TenHP
        {
            get { return m_TenHP; }
            set { m_TenHP = value; }
        }
    }
}
