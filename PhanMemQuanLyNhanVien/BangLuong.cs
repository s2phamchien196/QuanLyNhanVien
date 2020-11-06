using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PhanMemQuanLyNhanVien
{
    class BangLuong
    {
        public static DataTable getBangLuong()
        {
            string cauLenh = "select * from BangLuong";
            return KetNoi.loadTable(cauLenh);
        }
    }
}
