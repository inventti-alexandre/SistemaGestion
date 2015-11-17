CREATE TABLE [dbo].[TiposCelulares]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Tipo] VARCHAR(50) NOT NULL, 
    [Monto] MONEY NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [FK_TiposCelulares_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TiposCelulares_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TiposCelulares_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TiposCelulares_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
    
    
)
