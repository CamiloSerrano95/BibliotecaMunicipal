USE [BibliotecaMunicipal]
GO
/****** Object:  Table [dbo].[Areas]    Script Date: 11/24/2018 00:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Areas](
	[areCodigo] [int] NOT NULL,
	[areNombre] [varchar](50) NOT NULL,
	[areTiempo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Areas] PRIMARY KEY CLUSTERED 
(
	[areCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/24/2018 00:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[usuDocumento] [varchar](12) NOT NULL,
	[usuNombre] [varchar](50) NOT NULL,
	[usuDireccion] [varchar](50) NOT NULL,
	[usuTelefono] [varchar](50) NOT NULL,
	[usuCorreo] [varchar](50) NOT NULL,
	[usuEstado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[usuDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 11/24/2018 00:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prestamos](
	[preCodigo] [int] IDENTITY(1,1) NOT NULL,
	[preFecha] [date] NOT NULL,
	[preUsuario] [varchar](12) NOT NULL,
 CONSTRAINT [PK_Prestamos] PRIMARY KEY CLUSTERED 
(
	[preCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 11/24/2018 00:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Libros](
	[libCodigo] [int] NOT NULL,
	[libNombre] [varchar](50) NOT NULL,
	[libNumPag] [varchar](5) NOT NULL,
	[libAutor] [varchar](50) NOT NULL,
	[libEditorial] [varchar](50) NOT NULL,
	[libArea] [int] NOT NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[libCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sanciones]    Script Date: 11/24/2018 00:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sanciones](
	[sanCodigo] [int] NOT NULL,
	[sanPrestano] [int] NOT NULL,
	[sanDiasSancion] [int] NOT NULL,
	[sanFechaInicio] [date] NOT NULL,
	[sanFechaFin] [date] NOT NULL,
 CONSTRAINT [PK_Sanciones] PRIMARY KEY CLUSTERED 
(
	[sanCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesPrestamos]    Script Date: 11/24/2018 00:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesPrestamos](
	[dtpPrestamo] [int] NOT NULL,
	[dtpLibro] [int] NOT NULL,
	[dtpCantidad] [int] NOT NULL,
	[dtpFechaFin] [date] NOT NULL,
	[dtpFechaVen] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_DetallesPrestamos_Libros]    Script Date: 11/24/2018 00:05:52 ******/
ALTER TABLE [dbo].[DetallesPrestamos]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPrestamos_Libros] FOREIGN KEY([dtpLibro])
REFERENCES [dbo].[Libros] ([libCodigo])
GO
ALTER TABLE [dbo].[DetallesPrestamos] CHECK CONSTRAINT [FK_DetallesPrestamos_Libros]
GO
/****** Object:  ForeignKey [FK_DetallesPrestamos_Prestamos]    Script Date: 11/24/2018 00:05:52 ******/
ALTER TABLE [dbo].[DetallesPrestamos]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPrestamos_Prestamos] FOREIGN KEY([dtpPrestamo])
REFERENCES [dbo].[Prestamos] ([preCodigo])
GO
ALTER TABLE [dbo].[DetallesPrestamos] CHECK CONSTRAINT [FK_DetallesPrestamos_Prestamos]
GO
/****** Object:  ForeignKey [FK_Libros_Areas]    Script Date: 11/24/2018 00:05:52 ******/
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Areas] FOREIGN KEY([libArea])
REFERENCES [dbo].[Areas] ([areCodigo])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Areas]
GO
/****** Object:  ForeignKey [FK_Prestamos_Usuarios]    Script Date: 11/24/2018 00:05:52 ******/
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Usuarios] FOREIGN KEY([preUsuario])
REFERENCES [dbo].[Usuarios] ([usuDocumento])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamos_Usuarios]
GO
/****** Object:  ForeignKey [FK_Sanciones_Prestamos]    Script Date: 11/24/2018 00:05:52 ******/
ALTER TABLE [dbo].[Sanciones]  WITH CHECK ADD  CONSTRAINT [FK_Sanciones_Prestamos] FOREIGN KEY([sanPrestano])
REFERENCES [dbo].[Prestamos] ([preCodigo])
GO
ALTER TABLE [dbo].[Sanciones] CHECK CONSTRAINT [FK_Sanciones_Prestamos]
GO
