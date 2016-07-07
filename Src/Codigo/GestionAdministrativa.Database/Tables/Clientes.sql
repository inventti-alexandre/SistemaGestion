CREATE TABLE [dbo].[Clientes]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Dni] INT NULL, 
    [Apellido] VARCHAR(50) NULL, 
    [Nombre] VARCHAR(50) NULL, 
    [Telefono] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Domicilio] VARCHAR(250) NULL, 
    [Saldo] MONEY NULL, 
	[Activo] BIT NULL, 
	[OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
	[FechaAlta] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaModficacion] DATETIME NULL, 

	CONSTRAINT [FK_Clientes_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Clientes_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Clientes_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Clientes_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
)
