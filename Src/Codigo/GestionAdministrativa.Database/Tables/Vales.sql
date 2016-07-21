CREATE TABLE [dbo].[Vales]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Numero] INT NOT NULL, 
    [MovilPresentaId] UNIQUEIDENTIFIER NULL, 
    [MovilViajeId] UNIQUEIDENTIFIER NULL, 
    [ClienteId] UNIQUEIDENTIFIER NULL, 
    [FechaViaje] DATETIME NULL, 
    [Monto] DECIMAL NULL,     
    [Presentado] BIT NULL, 
    [Facturado] BIT NULL, 
    [Aprobado] BIT NULL,
	[FechaAlta] DATETIME NULL, 
    [OperadorAlta] UNIQUEIDENTIFIER NULL, 
    [SucursalAlta] INT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [OperadorModificacion] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacion] INT NULL, 

)
