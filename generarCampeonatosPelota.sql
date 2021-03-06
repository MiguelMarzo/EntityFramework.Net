USE [CampeonatosPelota]
GO
/****** Object:  Table [dbo].[Campeonatos]    Script Date: 01/12/2016 18:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campeonatos](
	[Año] [int] NOT NULL,
	[IdCampeon] [nvarchar](30) NOT NULL,
	[IdSubCampeon] [nvarchar](30) NOT NULL,
	[TantosSubCampeon] [int] NOT NULL,
	[IdFronton] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Campeonatos] PRIMARY KEY CLUSTERED 
(
	[Año] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Frontones]    Script Date: 01/12/2016 18:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Frontones](
	[Id] [nvarchar](30) NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[IdProvincia] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_Frontones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pelotaris]    Script Date: 01/12/2016 18:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelotaris](
	[Id] [nvarchar](30) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Localidad] [nvarchar](50) NULL,
	[IdProvincia] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_Pelotari] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 01/12/2016 18:52:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Id] [nvarchar](2) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1987, N'Retegi II', N'Tolosa', 8, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1988, N'Retegi II', N'Galarza III', 9, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1989, N'Tolosa', N'Retegi II', 10, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1990, N'Retegi II', N'Tolosa', 9, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1991, N'Galarza III', N'Retegi II', 15, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1992, N'Galarza III', N'Retegi II', 12, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1993, N'Retegi II', N'Galarza III', 19, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1994, N'Arretxe', N'Errandonea', 12, N'Ogeta')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1995, N'Beloki', N'Errandonea', 12, N'Ogeta')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1996, N'Eugi', N'Arretxe', 19, N'Ogeta')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1997, N'Arretxe', N'Elkoro', 18, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1998, N'Beloki', N'Eugi', 13, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (1999, N'Arretxe', N'Elkoro', 11, N'Astelena')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2000, N'Eugi', N'Beloki', 13, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2001, N'Beloki', N'Eugi', 8, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2002, N'Barriola', N'Beloki', 3, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2003, N'Patxi Ruiz', N'Olaizola II', 7, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2004, N'Martínez de Irujo', N'Xala', 12, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2005, N'Olaizola II', N'Martínez de Irujo', 18, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2006, N'Martínez de Irujo', N'Olaizola II', 17, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2007, N'Olaizola II', N'Barriola', 10, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2008, N'Bengoetxea VI', N'Barriola', 11, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2009, N'Martínez de Irujo', N'Olaizola II', 12, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2010, N'Martínez de Irujo', N'Xala', 13, N'Ogeta')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2011, N'Xala', N'Olaizola II', 19, N'Bizkaia')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2012, N'Olaizola II', N'Martínez de Irujo', 7, N'Bizkaia')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2013, N'Olaizola II', N'Martínez de Irujo', 7, N'Bizkaia')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2014, N'Martínez de Irujo', N'Retegi Bi', 9, N'Atano III')
INSERT [dbo].[Campeonatos] ([Año], [IdCampeon], [IdSubCampeon], [TantosSubCampeon], [IdFronton]) VALUES (2015, N'Urrutikoetxea', N'Olaizola II', 19, N'Bizkaia')
INSERT [dbo].[Frontones] ([Id], [Localidad], [IdProvincia]) VALUES (N'Astelena', N'Eibar', N'SS')
INSERT [dbo].[Frontones] ([Id], [Localidad], [IdProvincia]) VALUES (N'Atano III', N'Donostia', N'SS')
INSERT [dbo].[Frontones] ([Id], [Localidad], [IdProvincia]) VALUES (N'Beotibar', N'Tolosa', N'SS')
INSERT [dbo].[Frontones] ([Id], [Localidad], [IdProvincia]) VALUES (N'Bizkaia', N'Bilbo', N'BI')
INSERT [dbo].[Frontones] ([Id], [Localidad], [IdProvincia]) VALUES (N'Labrit', N'Pamplona/Iruñea', N'NA')
INSERT [dbo].[Frontones] ([Id], [Localidad], [IdProvincia]) VALUES (N'Ogeta', N'Vitoria-Gasteiz', N'VI')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Altuna III', N'Jokin Altuna III', N'Amezketa', N'SS')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Arretxe', N'Fernando Arretxe', N'Valcarlos', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Artola', N'Iñaki Artola', N'Alegia', N'SS')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Barriola', N'Abel Barriola', N'Leitza', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Beloki', N'Ruben Beloki Iribarren', N'Burlada/Burlata', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Bengoetxea VI', N'Oinatz Bengoetxea', N'Leitza', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Elkoro', N'Elkoro Sarasua', N'Elgeta', N'SS')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Errandonea', N'Inaxio Errandonea', N'Bera', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Eugi', N'Patxi Eugi CabodevillaNULL', N'Aoiz', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Galarza III', N'Ladis Galarza', N'Baraibar', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Martínez de Irujo', N'Juan Martínez de Irujo', N'Ibero', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Olaizola II', N'Aimar Olaizola', N'Goizueta', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Patxi Ruiz', N'Patxi Ruiz', N'Estella/Lizarra', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Retegi BI', N'Julen Retegi', N'Pamplona/Iruñea', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Retegi II', N'Julian Retegi', N'Erasun', N'NA')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Tolosa', N'Joxean Tolosa', N'Amezketa', N'SS')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Urrutikoetxea', N'Mikel Urrutikoetxea', N'Zaratamo', N'BI')
INSERT [dbo].[Pelotaris] ([Id], [Nombre], [Localidad], [IdProvincia]) VALUES (N'Xala', N'Yves Salaberri', N'Bonloo', N'IP')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (N'BI', N'Vizcaya')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (N'IP', N'Iparralde')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (N'LO', N'La Rioja')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (N'NA', N'Navarra')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (N'SS', N'Guipúzcoa')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (N'VI', N'Álava')
ALTER TABLE [dbo].[Campeonatos]  WITH CHECK ADD  CONSTRAINT [FK_Campeonatos_Frontones] FOREIGN KEY([IdFronton])
REFERENCES [dbo].[Frontones] ([Id])
GO
ALTER TABLE [dbo].[Campeonatos] CHECK CONSTRAINT [FK_Campeonatos_Frontones]
GO
ALTER TABLE [dbo].[Campeonatos]  WITH CHECK ADD  CONSTRAINT [FK_Campeonatos_Pelotaris] FOREIGN KEY([IdCampeon])
REFERENCES [dbo].[Pelotaris] ([Id])
GO
ALTER TABLE [dbo].[Campeonatos] CHECK CONSTRAINT [FK_Campeonatos_Pelotaris]
GO
ALTER TABLE [dbo].[Campeonatos]  WITH CHECK ADD  CONSTRAINT [FK_Campeonatos_Pelotaris1] FOREIGN KEY([IdSubCampeon])
REFERENCES [dbo].[Pelotaris] ([Id])
GO
ALTER TABLE [dbo].[Campeonatos] CHECK CONSTRAINT [FK_Campeonatos_Pelotaris1]
GO
ALTER TABLE [dbo].[Frontones]  WITH CHECK ADD  CONSTRAINT [FK_Frontones_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([Id])
GO
ALTER TABLE [dbo].[Frontones] CHECK CONSTRAINT [FK_Frontones_Provincias]
GO
ALTER TABLE [dbo].[Pelotaris]  WITH CHECK ADD  CONSTRAINT [FK_Pelotaris_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([Id])
GO
ALTER TABLE [dbo].[Pelotaris] CHECK CONSTRAINT [FK_Pelotaris_Provincias]
GO
