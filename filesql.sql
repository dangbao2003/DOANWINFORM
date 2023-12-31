USE [PhongGym]
GO
/****** Object:  Table [dbo].[HoiVien]    Script Date: 16/11/2023 11:10:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiVien](
	[id_hv] [varchar](10) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](3) NULL,
	[sdt] [varchar](12) NULL,
	[ngayhethan] [date] NULL,
	[goitap] [nvarchar](50) NULL,
	[hinhanh] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 16/11/2023 11:10:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[id_sp] [varchar](10) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[loai] [nvarchar](30) NULL,
	[ngaynhap] [date] NULL,
	[soluong] [int] NULL,
	[dongia] [varchar](12) NULL,
	[trongluong] [varchar](10) NULL,
	[hangsx] [nvarchar](50) NULL,
	[tinhtrang] [nvarchar](20) NULL,
	[hinhanh] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 16/11/2023 11:10:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaTV] [int] IDENTITY(1,1) NOT NULL,
	[TenDN] [nvarchar](200) NOT NULL,
	[MatKhau] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 16/11/2023 11:10:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[id_tb] [varchar](10) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[loai] [nvarchar](10) NULL,
	[soluong] [int] NULL,
	[hangsx] [nvarchar](50) NULL,
	[tinhtrang] [nvarchar](20) NULL,
	[soluonghu] [int] NULL,
	[ghichu] [nvarchar](200) NULL,
	[hinhanh] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
