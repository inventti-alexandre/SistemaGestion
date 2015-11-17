CREATE TABLE [dbo].[OrdenesPagoDetalle](
	[Id] [uniqueidentifier] NOT NULL,
	[OrdenPagoId] [uniqueidentifier] NOT NULL,
	[NumeroLinea] [int] NULL,
	[FechaPago] [datetime] NULL,
	[Descuento] [money] NULL,
	[ImportePagado] [money] NULL,
	[Efectivo] [money] NULL,
	[Cheques] [money] NULL,
	[Deposito] [money] NULL,
	[DepositoEfectivo] [money] NULL,
	[FechaAnulacion] [datetime] NULL,
	[SucursalAltaId] [int] NULL,
	[FechaAlta] [datetime] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NOT NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
	[Transferencia] [money] NULL,
	[Descripcion] [varchar](100) NULL,
	[CajaId] [uniqueidentifier] NULL,
	[OperadorAutorizaId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_s00OpPagos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[OrdenesPagoDetalle]  WITH CHECK ADD  CONSTRAINT [FK_OrdenesPagoDetalle_Cajas] FOREIGN KEY([CajaId])
REFERENCES [dbo].[Cajas] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle] CHECK CONSTRAINT [FK_OrdenesPagoDetalle_Cajas]
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPagoDetalle_OperadorAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle] CHECK CONSTRAINT [FK_OrdenesPagoDetalle_OperadorAlta]
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPagoDetalle_OperadorAutoriza] FOREIGN KEY([OperadorAutorizaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle] CHECK CONSTRAINT [FK_OrdenesPagoDetalle_OperadorAutoriza]
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPagoDetalle_OperadorModificacion] FOREIGN KEY([OperadorModificacionId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle] CHECK CONSTRAINT [FK_OrdenesPagoDetalle_OperadorModificacion]
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPagoDetalle_OrdenesPago] FOREIGN KEY([OrdenPagoId])
REFERENCES [dbo].[OrdenesPago] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle] CHECK CONSTRAINT [FK_OrdenesPagoDetalle_OrdenesPago]
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPagoDetalle_SucursalAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle] CHECK CONSTRAINT [FK_OrdenesPagoDetalle_SucursalAlta]
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle]  WITH NOCHECK ADD  CONSTRAINT [FK_OrdenesPagoDetalle_SucursalModificacion] FOREIGN KEY([SucursalModificacionId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[OrdenesPagoDetalle] CHECK CONSTRAINT [FK_OrdenesPagoDetalle_SucursalModificacion]
GO


