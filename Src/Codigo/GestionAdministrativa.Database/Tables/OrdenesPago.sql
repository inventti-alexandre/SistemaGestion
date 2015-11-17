CREATE TABLE [dbo].[OrdenesPago](
	[Id] [uniqueidentifier] NOT NULL,
	[SucursalId] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[LCN] [nchar](13) NULL,
	[LetraComprobante] [char](1) NULL,
	[NumeroComprobante] [nchar](13) NULL,
	[TipoGastoId] [int] NULL,
	[ProveedorId] [uniqueidentifier] NOT NULL,
	[Concepto] [nvarchar](50) NULL,
	[RegistraIVACompra] [bit] NULL,
	[SucursalGastoId] [int] NULL,
	[CentroCostoId] [int] NULL,
	[TipoComprobanteId] [int] NULL,
	[FechaImputacion] [datetime] NULL,
	[SubTotal] [money] NOT NULL,
	[Recargo] [money] NULL,
	[Importe] [money] NOT NULL,
	[ImportePagado] [money] NULL,
	[FechaAnulacion] [datetime] NULL,
	[RemitoAnticipadoId] [uniqueidentifier] NULL,
	[SucursalAltaId] [int] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 CONSTRAINT [PK_s00Op] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_CentrosCostos] FOREIGN KEY([CentroCostoId])
REFERENCES [dbo].[CentrosCostos] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_CentrosCostos]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_Comprobante] FOREIGN KEY([TipoComprobanteId])
REFERENCES [dbo].[TiposComprobantes] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_Comprobante]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_OperadorAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_OperadorAlta]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_OperadorModificacion] FOREIGN KEY([OperadorModificacionId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_OperadorModificacion]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_Proveedores] FOREIGN KEY([ProveedorId])
REFERENCES [dbo].[Proveedores] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_Proveedores]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_Sucursales] FOREIGN KEY([SucursalId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_Sucursales]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_SucursalAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_SucursalAlta]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_SucursalGasto] FOREIGN KEY([SucursalGastoId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_SucursalGasto]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPago_SucursalModificacion] FOREIGN KEY([SucursalModificacionId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_SucursalModificacion]
GO

ALTER TABLE [dbo].[OrdenesPago]  WITH CHECK ADD  CONSTRAINT [FK_OrdenesPago_TipoGasto] FOREIGN KEY([TipoGastoId])
REFERENCES [dbo].[TiposGastos] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPago] CHECK CONSTRAINT [FK_OrdenesPago_TipoGasto]
GO

