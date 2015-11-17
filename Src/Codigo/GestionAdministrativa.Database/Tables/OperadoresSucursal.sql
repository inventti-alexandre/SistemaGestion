CREATE TABLE [dbo].[OperadoresSucursales](
	[Id] [uniqueidentifier] NOT NULL,
	[OperadorId] [uniqueidentifier] NOT NULL,
	[SucursalId] [int] NOT NULL,
	[Activo] [bit] NULL,
	[FechaAlta] [datetime] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[SucursalAltaId] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 CONSTRAINT [PK_OperadoresSucursal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
     CONSTRAINT [FK_OperadoresSucursal_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_OperadoresSucursal_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_OperadoresSucursal_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_OperadoresSucursal_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]
