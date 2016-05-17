CREATE TABLE [dbo].[Tarifas]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Descripcion] VARCHAR(50) NULL, 
    [FechaDesde] DATETIME NOT NULL, 
    [FechaHasta] DATETIME NULL, 
    [Monto] MONEY NOT NULL, 
    [Activo] BIT NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    CONSTRAINT [FK_Tarifas_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Tarifas_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Tarifas_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Tarifas_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
