USE [master]
GO

CREATE DATABASE [Ribolov]
GO

USE [Ribolov]
GO

CREATE TABLE [dbo].[Delegat](
	[DelegatID] [int] NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Delegat] PRIMARY KEY CLUSTERED 
(
	[DelegatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
 
GO
/****** Object:  Table [dbo].[SpisakTakmicara]    Script Date: 8/25/2021 11:32:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpisakTakmicara](
	[TakmicenjeID] [int] NOT NULL,
	[RedniBroj] [int] NOT NULL,
	[Ulov] [int] NULL,
	[Rang] [int] NULL,
	[TakmicarID] [int] NULL,
 CONSTRAINT [PK_SpisakTakmicara] PRIMARY KEY CLUSTERED 
(
	[TakmicenjeID] ASC,
	[RedniBroj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staza]    Script Date: 8/25/2021 11:32:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staza](
	[StazaID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Lokacija] [nvarchar](50) NULL,
	[Tip] [int] NULL,
	[ZemljaID] [int] NULL,
 CONSTRAINT [PK_Staza] PRIMARY KEY CLUSTERED 
(
	[StazaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Takmicar]    Script Date: 8/25/2021 11:32:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Takmicar](
	[TakmicarID] [int] NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[Oslovljavanje] [int] NULL,
	[Jmbg] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DatumRodjenja] [date] NULL,
	[BrojTelefona] [nvarchar](50) NULL,
	[ZemljaID] [int] NULL,
	[Adresa] [nvarchar](50) NULL,
	[PostanskiBroj] [nvarchar](50) NULL,
 CONSTRAINT [PK_Takmicar] PRIMARY KEY CLUSTERED 
(
	[TakmicarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Takmicenje]    Script Date: 8/25/2021 11:32:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Takmicenje](
	[TakmicenjeID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Datum] [date] NULL,
	[Kategorija] [nvarchar](50) NULL,
	[Delegat] [int] NULL,
	[Staza] [int] NULL,
 CONSTRAINT [PK_Takmicenje] PRIMARY KEY CLUSTERED 
(
	[TakmicenjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zemlja]    Script Date: 8/25/2021 11:32:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zemlja](
	[ZemljaID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NULL,
 CONSTRAINT [PK_Zemlja] PRIMARY KEY CLUSTERED 
(
	[ZemljaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Delegat] ([DelegatID], [Ime], [Prezime], [Username], [Password]) VALUES (1, N'Aleksa', N'Ristic', N'aleksa', N'aleksa')
INSERT [dbo].[Delegat] ([DelegatID], [Ime], [Prezime], [Username], [Password]) VALUES (2, N'Jelena ', N'Pavlovic', N'jelena', N'jelena')
INSERT [dbo].[Delegat] ([DelegatID], [Ime], [Prezime], [Username], [Password]) VALUES (3, N'Luka', N'Ivanovnic', N'luka', N'luka')
INSERT [dbo].[Delegat] ([DelegatID], [Ime], [Prezime], [Username], [Password]) VALUES (4, N'Zoran ', N'Stamenkovic', N'zoran', N'zoran')

INSERT [dbo].[Staza] ([StazaID], [Naziv], [Lokacija], [Tip], [ZemljaID]) VALUES (1, N'Kanal DTD', N'Novi Sad', 1, 1)
INSERT [dbo].[Staza] ([StazaID], [Naziv], [Lokacija], [Tip], [ZemljaID]) VALUES (2, N'Miterson Arena', N'Plovdiv', 2, 3)
INSERT [dbo].[Staza] ([StazaID], [Naziv], [Lokacija], [Tip], [ZemljaID]) VALUES (3, N'Stara Tisa', N'Szolnoc', 3, 2)
INSERT [dbo].[Staza] ([StazaID], [Naziv], [Lokacija], [Tip], [ZemljaID]) VALUES (4, N'Ostelato', N'Ferrara', 1, 5)
INSERT [dbo].[Staza] ([StazaID], [Naziv], [Lokacija], [Tip], [ZemljaID]) VALUES (5, N'Sarulesti', N'Oradea', 4, 4)
INSERT [dbo].[Staza] ([StazaID], [Naziv], [Lokacija], [Tip], [ZemljaID]) VALUES (6, N'Mincio', N'Mantova', 3, 5)
INSERT [dbo].[Staza] ([StazaID], [Naziv], [Lokacija], [Tip], [ZemljaID]) VALUES (7, N'Vilaine', N'Rieux', 3, 6)

INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (1, N'Bogdan', N'Savkovic', 1, N'2302983732133', N'bogdan@fon.bg.ac.rs', CAST(N'1983-02-23' AS Date), N'(+381)643431818', 1, N'Jove Ilica 32', N'10110')
INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (2, N'Vukan', N'Radosavljevic', 1, N'2510994742022', N'vukan@fon.bg.ac.rs', CAST(N'1994-10-25' AS Date), N'(+381)652004348', 1, N'Kostolacka 29', N'18000')
INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (3, N'Ivana', N'Ilic', 3, N'1508996581190', N'ivana@fon.bg.ac.rs', CAST(N'1996-08-15' AS Date), N'(+381)696060443', 1, N'Kosovska 18', N'17500')
INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (4, N'Milos', N'Prolic', 1, N'0306998661315', N'milos@fon.bg.ac.rs', CAST(N'1998-06-03' AS Date), N'(+381)625533807', 2, N'Kralja Stefana Prvovenacnog 290', N'17501')
INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (5, N'Dimitrije', N'Mitrovic', 1, N'2912974643341', N'dimitrije@fon.bg.ac.rs', CAST(N'1974-12-29' AS Date), N'(+1)689541623', 3, N'Vojvode Stepe 183', N'11000')
INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (6, N'Zoran', N'Ristic', 1, N'3101990742703', N'zoran@fon.bg.ac.rs', CAST(N'1990-01-31' AS Date), N'(+389)646979003', 3, N'Bulevar Kralja Aleksandra 20', N'11080')
INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (7, N'Snezana', N'Ristic', 2, N'0303963721290', N'snezana@fon.bg.ac.rs', CAST(N'1963-03-03' AS Date), N'(+381)618904242', 4, N'Partizanski put 220', N'10110')
INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (8, N'Sava', N'Ristic', 1, N'2412992435018', N'sava@fon.bg.ac.rs', CAST(N'1992-12-24' AS Date), N'(+381)607734626', 5, N'Beogradska 18', N'10110')
INSERT [dbo].[Takmicar] ([TakmicarID], [Ime], [Prezime], [Oslovljavanje], [Jmbg], [Email], [DatumRodjenja], [BrojTelefona], [ZemljaID], [Adresa], [PostanskiBroj]) VALUES (9, N'Zdravko', N'Ristic', 1, N'1111978792025', N'zdravko@fon.bg.ac.rs', CAST(N'1978-11-11' AS Date), N'(+381)646942069', 6, N'Vitanovacka 33', N'27000')

INSERT [dbo].[Zemlja] ([ZemljaID], [Naziv]) VALUES (1, N'Srbija')
INSERT [dbo].[Zemlja] ([ZemljaID], [Naziv]) VALUES (2, N'Madjarska')
INSERT [dbo].[Zemlja] ([ZemljaID], [Naziv]) VALUES (3, N'Bugarska')
INSERT [dbo].[Zemlja] ([ZemljaID], [Naziv]) VALUES (4, N'Rumunija')
INSERT [dbo].[Zemlja] ([ZemljaID], [Naziv]) VALUES (5, N'Italija')
INSERT [dbo].[Zemlja] ([ZemljaID], [Naziv]) VALUES (6, N'Francuska')

INSERT [dbo].[Takmicenje] ([TakmicenjeID], [Naziv], [Datum], [Kategorija], [Delegat], [Staza]) VALUES (1, N'Musica KUP', CAST(N'2021-11-23' AS Date), N'Senori', 1, 1)
INSERT [dbo].[Takmicenje] ([TakmicenjeID], [Naziv], [Datum], [Kategorija], [Delegat], [Staza]) VALUES (2, N'Plovak', CAST(N'2021-09-15' AS Date), N'Dame', 1, 2)
INSERT [dbo].[Takmicenje] ([TakmicenjeID], [Naziv], [Datum], [Kategorija], [Delegat], [Staza]) VALUES (3, N'Fider', CAST(N'2021-08-01' AS Date), N'Veterani', 1, 3)
INSERT [dbo].[Takmicenje] ([TakmicenjeID], [Naziv], [Datum], [Kategorija], [Delegat], [Staza]) VALUES (4, N'Spin', CAST(N'2021-09-30' AS Date), N'Juniori U25', 1, 4)
INSERT [dbo].[Takmicenje] ([TakmicenjeID], [Naziv], [Datum], [Kategorija], [Delegat], [Staza]) VALUES (5, N'Black Bass', CAST(N'2021-08-07' AS Date), N'Juniori U18', 2, 5)

INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (1, 7, 3, 1, 2)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (1, 6, 6, 2, 9)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (1, 5, 8, 3, 8)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (1, 4, 9, 4, 3)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (1, 3, 10, 5, 1)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (1, 2, 11, 6, 4)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (1, 1, 15, 7, 5)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (2, 2, 30, 1, 7)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (2, 5, 40, 2, 6)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (2, 1, 51, 3, 2)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (2, 4, 55, 4, 9)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (2, 3, 70, 5, 1)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (3, 1, 1, 1, 6)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (3, 3, 6, 2, 5)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (3, 2, 23, 3, 2)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (4, 3, 55, 1, 1)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (4, 2, 73, 2, 8)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (4, 1, 99, 3, 2)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (5, 1, 13, 1, 9)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (5, 5, 17, 2, 7)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (5, 4, 21, 3, 1)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (5, 3, 25, 4, 4)
INSERT [dbo].[SpisakTakmicara] ([TakmicenjeID], [RedniBroj], [Ulov], [Rang], [TakmicarID]) VALUES (5, 2, 34, 5, 3)

ALTER TABLE [dbo].[SpisakTakmicara]  WITH CHECK ADD  CONSTRAINT [FK_SpisakTakmicara_Takmicar] FOREIGN KEY([TakmicarID])
REFERENCES [dbo].[Takmicar] ([TakmicarID])
ON UPDATE CASCADE
ON DELETE CASCADE    
GO
ALTER TABLE [dbo].[SpisakTakmicara] CHECK CONSTRAINT [FK_SpisakTakmicara_Takmicar]
GO
ALTER TABLE [dbo].[SpisakTakmicara]  WITH CHECK ADD  CONSTRAINT [FK_SpisakTakmicara_Takmicenje] FOREIGN KEY([TakmicenjeID])
REFERENCES [dbo].[Takmicenje] ([TakmicenjeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SpisakTakmicara] CHECK CONSTRAINT [FK_SpisakTakmicara_Takmicenje]
GO
ALTER TABLE [dbo].[Staza]  WITH CHECK ADD  CONSTRAINT [FK_Staza_Zemlja] FOREIGN KEY([ZemljaID])
REFERENCES [dbo].[Zemlja] ([ZemljaID])
GO
ALTER TABLE [dbo].[Staza] CHECK CONSTRAINT [FK_Staza_Zemlja]
GO
ALTER TABLE [dbo].[Takmicar]  WITH CHECK ADD  CONSTRAINT [FK_Takmicar_Zemlja] FOREIGN KEY([ZemljaID])
REFERENCES [dbo].[Zemlja] ([ZemljaID])
GO
ALTER TABLE [dbo].[Takmicar] CHECK CONSTRAINT [FK_Takmicar_Zemlja]
GO
ALTER TABLE [dbo].[Takmicenje]  WITH CHECK ADD  CONSTRAINT [FK_Takmicenje_Delegat] FOREIGN KEY([Delegat])
REFERENCES [dbo].[Delegat] ([DelegatID])
GO
ALTER TABLE [dbo].[Takmicenje] CHECK CONSTRAINT [FK_Takmicenje_Delegat]
GO
ALTER TABLE [dbo].[Takmicenje]  WITH CHECK ADD  CONSTRAINT [FK_Takmicenje_Staza] FOREIGN KEY([Staza])
REFERENCES [dbo].[Staza] ([StazaID])
GO
ALTER TABLE [dbo].[Takmicenje] CHECK CONSTRAINT [FK_Takmicenje_Staza]
GO
USE [master]
GO
ALTER DATABASE [Ribolov] SET  READ_WRITE 
GO
