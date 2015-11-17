CREATE TABLE [dbo].[Moviles]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Numero] INT NOT NULL, 
    [Patente] VARCHAR(6) NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
     CONSTRAINT [FK_Moviles_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Moviles_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Moviles_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Moviles_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
