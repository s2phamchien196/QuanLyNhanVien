using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    class QuanLyLuong
    {
        public static DataTable getThongTinLuong()
        {
            try
            {
            string cauLenh = "select * from BangLuong";
            return KetNoi.loadTable(cauLenh);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
        }
        //
        public static DataTable TimKiem(int MucLuong_Tu, int MuLuong_Den)
        {
            try
            {
                string cauLenh = "select * from BangLuong where MucLuong >= " + MucLuong_Tu + " and MucLuong <= " + MuLuong_Den + " ";
                return KetNoi.loadTable(cauLenh);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
            
        }
        //
        public static DataTable getThongTinLuong_MaLuong(string maluong)
        {
            try
            {
            string cauLenh = "select * from BangLuong where MaBangluong ='"+maluong+"'";
            return KetNoi.loadTable(cauLenh);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
        }
        //
        public static void ThemML(string MaLuong, int MucLuong)
        {
            try
            {
                KetNoi.ThucThi("insert into BangLuong  values ('" + MaLuong + "','" + MucLuong + "')");
                MessageBox.Show("Thêm thành công !!!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        public static void SuaML(string MaLuong, int MucLuong)
        {
            try
            {
                KetNoi.ThucThi("UPDATE BangLuong SET MucLuong = '" + MucLuong + "' where MaBangLuong = '" + MaLuong + "'");
                MessageBox.Show("Update thành công !!!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public static void Delete_ML(string MaLuong)
        {
            try
            {
                KetNoi.ThucThi("DELETE FROM BangLuong WHERE MaBangLuong ='" + MaLuong + "'");
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên có mã: " + MaLuong, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
