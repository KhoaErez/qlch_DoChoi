USE [QuanLiDoChoi]
GO
/****** Object:  Table [dbo].[ChiTietDonDatHang]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonDatHang](
	[MaDonDatHang] [nvarchar](50) NULL,
	[MaDoChoi] [nvarchar](50) NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [nvarchar](50) NULL,
	[MaDoChoi] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[Gia] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuGiaoHang]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuGiaoHang](
	[MaPhieuGiaoHang] [nvarchar](50) NULL,
	[MaDoChoi] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuHen]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuHen](
	[MaPhieuHen] [nvarchar](50) NULL,
	[MaDoChoi] [nvarchar](50) NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoChoi]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoChoi](
	[MaDoChoi] [nvarchar](50) NOT NULL,
	[TenDoChoi] [nvarchar](255) NOT NULL,
	[MaLoaiDoChoi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDoChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDonDatHang] [nvarchar](50) NOT NULL,
	[NgayDatHang] [date] NULL,
	[MaNhaCungCap] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonDatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](50) NOT NULL,
	[NgayHoaDon] [date] NULL,
	[MaKhachHang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[TenKhachHang] [nvarchar](255) NOT NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoDienThoai] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDoChoi]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDoChoi](
	[MaLoaiDoChoi] [nvarchar](50) NOT NULL,
	[TenLoaiDoChoi] [nvarchar](255) NOT NULL,
	[MaNhaCungCap] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDoChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nvarchar](50) NOT NULL,
	[TenNhaCungCap] [nvarchar](255) NOT NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoDienThoai] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGiaoHang]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiaoHang](
	[MaPhieuGiaoHang] [nvarchar](50) NOT NULL,
	[MaDonDatHang] [nvarchar](50) NULL,
	[NgayGiaoHang] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiaoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuHen]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuHen](
	[MaPhieuHen] [nvarchar](50) NOT NULL,
	[NgayHen] [date] NULL,
	[NgayLap] [date] NULL,
	[MaKhachHang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuHen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTraNo]    Script Date: 16/05/2024 7:55:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTraNo](
	[MaPhieuTraNo] [nvarchar](50) NOT NULL,
	[SoTienTra] [float] NULL,
	[NgayTra] [date] NULL,
	[MaHoaDon] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuTraNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([MaDoChoi])
GO
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD FOREIGN KEY([MaDonDatHang])
REFERENCES [dbo].[DonDatHang] ([MaDonDatHang])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([MaDoChoi])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang]  WITH CHECK ADD FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([MaDoChoi])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang]  WITH CHECK ADD FOREIGN KEY([MaPhieuGiaoHang])
REFERENCES [dbo].[PhieuGiaoHang] ([MaPhieuGiaoHang])
GO
ALTER TABLE [dbo].[ChiTietPhieuHen]  WITH CHECK ADD FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([MaDoChoi])
GO
ALTER TABLE [dbo].[ChiTietPhieuHen]  WITH CHECK ADD FOREIGN KEY([MaPhieuHen])
REFERENCES [dbo].[PhieuHen] ([MaPhieuHen])
GO
ALTER TABLE [dbo].[DoChoi]  WITH CHECK ADD FOREIGN KEY([MaLoaiDoChoi])
REFERENCES [dbo].[LoaiDoChoi] ([MaLoaiDoChoi])
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[LoaiDoChoi]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD FOREIGN KEY([MaDonDatHang])
REFERENCES [dbo].[DonDatHang] ([MaDonDatHang])
GO
ALTER TABLE [dbo].[PhieuHen]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuTraNo]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO


INSERT INTO NhaCungCap VALUES
(N'SG',N'Bia Sài Gòn',N'Bình Thạnh, TP HCM','088844442'),
(N'HN',N'Bia Hà Nội',N'Minh Khai, TP HN','01144442'),
(N'DN',N'Bia 3333',N'Không biết, TP DN','06213442'),
(N'HH',N'Bia 4444',N'Không nhớ, TP Huế','09843442'),
(N'CT',N'Bia 5555',N'Quên rồi, TP Cần Thơ','036244442'),
(N'NA',N'Bia 6666',N'Lê Hồng Phong, TP Vinh','097854442')

SELECT * FROM NhaCungCap

INSERT INTO LoaiDoChoi(MaLoaiDoChoi, TenLoaiDoChoi, MaNhaCungCap) VALUES
(N'B000',N'Gậy nhấp nháy',N'CT'),
(N'B001',N'Bóng cười',N'HH'),
(N'B002',N'Bóng bay nhỏ',N'HN'),
(N'B003',N'Bóng bay to',N'NA'),
(N'S004',N'Siêu nhân',N'SG')

select * from LoaiDoChoi


INSERT INTO DoChoi VALUES
(N'SSK1',N'Gấu panda',N'B000'),
(N'SSK2',N'Gấu trúc',N'B001'),
(N'SSK3',N'Siêu nhân dơi',N'B002'),
(N'SSK4',N'Siêu nhân gao',N'B003'),
(N'SSK5',N'Mô hình Goku',N'S004')
SELECT * FROM DoChoi

INSERT INTO DonDatHang VALUES
(N'DDH01','2023/12/23',N'SG'),
(N'DDH02','2023/02/23',N'HH'),
(N'DDH03','2023/04/27',N'HH'),
(N'DDH04','2023/03/26',N'HN'),
(N'DDH05','2023/04/27',N'DN'),
(N'DDH06','2023/12/28',N'SG')
SELECT * FROM DonDatHang

INSERT INTO ChiTietDonDatHang VALUES
(N'DDH01',N'SSK1',231),
(N'DDH02',N'SSK2',168),
(N'DDH03',N'SSK3',999),
(N'DDH04',N'SSK4',221),
(N'DDH05',N'SSK5',637)
SELECT * FROM ChiTietDonDatHang

INSERT INTO ChiTietDonDatHang VALUES
(N'DDH01',N'SSK1',221),
(N'DDH01',N'SSK2',111),
(N'DDH01',N'SSK3',181)

INSERT INTO PhieuGiaoHang VALUES
(N'PGH01',N'DDH01','2024/12/22'),
(N'PGH06',N'DDH02','2024/10/21'),
(N'PGH03',N'DDH03','2024/06/10'),
(N'PGH02',N'DDH04','2024/08/18'),
(N'PGH04',N'DDH05','2024/09/27'),
(N'PGH05',N'DDH06','2024/10/16')
SELECT * FROM PhieuGiaoHang

DELETE FROM PhieuGiaoHang WHERE MaPhieuGiaoHang = N'MM213'

INSERT INTO ChiTietPhieuGiaoHang VALUES
(N'PGH01',N'SSK1',32,20000),
(N'PGH02',N'SSK2',32,20000),
(N'PGH03',N'SSK3',32,20000),
(N'PGH04',N'SSK4',32,20000),
(N'PGH05',N'SSK5',32,20000),
(N'PGH06',N'SSK6',32,20000)
SELECT * FROM ChiTietPhieuGiaoHang

SELECT ChiTietPhieuGiaoHang.MaPhieuGiaoHang, ChiTietPhieuGiaoHang.MaDoChoi, ChiTietPhieuGiaoHang.SoLuong,
	   ChiTietPhieuGiaoHang.DonGia, PhieuGiaoHang.MaDonDatHang, PhieuGiaoHang.NgayGiaoHang FROM ChiTietPhieuGiaoHang
INNER JOIN PhieuGiaoHang
ON PhieuGiaoHang.MaPhieuGiaoHang = ChiTietPhieuGiaoHang.MaPhieuGiaoHang


INSERT INTO KhachHang VALUES
(N'KH001',N'Hồ Văn Oai',N'Quỳnh Lưu, Nghệ An','07878978212'),
(N'KH002',N'Lê Hương Ly',N'Hoàng Mai, Hà Nội','01653474835'),
(N'KH003',N'Nguyễn Anh Thư',N'Hai Bà Trưng, Hà Nội','08887154335'),
(N'KH004',N'Nguyễn Tiến Linh',N'TP Nam Định, Nam Định','09427602224'),
(N'KH005',N'Hồ Văn Ngọc',N'TP Vinh, Nghệ An','08194005555')
SELECT * FROM KhachHang

create table users
(
	tenDN varchar(30) not null,
	matKhau varchar(30) not null
)

INSERT INTO users VALUES('khoa','123')

INSERT INTO users VALUES('khoa1','1')