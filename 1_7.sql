USE [TqtLession11]
GO
/****** Object:  Table [dbo].[TqtTaikhoan]    Script Date: 7/1/2024 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TqtTaikhoan](
	[TqtId] [nvarchar](50) NOT NULL,
	[TqtUser] [nvarchar](50) NULL,
	[TqtPass] [nchar](10) NULL,
	[TqtName] [nvarchar](50) NULL,
	[TqtAge] [int] NULL,
	[TqtEmail] [nvarchar](50) NULL,
	[TqtPhone] [nvarchar](50) NULL,
	[TqtStatus] [bit] NULL,
 CONSTRAINT [PK_TqtTaikhoan] PRIMARY KEY CLUSTERED 
(
	[TqtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TqtTaikhoan] ([TqtId], [TqtUser], [TqtPass], [TqtName], [TqtAge], [TqtEmail], [TqtPhone], [TqtStatus]) VALUES (N'2210900129', N'TranquangTien', N'Tien123   ', N'TranQuangTien', 20, N'Yaboku209@gmail,com', N'0969458663', 1)
GO
