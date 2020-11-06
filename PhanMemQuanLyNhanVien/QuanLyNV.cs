using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PhanMemQuanLyNhanVien.Properties;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    class QuanLyNV
    {
        public static DataTable getThongtinNv()
        {
           return KetNoi.loadTable("select MaNhanVien,HoTen,Ngaysinh,Gioitinh,TenTruongDH,NgayTotNghiep,NgayVaoCongTy,NgayThangNghi,TenPhong,MucLuong from NhanVien join PhongBan on NhanVien.MaPhong = PhongBan.MaPhong join BangLuong on NhanVien.MaBangLuong = BangLuong.MaBangluong");
        }
        public static DataTable getNv_Ma(string manv)
        {
            return KetNoi.loadTable("select MaNhanVien,HoTen,Ngaysinh,Gioitinh,TenTruongDH,NgayTotNghiep,NgayVaoCongTy,NgayThangNghi,TenPhong,MucLuong from NhanVien join PhongBan on NhanVien.MaPhong = PhongBan.MaPhong join BangLuong on NhanVien.MaBangLuong = BangLuong.MaBangluong where MaNhanVien='"+manv+"'");
        }
        public static void ThemNV(string MaNhanVien, string TenNV, DateTime NgaySinh, int gioitinh,string tentruong, DateTime NgayTotNghiep,DateTime NgayVaoCongTy, DateTime NgayNghi, string MaPhong, string MaLuong)
        {
            KetNoi.ThucThi("insert into NhanVien values ('" + MaNhanVien + "',N'" + TenNV + "','" + NgaySinh.ToString("yyy-MM-dd") + "','" + gioitinh + "',N'" + tentruong + "','" + NgayTotNghiep.ToString("yyy-MM-dd") + "','" + NgayVaoCongTy.ToString("yyy-MM-dd") + "','" + NgayNghi.ToString("yyy-MM-dd") + "','" + MaPhong + "','" + MaLuong + "')");
        }
        public static void SuaNV(string MaNhanVien, string TenNV, DateTime NgaySinh, int gioitinh, string tentruong, DateTime NgayTotNghiep, DateTime NgayVaoCongTy, DateTime NgayNghi, string MaPhong, string MaLuong)
        {

            KetNoi.ThucThi("UPDATE NhanVien SET HoTen =N'" + TenNV + "',NgaySinh='" + NgaySinh.ToString("yyy-MM-dd") + "',gioitinh='" + gioitinh + "', TenTruongDH=N'" + tentruong + "', NgayTotNghiep='" + NgayTotNghiep.ToString("yyy-MM-dd") + "', NgayVaoCongTy='" + NgayVaoCongTy.ToString("yyy-MM-dd") + "',NgayThangNghi='" + NgayNghi.ToString("yyy-MM-dd") + "', MaPhong='" + MaPhong + "', MaBangLuong='" + MaLuong + "' WHERE MaNhanVien='" + MaNhanVien + "'");
        }
        public static DataTable TimKien_NV(string TenNV, string TenTruong, string PhongBan)
        {
            try
            {
                return KetNoi.loadTable("select MaNhanVien,HoTen,Ngaysinh,Gioitinh,TenTruongDH,NgayTotNghiep,NgayVaoCongTy,NgayThangNghi,TenPhong,MucLuong from NhanVien join PhongBan on NhanVien.MaPhong = PhongBan.MaPhong join BangLuong on NhanVien.MaBangLuong = BangLuong.MaBangluong where (HoTen like N'%"+TenNV+"%') and (TenTruongDH like N'%"+TenTruong+"%') and (TenPhong like N'%"+PhongBan+"%')");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return null;
            
        }
        public static void Delete_NV(string MaNhanVien)
        {
            try
            {
                KetNoi.ThucThi("DELETE FROM NhanVien WHERE MaNhanVien ='" + MaNhanVien + "'");
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên có mã: " +MaNhanVien, "Thông báo", MessageBoxButtons.YesNo);
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
