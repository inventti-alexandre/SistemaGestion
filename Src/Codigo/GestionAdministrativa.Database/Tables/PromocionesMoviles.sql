CREATE TABLE [dbo].[PromocionesMoviles]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PromocionId] UNIQUEIDENTIFIER NOT NULL, 
    [MovilId] UNIQUEIDENTIFIER NOT NULL, 
    [FechaDesde] DATETIME NOT NULL, 
    [FechaHasta] DATETIME NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    CONSTRAINT [FK_PromocionesMoviles_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PromocionesMoviles_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_PromocionesMoviles_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PromocionesMoviles_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
