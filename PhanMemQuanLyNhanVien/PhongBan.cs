using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    class PhongBan
    {
        public static DataTable getLoaiPhongBan(string MaPhong)
        {
            string cauLenh = "select * from PhongBan where MaPhong='"+MaPhong+"'";
            return KetNoi.loadTable(cauLenh);
        }

        public static void ThemPB(string MaPhong, string TenPhong, string ChucNang)
        {
            try
            {
                KetNoi.ThucThi("insert into PhongBan  values ('" + MaPhong + "',N'" + TenPhong + "',N'" + ChucNang + "')");
                MessageBox.Show("Thêm thành công !!!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
           
        }
        public static void SuaPb(string MaPhong, string TenPhong, string ChucNang)
        {
            try
            {
            KetNoi.ThucThi("UPDATE PhongBan SET TenPhong='"+TenPhong+"',ChucNang = '"+ChucNang+"' where MaPhong = '"+MaPhong+"'");
            MessageBox.Show("Update thành công !!!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public static DataTable TimKien_Pb(string TenPhong, string chucnang)
        {
            try
            {
                return KetNoi.loadTable("select * from PhongBan where (TenPhong like N'%" + TenPhong + "%') and (ChucNang like N'%" + chucnang + "%')");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;

        }
        public static void Delete_Pb(string MaPhong)
        {
            try
            {
                KetNoi.ThucThi("DELETE FROM PhongBan WHERE MaPhong ='" + MaPhong + "'");
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên có mã: " + MaPhong, "Thông báo", MessageBoxButtons.YesNo);
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
