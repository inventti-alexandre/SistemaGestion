CREATE TABLE [dbo].[Bancos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[NombreCorto] [nchar](10) NULL,
	[ProvinciaId] [int] NULL,
	[LocalidadId] [int] NULL,
	[Domicilio] [varchar](50) NULL,
	[Contacto] [varchar](50) NULL,
	[TE1] [varchar](20) NULL,
	[TE2] [varchar](20) NULL,
	[FechaAlta] [datetime] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[SucursalAltaId] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 CONSTRAINT [PK_Bancos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Bancos]  WITH CHECK ADD  CONSTRAINT [FK_Bancos_Localidad] FOREIGN KEY([LocalidadId])
REFERENCES [dbo].[Localidades] ([Id])
GO

ALTER TABLE [dbo].[Bancos] CHECK CONSTRAINT [FK_Bancos_Localidad]
GO

ALTER TABLE [dbo].[Bancos]  WITH CHECK ADD  CONSTRAINT [FK_Bancos_OperadoresAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Bancos] CHECK CONSTRAINT [FK_Bancos_OperadoresAlta]
GO

ALTER TABLE [dbo].[Bancos]  WITH CHECK ADD  CONSTRAINT [FK_Bancos_OperadorModificacion] FOREIGN KEY([OperadorModificacionId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Bancos] CHECK CONSTRAINT [FK_Bancos_OperadorModificacion]
GO

ALTER TABLE [dbo].[Bancos]  WITH CHECK ADD  CONSTRAINT [FK_Bancos_Provincia] FOREIGN KEY([ProvinciaId])
REFERENCES [dbo].[Provincias] ([Id])
GO

ALTER TABLE [dbo].[Bancos] CHECK CONSTRAINT [FK_Bancos_Provincia]
GO

ALTER TABLE [dbo].[Bancos]  WITH CHECK ADD  CONSTRAINT [FK_Bancos_SucursalAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Bancos] CHECK CONSTRAINT [FK_Bancos_SucursalAlta]
GO

ALTER TABLE [dbo].[Bancos]  WITH CHECK ADD  CONSTRAINT [FK_Bancos_SucursalModificacion] FOREIGN KEY([SucursalModificacionId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Bancos] CHECK CONSTRAINT [FK_Bancos_SucursalModificacion]
GO



