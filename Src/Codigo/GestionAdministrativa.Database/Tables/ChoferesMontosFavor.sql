CREATE TABLE [dbo].[ChoferesMontosFavor](
	[Id] [uniqueidentifier] NOT NULL,
	[ChoferId] [uniqueidentifier] NOT NULL,
	[FechaComprobante] [smalldatetime] NOT NULL,
	[TipoComprobanteId] [int] NOT NULL,
	[Concepto] [nvarchar](50) NULL,
	[Importe] [money] NULL,
	[ImpOcupado] [money] NULL,
	[FechaAnulacion] [datetime] NULL,
	[OperadorAutorizaId] [uniqueidentifier] NULL,
	[Observaciones] [nvarchar](90) NULL,
	[FechaAlta] [datetime] NOT NULL,
	[SucursalAltaId] [int] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[SucursalModificacionId] [int] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_ChoferesMontosFavor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_ChoferesMontosFavor_Choferes] FOREIGN KEY (ChoferId) REFERENCES Choferes(Id), 
    CONSTRAINT [FK_ChoferesMontosFavor_OperadorAutoriza] FOREIGN KEY (OperadorAutorizaId) REFERENCES Operadores(Id)
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[ChoferesMontosFavor]  WITH NOCHECK ADD  CONSTRAINT [FK_ChoferesMontosFavor_OperadorAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[ChoferesMontosFavor] CHECK CONSTRAINT [FK_ChoferesMontosFavor_OperadorAlta]
GO

ALTER TABLE [dbo].[ChoferesMontosFavor]  WITH NOCHECK ADD  CONSTRAINT [FK_ChoferesMontosFavor_OperadorModificacion] FOREIGN KEY([OperadorModificacionId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[ChoferesMontosFavor] CHECK CONSTRAINT [FK_ChoferesMontosFavor_OperadorModificacion]
GO

ALTER TABLE [dbo].[ChoferesMontosFavor]  WITH NOCHECK ADD  CONSTRAINT [FK_ChoferesMontosFavor_SucursalAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[ChoferesMontosFavor] CHECK CONSTRAINT [FK_ChoferesMontosFavor_SucursalAlta]
GO

ALTER TABLE [dbo].[ChoferesMontosFavor]  WITH NOCHECK ADD  CONSTRAINT [FK_ChoferesMontosFavor_SucursalModificacion] FOREIGN KEY([SucursalModificacionId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[ChoferesMontosFavor] CHECK CONSTRAINT [FK_ChoferesMontosFavor_SucursalModificacion]
GO

ALTER TABLE [dbo].[ChoferesMontosFavor]  WITH NOCHECK ADD  CONSTRAINT [FK_ChoferesMontosFavor_TipoComprobante] FOREIGN KEY([TipoComprobanteId])
REFERENCES [dbo].[TiposComprobantes] ([Id])
GO

ALTER TABLE [dbo].[ChoferesMontosFavor] CHECK CONSTRAINT [FK_ChoferesMontosFavor_TipoComprobante]
GO