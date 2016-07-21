CREATE TABLE [dbo].[LoteVales]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [MovilId] UNIQUEIDENTIFIER NOT NULL, 
    [NumeroDesde] INT NOT NULL, 
    [NumeroHasta] INT NOT NULL, 
    [CantidadUsada] INT NULL, 
    [Activo] BIT NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [FK_LoteVales_Moviles] FOREIGN KEY (MovilId) REFERENCES Moviles(Id), 
    CONSTRAINT [FK_LoteVales_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_LoteVales_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_LoteVales_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_LoteVales_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
