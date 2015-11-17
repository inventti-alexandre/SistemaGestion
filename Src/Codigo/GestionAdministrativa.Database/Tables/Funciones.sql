CREATE TABLE [dbo].[Funciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[kccodfunc] [nchar](12) NULL,
	[Comentario] [nvarchar](50) NULL,
	[DefinicionTecnica] [nvarchar](50) NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 [FechaAlta] DATETIME NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    CONSTRAINT [PK_Funciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
     CONSTRAINT [FK_Funciones_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Funciones_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Funciones_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Funciones_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]
