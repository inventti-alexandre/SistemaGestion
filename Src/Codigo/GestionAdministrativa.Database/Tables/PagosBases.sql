CREATE TABLE [dbo].[PagosBases]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PagoMovil] UNIQUEIDENTIFIER NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [FK_PagosBases_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PagosBases_SucursalAltaId] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_PagosBases_OperadorModificacionId] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PagosBases_SucursalModificacionId] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
