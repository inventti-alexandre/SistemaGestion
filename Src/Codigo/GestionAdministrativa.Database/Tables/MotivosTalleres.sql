﻿CREATE TABLE [dbo].[MotivosTalleres]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Motivo] VARCHAR(50) NOT NULL, 
    [Activo] BIT NOT NULL
)
