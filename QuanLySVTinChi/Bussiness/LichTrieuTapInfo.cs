using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TrieuTapSinhVien.Bussiness
{
    /// <summary>
    /// Lớp lịch triệu tập - chứa danh sách các ngày triệu tập
    /// </summary>
    public class LichTrieuTapInfo
    {
        List<NgayTrieuTapInfo> lst;

        public LichTrieuTapInfo()
        {
            lst = new List<NgayTrieuTapInfo>();
        }

        /// <summary>
        /// Số các ngày triệu tập trong lịch triệu tập
        /// </summary>
        public int Count
        {
            get { return lst.Count; }
        }

        /// <summary>
        /// Thêm một ngày triệu tập vào lịch triệu tập
        /// </summary>
        /// <param name="p">Ngày triệu tập</param>
        /// <returns>Trả về true nếu thêm được</returns>
        public Boolean Add(NgayTrieuTapInfo p)
        {
            if (p.TietBatDau > p.TietKetThuc)
                return false;
            for (int i = 0; i < lst.Count; ++i)
                if (lst[i] == p)
                    return false;
            this.lst.Add(p);
            return true;
        }

        /// <summary>
        /// Thêm danh sách các ngày triệu tập vào lịch triệu tập
        /// </summary>
        /// <param name="p1">Ngày bắt đầu</param>
        /// <param name="p2">Ngày kết thúc</param>
        /// <returns>Trả về số ngày không trùng mà thêm được</returns>
        public int Add(NgayTrieuTapInfo p1, NgayTrieuTapInfo p2)
        {
            if (p1 > p2)
                return -1;
            int count = 0;
            for(NgayTrieuTapInfo p = p1; p < p2; p++)
            {
                if (this.Add(p) == true)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Nạp chồng phương thức ToString()
        /// </summary>
        /// <returns>Trả về chuỗi điều kiện về lịch triệu tập</returns>
        public override String ToString()
        {
            String s = "";
            if(lst.Count>0)
                s=this.lst[0].ToString();
            for(int i=1; i<this.Count; ++i)
            {
                s += " OR " + this.lst[i].ToString();
            }
            return s;
        }

    }
}
