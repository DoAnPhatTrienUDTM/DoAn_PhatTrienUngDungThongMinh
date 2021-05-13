USE [DoAn_QuanLyKho]
GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  StoredProcedure [dbo].[ScalarQuery]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  Table [dbo].[BangKho]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  Table [dbo].[BangPhieuNhapKho]    Script Date: 13/05/2021 21:26:21 ******/
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
	[MaNhaCungCap] [char](10) NULL,
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
/****** Object:  Table [dbo].[BangPhieuXuatKho]    Script Date: 13/05/2021 21:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangPhieuXuatKho](
	[MaPhieuXuat] [char](10) NOT NULL,
	[MaHang] [char](10) NULL,
	[MaThuKho] [char](10) NULL,
	[MaKho] [char](10) NULL,
	[NgayXuat] [date] NULL,
	[SoLuongXuat] [int] NULL,
	[SoHD] [char](10) NULL,
 CONSTRAINT [PK_BangPhieuXuatKho] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BangThuKho]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  Table [dbo].[DM_ManHinh]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  Table [dbo].[DoiTac]    Script Date: 13/05/2021 21:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoiTac](
	[IDDoiTac] [char](10) NOT NULL,
	[TenDoiTac] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[ThanhPho] [nvarchar](50) NULL,
	[SoDT1] [nchar](10) NULL,
	[SoDT2] [nchar](10) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_DoiTac] PRIMARY KEY CLUSTERED 
(
	[IDDoiTac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 13/05/2021 21:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[SoHD] [char](10) NOT NULL,
	[NgayLapHD] [date] NULL,
	[IDDoiTac] [char](10) NULL,
	[MaHang] [char](10) NULL,
	[MaNhomHang] [char](10) NULL,
	[SoLuong] [int] NULL,
	[DonViTinh] [nvarchar](20) NULL,
	[DonGia] [money] NULL,
	[VAT] [int] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 13/05/2021 21:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [char](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[ThanhPho] [nvarchar](50) NULL,
	[SoDT1] [char](10) NULL,
	[SoDT2] [char](10) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  Table [dbo].[QL_NguoiDung]    Script Date: 13/05/2021 21:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_NguoiDung](
	[IDNhanVien] [char](50) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
	[HoatDong] [bit] NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_QL_NguoiDung_1] PRIMARY KEY CLUSTERED 
(
	[IDNhanVien] ASC,
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_NguoiDungNhomNguoiDung]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  Table [dbo].[QL_NhomNguoiDung]    Script Date: 13/05/2021 21:26:21 ******/
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
/****** Object:  Table [dbo].[QL_PhanQuyen]    Script Date: 13/05/2021 21:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_PhanQuyen](
	[MaNhomNguoiDung] [varchar](20) NOT NULL,
	[MaManHinh] [nvarchar](50) NOT NULL,
	[CoQuyen] [bit] NOT NULL,
 CONSTRAINT [PK_QL_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThietLapCongTy]    Script Date: 13/05/2021 21:26:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietLapCongTy](
	[IDCompany] [nchar](10) NOT NULL,
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
 CONSTRAINT [PK_ThietLapCongTy_1] PRIMARY KEY CLUSTERED 
(
	[IDCompany] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF001', N'Người dùng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF002', N'Nhóm người dùng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF003', N'Màn hình chức năng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF004', N'Thêm người dùng vào nhóm')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF005', N'Phân quyền')
INSERT [dbo].[QL_NguoiDung] ([IDNhanVien], [TenDangNhap], [MatKhau], [HoatDong], [TenNhanVien], [DiaChi], [SoDT], [Email]) VALUES (N'ID001-UserAdmin                                   ', N'Dai123', N'Vr5sFdu7eqXN1jAODayt7w==', 1, N'Phan Văn Đại', N'TPHCM', N'0944826504', N'fcphanvan@gmail.com')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'Dai123', N'AD', N'')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'AD', N'Admin', N'Nhóm này được toàn quyền quản lý hệ thống')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'ND', N'Người dùng', N'Nhóm này chỉ được sử dụng những chức năng cho phép')
INSERT [dbo].[ThietLapCongTy] ([IDCompany], [TenCongTy], [ChiNhanhChi], [ChiNhanhPhu], [ThanhPho], [MaBuuDien], [SoSerial], [SoDT1], [SoDT2], [SoFAX], [EmailDK], [KichHoat]) VALUES (N'ID001     ', N'', N'', N'', N'', N'', N'', N'          ', N'          ', N'          ', N'fcphanvan@gmail.com', N'W269N-WFGWX-YVC9B-4J6C9-T83GX')
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
ALTER TABLE [dbo].[BangPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_BangPhieuNhapKho_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[BangPhieuNhapKho] CHECK CONSTRAINT [FK_BangPhieuNhapKho_NhaCungCap]
GO
ALTER TABLE [dbo].[BangPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [fk_BangPhieuNhapKho_ThuKho] FOREIGN KEY([MaThuKho])
REFERENCES [dbo].[BangThuKho] ([MaThuKho])
GO
ALTER TABLE [dbo].[BangPhieuNhapKho] CHECK CONSTRAINT [fk_BangPhieuNhapKho_ThuKho]
GO
ALTER TABLE [dbo].[BangPhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_BangPhieuXuatKho_BangKho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[BangKho] ([MaKho])
GO
ALTER TABLE [dbo].[BangPhieuXuatKho] CHECK CONSTRAINT [FK_BangPhieuXuatKho_BangKho]
GO
ALTER TABLE [dbo].[BangPhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_BangPhieuXuatKho_BangThuKho] FOREIGN KEY([MaThuKho])
REFERENCES [dbo].[BangThuKho] ([MaThuKho])
GO
ALTER TABLE [dbo].[BangPhieuXuatKho] CHECK CONSTRAINT [FK_BangPhieuXuatKho_BangThuKho]
GO
ALTER TABLE [dbo].[BangPhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_BangPhieuXuatKho_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[BangPhieuXuatKho] CHECK CONSTRAINT [FK_BangPhieuXuatKho_HangHoa]
GO
ALTER TABLE [dbo].[BangPhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_BangPhieuXuatKho_HoaDon] FOREIGN KEY([SoHD])
REFERENCES [dbo].[HoaDon] ([SoHD])
GO
ALTER TABLE [dbo].[BangPhieuXuatKho] CHECK CONSTRAINT [FK_BangPhieuXuatKho_HoaDon]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [fk_HangHoa_NhomHang] FOREIGN KEY([MaNhomHang])
REFERENCES [dbo].[NhomHang] ([MaNhomHang])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [fk_HangHoa_NhomHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DoiTac] FOREIGN KEY([IDDoiTac])
REFERENCES [dbo].[DoiTac] ([IDDoiTac])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DoiTac]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_HangHoa]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhomHang] FOREIGN KEY([MaNhomHang])
REFERENCES [dbo].[NhomHang] ([MaNhomHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhomHang]
GO
