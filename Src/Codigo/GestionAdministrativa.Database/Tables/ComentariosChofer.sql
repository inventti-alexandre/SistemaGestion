CREATE TABLE [dbo].[ComentariosChofer]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ChoferId] UNIQUEIDENTIFIER NOT NULL, 
    [ComentarioId] UNIQUEIDENTIFIER NOT NULL, 
    [Activo] BIT NULL, 
    [FechaAlta] DATETIME NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NULL, 
    [SucursalAltaId] INT NULL, 
    CONSTRAINT [FK_ComentariosChofer_Chofer] FOREIGN KEY (ChoferId) REFERENCES Choferes(Id), 
    CONSTRAINT [FK_ComentariosChofer_Comentario] FOREIGN KEY (ComentarioId) REFERENCES Comentarios(Id), 
    CONSTRAINT [FK_ComentariosChofer_Operador] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ComentariosChofer_Sucursal] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id)
)
