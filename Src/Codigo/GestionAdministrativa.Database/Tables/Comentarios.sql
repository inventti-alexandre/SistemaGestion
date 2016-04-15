CREATE TABLE [dbo].[Comentarios]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [comentario] NVARCHAR(MAX) NULL, 
    [FechaAlta] DATETIME NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NULL, 
    [SucursalAltaId] INT NULL, 
    CONSTRAINT [FK_Comentarios_Operador] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Comentarios_Sucursal] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id)
)
