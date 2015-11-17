CREATE TABLE [dbo].[GruposProveedores](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Abreviatura] [nvarchar](10) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[SucursalAltaId] [int] NULL,
	[FechaAlta] [datetime] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 CONSTRAINT [PK_GruposProveedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_GruposProveedores_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id),
	CONSTRAINT [FK_GruposProveedores_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id),
	CONSTRAINT [FK_GruposProveedores_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id),
	CONSTRAINT [FK_GruposProveedores_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO
