USE [DatabaseCon]
GO
/****** Object:  Table [dbo].[Tbl_AddUsers]    Script Date: 9/3/2023 1:41:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_AddUsers](
	[EmployeeID] [int] NULL,
	[CompleteName] [nvarchar](50) NULL,
	[Uname] [nvarchar](50) NULL,
	[Pwd] [nvarchar](50) NULL,
	[ConfirmPwd] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Admin]    Script Date: 9/3/2023 1:41:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Admin](
	[admin_id] [int] NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Admin] PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Tbl_AddUsers] ([EmployeeID], [CompleteName], [Uname], [Pwd], [ConfirmPwd]) VALUES (12345, N'raphael', N'raphael', N'12345', N'12345')
INSERT [dbo].[Tbl_AddUsers] ([EmployeeID], [CompleteName], [Uname], [Pwd], [ConfirmPwd]) VALUES (555, N'test', N'test', N'test', N'test')
GO
INSERT [dbo].[Tbl_Admin] ([admin_id], [username], [password]) VALUES (1, N'admin', N'admin123')
GO
