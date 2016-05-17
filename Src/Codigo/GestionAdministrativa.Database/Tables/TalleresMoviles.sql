CREATE TABLE [dbo].[TalleresMoviles]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [TallerId] UNIQUEIDENTIFIER NOT NULL, 
    [MovilId] UNIQUEIDENTIFIER NOT NULL, 
    [FechaDesde] DATETIME NOT NULL, 
    [FechaEstimativaHasta] DATETIME NULL, 
    [FechaHasta] DATETIME NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    CONSTRAINT [FK_TalleresMoviles_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TalleresMoviles_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TalleresMoviles_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TalleresMoviles_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
