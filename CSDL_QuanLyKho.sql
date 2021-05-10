USE [DoAn_QuanLyKho]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        QL_NguoiDung.TenDangNhap, QL_NguoiDung.MatKhau
FROM            QL_NguoiDung INNER JOIN
                         QL_NguoiDungNhomNguoiDung ON QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap


GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery]
AS
	SET NOCOUNT ON;
SELECT        QL_NguoiDung.TenDangNhap, QL_NguoiDung.MatKhau
FROM            QL_NguoiDung INNER JOIN
                         QL_NguoiDungNhomNguoiDung ON QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap
WHERE        (QL_NguoiDung.TenDangNhap = N'QL_NguoiDungNhomNguoiDung')


GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangKho](
	[MaKho] [char](10) NOT NULL,
	[TenKho] [nvarchar](50) NULL,
	[DiaDiem] [nvarchar](50) NULL,
 CONSTRAINT [pk_BangKho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangPhieuNhapKho](
	[MaPhieuNhap] [char](10) NOT NULL,
	[MaHang] [char](10) NOT NULL,
	[MaThuKho] [char](10) NOT NULL,
	[MaKho] [char](10) NOT NULL,
	[NgayNhap] [date] NULL,
	[SoLuongNhap] [int] NULL,
 CONSTRAINT [pk_BangPhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangThuKho](
	[MaThuKho] [char](10) NOT NULL,
	[TenThuKho] [nvarchar](50) NULL,
 CONSTRAINT [pk_BangThuKho] PRIMARY KEY CLUSTERED 
(
	[MaThuKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_ManHinh](
	[MaManHinh] [nvarchar](50) NOT NULL,
	[TenManHinh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DM_] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHang] [char](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DVT] [nvarchar](20) NULL,
	[DonGia] [money] NULL,
	[MaNhomHang] [char](10) NULL,
 CONSTRAINT [pk_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhomHang](
	[MaNhomHang] [char](10) NOT NULL,
	[TenNhomHang] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [pk_NhomHang] PRIMARY KEY CLUSTERED 
(
	[MaNhomHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDung](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [PK_QL_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_NguoiDungNhomNguoiDung](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MaNhomNguoiDung] [varchar](20) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_QL_NguoiDungNhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgayVaoLam] [date] NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_QL_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_NhomNguoiDung](
	[MaNhom] [varchar](20) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_QL_NhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_PhanQuyen](
	[MaNhomNguoiDung] [nvarchar](20) NOT NULL,
	[MaManHinh] [nvarchar](50) NOT NULL,
	[CoQuyen] [bit] NOT NULL,
 CONSTRAINT [PK_QL_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietLapCongTy](
	[TenCongTy] [nvarchar](50) NOT NULL,
	[ChiNhanhChi] [nvarchar](50) NULL,
	[ChiNhanhPhu] [nvarchar](50) NULL,
	[ThanhPho] [nvarchar](50) NULL,
	[MaBuuDien] [nvarchar](50) NULL,
	[SoSerial] [nvarchar](50) NULL,
	[SoDT1] [nchar](10) NULL,
	[SoDT2] [nchar](10) NULL,
	[SoFAX] [nchar](10) NULL,
	[EmailDK] [nvarchar](50) NULL,
	[KichHoat] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ThietLapCongTy] PRIMARY KEY CLUSTERED 
(
	[TenCongTy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF001', N'Người dùng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF002', N'Nhóm người dùng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF003', N'Màn hình chức năng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF004', N'Thêm người dùng vào nhóm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF005', N'Phân quyền')
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'1', N'1', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'333', N'333', 1)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'1', N'admin', NULL)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'333', N'ND', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'admin', N'Admin', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'ND', N'Người dùng', NULL)
INSERT [dbo].[ThietLapCongTy] ([TenCongTy], [ChiNhanhChi], [ChiNhanhPhu], [ThanhPho], [MaBuuDien], [SoSerial], [SoDT1], [SoDT2], [SoFAX], [EmailDK], [KichHoat]) VALUES (N'TNHH', N'TPHCM', N'TPHCM', N'TPHCM', N'123456', N'456789', N'0944826504', N'0944826504', N'4789546   ', N'547896', N'W269N-WFGWX-YVC9B-4J6C9-T83GX')
ALTER TABLE [dbo].[BangPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [fk_BangPhieuNhapKho_BangKho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[BangKho] ([MaKho])
GO
ALTER TABLE [dbo].[BangPhieuNhapKho] CHECK CONSTRAINT [fk_BangPhieuNhapKho_BangKho]
GO
ALTER TABLE [dbo].[BangPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [fk_BangPhieuNhapKho_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[BangPhieuNhapKho] CHECK CONSTRAINT [fk_BangPhieuNhapKho_HangHoa]
GO
ALTER TABLE [dbo].[BangPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [fk_BangPhieuNhapKho_ThuKho] FOREIGN KEY([MaThuKho])
REFERENCES [dbo].[BangThuKho] ([MaThuKho])
GO
ALTER TABLE [dbo].[BangPhieuNhapKho] CHECK CONSTRAINT [fk_BangPhieuNhapKho_ThuKho]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [fk_HangHoa_NhomHang] FOREIGN KEY([MaNhomHang])
REFERENCES [dbo].[NhomHang] ([MaNhomHang])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [fk_HangHoa_NhomHang]
GO
