CREATE TABLE [dbo].[TiposMovimientosCajas](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Abreviatura] [nvarchar](15) NULL,
	[TipoMovimiento] [int] NULL,
	[CodTipoAnt] [int] NULL,
	[FechaAlta] [datetime] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[SucursalAltaId] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 CONSTRAINT [PK_TiposMovimientosCajas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_TiposMovimientosCajas_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TiposMovimientosCajas_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TiposMovimientosCajas_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TiposMovimientosCajas_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de movimiento (Egreso / Ingreso)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TiposMovimientosCajas', @level2type=N'COLUMN',@level2name=N'CodTipoAnt'
GO
