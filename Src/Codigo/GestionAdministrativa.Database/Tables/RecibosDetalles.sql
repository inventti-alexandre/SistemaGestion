CREATE TABLE [dbo].[RecibosDetalle](
	[Id] [uniqueidentifier] NOT NULL,
	[ReciboId] [uniqueidentifier] NOT NULL,
	[PagoId] [uniqueidentifier] NULL,
	[Importe] [money] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[FechaAlta] [datetime] NULL,
	[SucursalAltaId] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[SucursalModificacionId] [int] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
 [TipoReciboId] INT NOT NULL, 
    CONSTRAINT [PK_RecibosDetalle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_RecibosDetalle_Recibo] FOREIGN KEY (ReciboId) REFERENCES Recibos(Id), 
    CONSTRAINT [FK_RecibosDetalle_OperadorALta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_RecibosDetalle_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_RecibosDetalle_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_RecibosDetalle_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_RecibosDetalle_TipoRecibo] FOREIGN KEY (TipoReciboId) REFERENCES TiposRecibos(Id)
) ON [PRIMARY]

GO