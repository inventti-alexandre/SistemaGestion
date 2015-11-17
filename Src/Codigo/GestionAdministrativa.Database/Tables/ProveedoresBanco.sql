CREATE TABLE [dbo].[ProveedoresBanco](
	[Id] [uniqueidentifier] NOT NULL,
	[ProveedorId] [uniqueidentifier] NOT NULL,
	[BancoId] [int] NULL,
	[CtaCte] [char](20) NULL,
	[CajaAhorro] [char](20) NULL,
	[SucursalAltaId] [int] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
	[Titular] [varchar](200) NULL,
	[CBU] [varchar](50) NULL,
 CONSTRAINT [PK_ProveedoresBanco] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_ProveedoresBanco_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id),
	CONSTRAINT [FK_ProveedoresBanco_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id),
	CONSTRAINT [FK_ProveedoresBanco_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id),
	CONSTRAINT [FK_ProveedoresBanco_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ProveedoresBanco]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresBanco_Bancos] FOREIGN KEY([BancoId])
REFERENCES [dbo].[Bancos] ([Id])
GO

ALTER TABLE [dbo].[ProveedoresBanco] CHECK CONSTRAINT [FK_ProveedoresBanco_Bancos]
GO

ALTER TABLE [dbo].[ProveedoresBanco]  WITH NOCHECK ADD  CONSTRAINT [FK_ProveedoresBanco_Proveedores] FOREIGN KEY([ProveedorId])
REFERENCES [dbo].[Proveedores] ([Id])
GO

ALTER TABLE [dbo].[ProveedoresBanco] CHECK CONSTRAINT [FK_ProveedoresBanco_Proveedores]
GO



