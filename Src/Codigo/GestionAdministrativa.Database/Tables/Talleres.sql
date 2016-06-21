CREATE TABLE [dbo].[Talleres]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Descripcion] VARCHAR(50) NULL, 
    [Porcentaje] DECIMAL(4, 2) NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [Activo] BIT NULL, 
    CONSTRAINT [FK_Talleres_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Talleres_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Talleres_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Talleres_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
