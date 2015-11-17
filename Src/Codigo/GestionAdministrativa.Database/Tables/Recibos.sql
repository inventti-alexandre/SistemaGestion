CREATE TABLE [dbo].[Recibos](
	[Id] [uniqueidentifier] NOT NULL,
	[Tipo] [char](1) NULL,
	[PuntoVenta] [int] NULL,
	[Numero] [char](14) NULL,
	[FechaAnulacion] [datetime] NULL,
	[FechaPago] [datetime] NULL,
	[Total] [money] NULL,
	[OperadorAuId] [uniqueidentifier] NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[SucursalAltaId] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[SucursalModificacionId] [int] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Recibos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_Recibos_OperadorAutoriza] FOREIGN KEY (OperadorAuId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Recibos_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Recibos_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Recibos_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Recibos_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO