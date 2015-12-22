CREATE TABLE [dbo].[Choferes]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Dni] INT NULL, 
    [Apellido] VARCHAR(50) NULL, 
    [Nombre] VARCHAR(50) NULL, 
    [Telefono] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
	[Activo] BIT NULL, 
	[MovilId] UNIQUEIDENTIFIER NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
	[FechaAlta] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaModficacion] DATETIME NULL, 
    CONSTRAINT [FK_Choferes_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Choferes_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Choferes_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Choferes_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Choferes_Moviles] FOREIGN KEY (MovilId) REFERENCES Moviles(Id)
)
