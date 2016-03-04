CREATE TABLE [dbo].[ChoferCelular]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Choferid] UNIQUEIDENTIFIER NULL, 
    [CelularId] UNIQUEIDENTIFIER NULL, 
    [Alta] DATETIME NULL, 
    [Baja] DATETIME NULL, 
    [FechaAlta] DATETIME NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NULL, 
    [SucursalAltaId] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [FK_ChoferesCelular_Chofer] FOREIGN KEY (ChoferId) REFERENCES Choferes(Id), 
    CONSTRAINT [FK_ChoferesCelular_Celular] FOREIGN KEY ([CelularId]) REFERENCES Celulares(Id), 
    CONSTRAINT [FK_ChoferesCelular_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ChoferesCelular_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ChoferesCelular_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ChoferesCelular_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
