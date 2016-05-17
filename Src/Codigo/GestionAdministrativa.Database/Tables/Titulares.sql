CREATE TABLE [dbo].[Titulares]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Apellido] VARCHAR(50) NULL, 
    [Nombre] VARCHAR(50) NULL, 
    [DNI] INT NULL, 
    [Telefono] INT NULL, 
    [Mail] VARCHAR(50) NULL, 
    [Domicilio] VARCHAR(50) NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    CONSTRAINT [FK_Titulares_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Titulares_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Titulares_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Titulares_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
