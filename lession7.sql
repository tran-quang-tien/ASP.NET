USE [Tqtlesson07]
GO
/****** Object:  Table [dbo].[Tqtkhoa]    Script Date: 6/17/2024 2:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tqtkhoa](
	[TqtMakh] [nchar](10) NOT NULL,
	[TqtTenkh] [nvarchar](50) NULL,
	[TqtTrangthai] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TqtSinhvien]    Script Date: 6/17/2024 2:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TqtSinhvien](
	[TqtMasv] [nvarchar](50) NULL,
	[TqtHosv] [nvarchar](50) NULL,
	[TqtTensv] [nvarchar](50) NULL,
	[TqtNgaysinh] [date] NULL,
	[TqtPhai] [bit] NULL,
	[TqtPhone] [nchar](10) NULL,
	[TqtEmail] [nvarchar](50) NULL,
	[TqtMakh] [nchar](10) NULL
) ON [PRIMARY]
GO
