USE [pril]
GO
/****** Object:  Table [dbo].[Aut]    Script Date: 24.06.2024 2:15:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aut](
	[ID_Aut] [int] NOT NULL,
	[login] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[ID_Dolznosti] [int] NOT NULL,
 CONSTRAINT [PK_Aut] PRIMARY KEY CLUSTERED 
(
	[ID_Aut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DobavleniePosetitelei]    Script Date: 24.06.2024 2:15:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DobavleniePosetitelei](
	[ID] [int] NOT NULL,
	[FIO] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Spisok_Zayavok] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dolznosti]    Script Date: 24.06.2024 2:15:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dolznosti](
	[ID_Dolznosti] [int] NOT NULL,
	[Name_Dozlnosti] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Dolznosti] PRIMARY KEY CLUSTERED 
(
	[ID_Dolznosti] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GruppovayaZayavka]    Script Date: 24.06.2024 2:15:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GruppovayaZayavka](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tsel_posecheniya] [nvarchar](max) NULL,
	[Date_start] [date] NOT NULL,
	[Date_end] [date] NOT NULL,
	[Podrazdelenie] [nvarchar](max) NOT NULL,
	[FIO] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Dadname] [nvarchar](max) NOT NULL,
	[Phone_number] [nvarchar](max) NOT NULL,
	[Organization] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Date_of_birth] [date] NOT NULL,
	[Seriya] [nvarchar](max) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](max) NULL,
 CONSTRAINT [PK_GruppovayaZayavka] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichnayaZayavka]    Script Date: 24.06.2024 2:15:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichnayaZayavka](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tsel_posecheniya] [nvarchar](max) NULL,
	[Date_start] [date] NOT NULL,
	[Date_end] [date] NOT NULL,
	[FIO] [nvarchar](max) NOT NULL,
	[Podrazdelenie] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Dadname] [nvarchar](max) NOT NULL,
	[Phone_number] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Organization] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Date_of_birth] [date] NOT NULL,
	[Seriya] [nvarchar](max) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[Photo] [image] NULL,
	[Status] [nvarchar](max) NULL,
 CONSTRAINT [PK_LichnayaZ] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aut]  WITH CHECK ADD  CONSTRAINT [FK_Aut_Dolznosti] FOREIGN KEY([ID_Dolznosti])
REFERENCES [dbo].[Dolznosti] ([ID_Dolznosti])
GO
ALTER TABLE [dbo].[Aut] CHECK CONSTRAINT [FK_Aut_Dolznosti]
GO
