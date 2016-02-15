CREATE TABLE [dbo].[CajaBalance]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Ingresos] MONEY NULL, 
    [Egresos] MONEY NULL, 
    [SucursalAltaId] INT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NULL, 
    [FechaAlta] DATETIME NULL, 
    [SucursalModificacionId] INT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [FechaModificacion] DATETIME NULL, 
    CONSTRAINT [FK_CajaBalance_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_CajaBalance_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_CajaBalance_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_CajaBalance_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
)
