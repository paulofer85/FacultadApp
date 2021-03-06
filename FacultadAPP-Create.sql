USE [master]
GO

/****** Object:  Database [AlumnoApp]    Script Date: 12/12/2019 16:09:17 ******/
CREATE DATABASE [AlumnoApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AlumnoApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\AlumnoApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AlumnoApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\AlumnoApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AlumnoApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

USE [AlumnosApp]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 07/02/2020 12:57:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[AlumnoId] [int] IDENTITY(1,1) NOT NULL,
	[Padron] [nvarchar](max) NULL,
	[Apellido] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Domicilio] [nvarchar](max) NULL,
	[CarreraFK] [int] NOT NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[AlumnoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 07/02/2020 12:57:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[CarreraId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Titulo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Carreras] PRIMARY KEY CLUSTERED 
(
	[CarreraId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripciones]    Script Date: 07/02/2020 12:57:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripciones](
	[IncripcionId] [int] IDENTITY(1,1) NOT NULL,
	[Nota] [smallint] NOT NULL,
	[Estado] [smallint] NOT NULL,
	[AlumnoFK] [int] NOT NULL,
	[MateriaFK] [int] NOT NULL,
 CONSTRAINT [PK_Inscripciones] PRIMARY KEY CLUSTERED 
(
	[IncripcionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 07/02/2020 12:57:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[MateriaId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[CargaHoraria] [smallint] NOT NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[MateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriasCarreras]    Script Date: 07/02/2020 12:57:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriasCarreras](
	[MateriasCarrerasId] [int] IDENTITY(1,1) NOT NULL,
	[CarreraFK] [int] NOT NULL,
	[MateriaFK] [int] NOT NULL,
 CONSTRAINT [PK_MateriasCarreras] PRIMARY KEY CLUSTERED 
(
	[MateriasCarrerasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumnos] ON 

INSERT [dbo].[Alumnos] ([AlumnoId], [Padron], [Apellido], [Nombre], [Domicilio], [CarreraFK]) VALUES (1, N'85847', N'Turing', N'Alan', N'Av. Siempre viva 314', 1)
INSERT [dbo].[Alumnos] ([AlumnoId], [Padron], [Apellido], [Nombre], [Domicilio], [CarreraFK]) VALUES (2, N'85848', N'Escher', N'Mario', N'Av. Siempre viva 314', 1)
INSERT [dbo].[Alumnos] ([AlumnoId], [Padron], [Apellido], [Nombre], [Domicilio], [CarreraFK]) VALUES (3, N'85849', N'En el Bosque', N'Pirulo', N'Av. Siempre viva 314', 1)
INSERT [dbo].[Alumnos] ([AlumnoId], [Padron], [Apellido], [Nombre], [Domicilio], [CarreraFK]) VALUES (7, N'85857', N'Turing', N'Alan', N'Av. Siempre viva 314', 1)
SET IDENTITY_INSERT [dbo].[Alumnos] OFF
SET IDENTITY_INSERT [dbo].[Carreras] ON 

INSERT [dbo].[Carreras] ([CarreraId], [Nombre], [Titulo]) VALUES (1, N'Ing. en Informática', N'Ingeniero/a')
SET IDENTITY_INSERT [dbo].[Carreras] OFF
SET IDENTITY_INSERT [dbo].[Inscripciones] ON 

INSERT [dbo].[Inscripciones] ([IncripcionId], [Nota], [Estado], [AlumnoFK], [MateriaFK]) VALUES (1, 9, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Inscripciones] OFF
SET IDENTITY_INSERT [dbo].[Materias] ON 

INSERT [dbo].[Materias] ([MateriaId], [Codigo], [Nombre], [CargaHoraria]) VALUES (1, N'60.50', N'Algoritmos I', 8)
INSERT [dbo].[Materias] ([MateriaId], [Codigo], [Nombre], [CargaHoraria]) VALUES (2, N'60.51', N'Algoritmos II', 8)
INSERT [dbo].[Materias] ([MateriaId], [Codigo], [Nombre], [CargaHoraria]) VALUES (3, N'60.52', N'Algoritmos III', 8)
INSERT [dbo].[Materias] ([MateriaId], [Codigo], [Nombre], [CargaHoraria]) VALUES (4, N'60.53', N'Algoritmos IV', 8)
INSERT [dbo].[Materias] ([MateriaId], [Codigo], [Nombre], [CargaHoraria]) VALUES (5, N'60.54', N'Algoritmos V', 8)
INSERT [dbo].[Materias] ([MateriaId], [Codigo], [Nombre], [CargaHoraria]) VALUES (7, N'65.20', N'Organizacion de datos', 12)
SET IDENTITY_INSERT [dbo].[Materias] OFF
SET IDENTITY_INSERT [dbo].[MateriasCarreras] ON 

INSERT [dbo].[MateriasCarreras] ([MateriasCarrerasId], [CarreraFK], [MateriaFK]) VALUES (1, 1, 1)
INSERT [dbo].[MateriasCarreras] ([MateriasCarrerasId], [CarreraFK], [MateriaFK]) VALUES (2, 1, 3)
INSERT [dbo].[MateriasCarreras] ([MateriasCarrerasId], [CarreraFK], [MateriaFK]) VALUES (3, 1, 3)
INSERT [dbo].[MateriasCarreras] ([MateriasCarrerasId], [CarreraFK], [MateriaFK]) VALUES (4, 1, 4)
INSERT [dbo].[MateriasCarreras] ([MateriasCarrerasId], [CarreraFK], [MateriaFK]) VALUES (6, 1, 2)
SET IDENTITY_INSERT [dbo].[MateriasCarreras] OFF
ALTER TABLE [dbo].[Alumnos]  WITH CHECK ADD  CONSTRAINT [FK_Alumnos_Carreras_CarreraFK] FOREIGN KEY([CarreraFK])
REFERENCES [dbo].[Carreras] ([CarreraId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alumnos] CHECK CONSTRAINT [FK_Alumnos_Carreras_CarreraFK]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Inscripciones_Alumnos_AlumnoFK] FOREIGN KEY([AlumnoFK])
REFERENCES [dbo].[Alumnos] ([AlumnoId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_Inscripciones_Alumnos_AlumnoFK]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Inscripciones_Materias_MateriaFK] FOREIGN KEY([MateriaFK])
REFERENCES [dbo].[Materias] ([MateriaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_Inscripciones_Materias_MateriaFK]
GO
ALTER TABLE [dbo].[MateriasCarreras]  WITH CHECK ADD  CONSTRAINT [FK_MateriasCarreras_Carreras_CarreraFK] FOREIGN KEY([CarreraFK])
REFERENCES [dbo].[Carreras] ([CarreraId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MateriasCarreras] CHECK CONSTRAINT [FK_MateriasCarreras_Carreras_CarreraFK]
GO
ALTER TABLE [dbo].[MateriasCarreras]  WITH CHECK ADD  CONSTRAINT [FK_MateriasCarreras_Materias_MateriaFK] FOREIGN KEY([MateriaFK])
REFERENCES [dbo].[Materias] ([MateriaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MateriasCarreras] CHECK CONSTRAINT [FK_MateriasCarreras_Materias_MateriaFK]
GO
