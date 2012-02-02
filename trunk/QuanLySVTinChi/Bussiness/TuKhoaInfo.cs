using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TrieuTapSinhVien.Bussiness
{
    public class TuKhoaInfo
    {
        String[] str;
        String m_Field;
        String m_Prefix;

        public String Field
        {
            get { return m_Field; }
            set { m_Field = value; }
        }

        public String Prefix
        {
            get { return m_Prefix; }
            set { m_Prefix = value; }
        }

        public TuKhoaInfo(String tuKhoa, String field)
        {
            str = tuKhoa.Split(';');
            m_Field = field;
            m_Prefix = field;
        }

        public TuKhoaInfo(String tuKhoa, String field, String prefix)
        {
            str = tuKhoa.Split(';');
            m_Field = field;
            m_Prefix = prefix;
        }

        public String this[int index]
        {
            get { return str[index]; }
        }

        public int Length
        {
            get { return str.Length; }
        }

        public override String ToString()
        {
            String s = "";
            if (str.Length>0)
                s += "(" + m_Field + " LIKE '%' & @"  + m_Prefix + "0 & '%')";
            for(int i=1; i<str.Length; ++i)
            {
                s += " OR (" + m_Field + " LIKE '%' & @" + m_Prefix + i + " & '%')";
            }
            return s;
        }

    }
}
