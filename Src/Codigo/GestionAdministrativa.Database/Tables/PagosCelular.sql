CREATE TABLE [dbo].[PagosCelular]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Desde] DATETIME NULL, 
    [Hasta] DATETIME NULL, 
    [Efectivo] MONEY NULL, 
    [Vales] MONEY NULL, 
    [Taller] MONEY NULL, 
    [Monto] MONEY NOT NULL, 
    [CelularId] UNIQUEIDENTIFIER NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    CONSTRAINT [FK_PagosCelular_Celular] FOREIGN KEY (CelularId) REFERENCES Celulares(Id), 
    CONSTRAINT [FK_PagosCelular_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PagosCelular_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_PagosCelular_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PagosCelular_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
)
