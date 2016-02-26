CREATE TABLE [dbo].[ChoferesMovil]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Choferid] UNIQUEIDENTIFIER NULL, 
    [MovilId] UNIQUEIDENTIFIER NULL, 
    [Alta] DATETIME NULL, 
    [Baja] DATETIME NULL, 
    [FechaAlta] DATETIME NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NULL, 
    [SucursalAltaId] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [FK_ChoferesMovil_Chofer] FOREIGN KEY (ChoferId) REFERENCES Choferes(Id), 
    CONSTRAINT [FK_ChoferesMovil_Movil] FOREIGN KEY (MovilId) REFERENCES Moviles(Id), 
    CONSTRAINT [FK_ChoferesMovil_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ChoferesMovil_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ChoferesMovil_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ChoferesMovil_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
