
CREATE TABLE [dbo].[Proveedores](
	[Id] [uniqueidentifier] NOT NULL,
	[Cuenta] [int] NULL,
	[Denominacion] [nvarchar](80) NULL,
	[Domicilio] [nchar](100) NULL,
	[Telefono] [char](40) NULL,
	[Celular] [char](20) NULL,
	[Fax] [char](20) NULL,
	[Contacto] [varchar](50) NULL,
	[Cuit] [nvarchar](11) NULL,
	[TipoDocumento] [int] NULL,
	[ProvinciaId] [int] NULL,
	[LocalidadId] [int] NULL,
	[CondicionCompraId] [int] NULL,
	[PorcentajeDescuento] [money] NULL,
	[Password] [nvarchar](15) NULL,
	[ProveerdorBcoId] [int] NULL,
	[CBU] [nvarchar](40) NULL,
	[GrupoProveedorId] [int] NULL,
	[PaginaWeb] [nvarchar](50) NULL,
	[EmailPedido] [nvarchar](50) NULL,
	[Estado] [int] NULL,
	[Comentarios] [ntext] NULL,
	[Gto] [bit] NULL,
	[Activo] [bit] NOT NULL,
	[SucursalAltaId] [int] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
	[PersonaContacto] [nchar](80) NULL,
 CONSTRAINT [PK_s00Prov_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


ALTER TABLE [dbo].[Proveedores] ADD  DEFAULT ((1)) FOR [Activo]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_CondicionCompra] FOREIGN KEY([CondicionCompraId])
REFERENCES [dbo].[CondicionesCompra] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_CondicionCompra]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_GrupoProveedor] FOREIGN KEY([GrupoProveedorId])
REFERENCES [dbo].[GruposProveedores] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_GrupoProveedor]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_Localidad] FOREIGN KEY([LocalidadId])
REFERENCES [dbo].[Localidades] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_Localidad]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_OperadorAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_OperadorAlta]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_OperadorModificacion] FOREIGN KEY([OperadorModificacionId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_OperadorModificacion]
GO

ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores_ProveedorBanco] FOREIGN KEY([ProveerdorBcoId])
REFERENCES [dbo].[Bancos] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_ProveedorBanco]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_Provincia] FOREIGN KEY([ProvinciaId])
REFERENCES [dbo].[Provincias] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_Provincia]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_SucursalAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_SucursalAlta]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_SucursalModificacion] FOREIGN KEY([SucursalModificacionId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_SucursalModificacion]
GO

ALTER TABLE [dbo].[Proveedores]  WITH NOCHECK ADD  CONSTRAINT [FK_Proveedores_TipoDocumentoIdentidad] FOREIGN KEY([TipoDocumento])
REFERENCES [dbo].[TiposDocumentosIdentidad] ([Id])
GO

ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_TipoDocumentoIdentidad]
GO
