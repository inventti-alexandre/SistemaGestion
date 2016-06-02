CREATE TABLE [dbo].[MotivosTalleres]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Motivo] VARCHAR(50) NULL, 
    [Descuento] FLOAT NOT NULL
)
