create database QuanLyNhanVien
GO
use QuanLyNhanVien
Go
CREATE TABLE [dbo].[BangLuong](
	[MaBangLuong] [nvarchar](20) NOT NULL,
	[MucLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBangLuong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 11/07/2020 00:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhong] [nvarchar](20) NOT NULL,
	[TenPhong] [nvarchar](100) NULL,
	[ChucNang] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/07/2020 00:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](20) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[gioitinh] [int] NULL,
	[TenTruongDH] [nvarchar](100) NULL,
	[NgayTotNghiep] [date] NULL,
	[NgayVaoCongTy] [date] NULL,
	[NgayThangNghi] [date] NULL,
	[MaPhong] [nvarchar](20) NULL,
	[MaBangLuong] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK__NhanVien__MaBang__09DE7BCC]    Script Date: 11/07/2020 00:40:37 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaBangLuong])
REFERENCES [dbo].[BangLuong] ([MaBangLuong])
GO
/****** Object:  ForeignKey [FK__NhanVien__MaPhon__08EA5793]    Script Date: 11/07/2020 00:40:37 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongBan] ([MaPhong])
GO
INSERT INTO BangLuong VALUES ('01','1000000')
INSERT INTO BangLuong VALUES ('02','2000000')
INSERT INTO BangLuong VALUES ('03','3000000')
INSERT INTO PhongBan VALUES ('NS01',N'Phòng Nhân Sự',N'Quản lý Nhân sự')
INSERT INTO PhongBan VALUES ('NS02',N'Phòng Nhân Sự',N'Quản lý Nhân sự')
INSERT INTO PhongBan VALUES ('TC01',N'Phòng tài chính',N'Quản lý tài chính')
INSERT INTO PhongBan VALUES ('KT01',N'Phòng Kế Toán',N'Báo cáo thống kê')
INSERT INTO NhanVien VALUES ('NV01',N'Hoàng Minh Nghĩa','1996/01/20','0',N'Đại Học Hàng Hải','2020/10/10','2020/11/1','2030/1/1','NS01','01')
INSERT INTO NhanVien VALUES ('NV02',N'Hoàng Thùy Linh','1997/11/20','1',N'Đại Học Thủy Lợi','2020/10/10','2020/11/1','2030/1/1','NS02','02')
INSERT INTO NhanVien VALUES ('NV03',N'Phạm Thế Anh','1996/04/02','0',N'Đại Học Hàng Hải','2020/10/10','2020/11/1','2030/1/1','TC01','03')
INSERT INTO NhanVien VALUES ('NV04',N'Hoàng Minh Nghĩa','1993/01/20','0',N'Đại Học Giao Thông','2018/10/10','2020/11/1','2030/1/1','KT01','01')


