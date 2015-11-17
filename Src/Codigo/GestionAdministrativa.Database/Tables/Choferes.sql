CREATE TABLE [dbo].[Choferes]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Dni] INT NULL, 
    [Apellido] VARCHAR(50) NULL, 
    [Nombre] VARCHAR(50) NULL, 
    [Telefono] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaAlta] DATETIME NULL, 
    [FechaModificacion] DATETIME NULL, 
    CONSTRAINT [FK_Choferes_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Choferes_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Choferes_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Choferes_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
