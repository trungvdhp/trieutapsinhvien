using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TrieuTapSinhVien.Bussiness
{
    /// <summary>
    /// Lớp ngày triệu tập - chứa ngày, tiết bắt đầu, tiết kết thúc, điều kiện (và hoặc tới)
    /// </summary>
    public class NgayTrieuTapInfo
    {
        #region Biến
        DateTime m_Ngay;
        int m_TietBD;
        int m_TietKT;
        String m_DieuKien;
        #endregion

        #region Các thuộc tính
        public DateTime Ngay
        {
            get { return m_Ngay; }
            set { m_Ngay = value; }
        }

        public int TietBatDau
        {
            get { return m_TietBD; }
            set { m_TietBD = value; }
        }

        public int TietKetThuc
        {
            get { return m_TietKT; }
            set { m_TietKT = value; }
        }

        public String DieuKien
        {
            get { return m_DieuKien; }
            set { m_DieuKien = value; }
        }
        #endregion

        #region Cấu tử có tham số
        public NgayTrieuTapInfo(DateTime ngay, int tietBatdau, int tietKetThuc)
        {
            this.Ngay = new DateTime(ngay.Year, ngay.Month, ngay.Day);
            this.TietBatDau = tietBatdau;
            this.TietKetThuc = tietKetThuc;
        }
        #endregion

        #region Nạp chồng các phương thức và toán tử
        public override bool Equals(System.Object obj)
        {
            // Nếu đối tượng là null trả về false
            if (obj == null)
            {
                return false;
            }

            // Nếu đối tượng không thể chuyển kiểu trả về false
            NgayTrieuTapInfo p = obj as NgayTrieuTapInfo;
            if ((System.Object)p == null)
            {
                return false;
            }

            return p == this;
        }

        public bool Equals(NgayTrieuTapInfo p)
        {
            // Nếu đối tượng là null trả về false
            if ((object)p == null)
            {
                return false;
            }

            return (p == this);
        }

        public static bool operator <(NgayTrieuTapInfo p1, NgayTrieuTapInfo p2)
        {
            if (p1.Ngay < p2.Ngay)
                return true;
            if (p1.TietKetThuc < p2.TietBatDau)
                return true;
            return false;
        }

        public static bool operator >(NgayTrieuTapInfo p1, NgayTrieuTapInfo p2)
        {
            if (p1.Ngay > p2.Ngay)
                return true;
            if (p1.TietBatDau > p2.TietKetThuc)
                return true;
            return false;
        }

        public static bool operator <=(NgayTrieuTapInfo p1, NgayTrieuTapInfo p2)
        {
            return (p1 < p2) || (p1 == p2);
        }

        public static bool operator >=(NgayTrieuTapInfo p1, NgayTrieuTapInfo p2)
        {
            return (p1 > p2) || (p1 == p2);
        }

        public static bool operator ==(NgayTrieuTapInfo p1, NgayTrieuTapInfo p2)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(p1, p2))
            {
                return true;
            }

            // Nếu một trong hai là null thì trả về false.
            if (((object)p1 == null) || ((object)p2 == null))
            {
                return false;
            }

            return (p1.Ngay == p2.Ngay) && ((p1.TietBatDau >= p2.TietBatDau && p1.TietBatDau <= p2.TietKetThuc) ||
                (p1.TietKetThuc >= p2.TietBatDau && p1.TietKetThuc <= p2.TietKetThuc));
        }

        public static bool operator !=(NgayTrieuTapInfo p1, NgayTrieuTapInfo p2)
        {
            if(p1.Ngay != p2.Ngay)
                return true;
            if ((p1.TietBatDau > p2.TietKetThuc) || (p1.TietKetThuc < p2.TietBatDau))
                return true;
            return false;
        }

        public static NgayTrieuTapInfo operator ++(NgayTrieuTapInfo p)
        {
            return p + 1;
        }

        public static NgayTrieuTapInfo operator --(NgayTrieuTapInfo p)
        {
            return p - 1;
        }

        public static NgayTrieuTapInfo operator +(NgayTrieuTapInfo p, int days)
        {
            return new NgayTrieuTapInfo(p.Ngay + new TimeSpan(days, 0, 0, 0), p.TietBatDau, p.TietKetThuc);
        }

        public static NgayTrieuTapInfo operator -(NgayTrieuTapInfo p, int days)
        {
            return new NgayTrieuTapInfo(p.Ngay - new TimeSpan(days, 0, 0, 0), p.TietBatDau, p.TietKetThuc);
        }

        public override string ToString()
        {
            String thu = LayNgayTrongTuan(this.Ngay);
            return "((#" + String.Format("{0:MM/dd/yyyy}", this.Ngay) + "# BETWEEN NgayBD AND NgayKT) AND  ((Thu='" + thu + "' AND " + 
               "((TietBD>=" + this.TietBatDau +" AND TietBD<=" + this.TietKetThuc + ") OR ((TietBD+SoTiet-1)>=" + this.TietBatDau + 
               " AND (TietBD+SoTiet-1)<=" + this.TietKetThuc +")))))";
        }

        public override int GetHashCode()
        {
            return this.Ngay.Day;
        }
        #endregion

        #region Phương thức khác
        /// <summary>
        /// Lấy ngày trong tuần
        /// </summary>
        /// <param name="d">Ngày triệu tập</param>
        /// <returns>Ngày trong tuần</returns>
        private String LayNgayTrongTuan(DateTime d)
        {
            switch (d.DayOfWeek.ToString())
            {
                case "Monday": return "2";
                case "Tuesday": return "3";
                case "Wednesday": return "4";
                case "Thursday": return "5";
                case "Friday": return "6";
                case "Saturday": return "7";
                case "Sunday": return "CN";
                default: return "";
            }
        }
        #endregion        
    }
}
