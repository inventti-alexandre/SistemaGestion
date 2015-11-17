CREATE TABLE [dbo].[CelularesMovimiento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CelularId] [uniqueidentifier] NOT NULL,
	[TipoComprobanteId] [int] NULL,
	[ComprobanteId] [uniqueidentifier] NULL,
	[Concepto] [nvarchar](50) NULL,
	[Debe] [money] NULL,
	[Haber] [money] NULL,
	[Observaciones] [nvarchar](100) NULL,
	[FechaAlta] [datetime] NOT NULL,
	[SucursalAltaId] [int] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[SucursalModificacionId] [int] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_CelularesMovimiento_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_CelularesMovimiento_Celular] FOREIGN KEY (CelularId) REFERENCES Celulares(Id), 
    CONSTRAINT [FK_CelularesMovimiento_TipoComprobante] FOREIGN KEY (TipoComprobanteId) REFERENCES TiposComprobantes(Id), 
    CONSTRAINT [FK_CelularesMovimiento_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_CelularesMovimiento_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_CelularesMovimiento_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_CelularesMovimiento_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO