﻿CREATE TABLE [dbo].[Celulares]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [TipoCelularId] INT NULL, 
    [Alta] DATETIME NULL, 
    [Baja] DATETIME NULL, 
    [Activo] BIT NULL, 
    [Pagare] BIT NULL, 
    [Habilitado] BIT NULL, 
    [FechaUltimoPago] DATETIME NULL, 
    [FechaProximoPago] DATETIME NULL, 
    [Observacion] VARCHAR(50) NULL, 
    [DiaPagoId] INT NULL, 
    [FechaVencimientoPago] DATETIME NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NULL, 
    [SucursalAltaId] INT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaAlta] DATETIME NULL, 
    [FechaModificacion] DATETIME NULL, 
    [EmpresaCelular] INT NULL, 
    [Numero] NCHAR(20) NULL, 
    [Imei] NVARCHAR(50) NULL, 
    [SIM] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [DiaCargaId] INT NULL, 
    [ModeloCelularId] INT NULL, 
    [NumeroPagare] NCHAR(40) NULL, 
    CONSTRAINT [FK_Celulares_TipoCelular] FOREIGN KEY (TipoCelularId) REFERENCES TiposCelulares(Id), 
    CONSTRAINT [FK_Celulares_DiaPago] FOREIGN KEY (DiaPagoId) REFERENCES Dias(Id), 
    CONSTRAINT [FK_Celulares_OperadoresAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Celulares_SucursalesAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Celulares_OperadoresModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Celulares_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Celulares_EmpresaCelular] FOREIGN KEY (EmpresaCelular) REFERENCES EmpresasCelulares(Id), 
    CONSTRAINT [FK_Celulares_DiaCarga] FOREIGN KEY ([DiaCargaId]) REFERENCES Dias(Id), 
    CONSTRAINT [FK_Celulares_Modelo] FOREIGN KEY ([ModeloCelularId]) REFERENCES ModelosCelulares(Id)
)
