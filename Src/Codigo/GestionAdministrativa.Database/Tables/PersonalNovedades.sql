CREATE TABLE [dbo].[PersonalNovedades](
	[Id] [uniqueidentifier] NOT NULL,
	[PersonalId] [uniqueidentifier] NOT NULL,
	[TipoNovedad] [int] NOT NULL,
	[ConceptoId] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[MesImputacion] [int] NOT NULL,
	[AnioImputacion] [int] NOT NULL,
	[Importe] [real] NOT NULL,
	[Total] [real] NULL,
	[LiquidacionPersonalId] [uniqueidentifier] NULL,
	[FechaAlta] [datetime] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
 [SucursalAltaId] INT NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [PK_s00SueCpto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
     CONSTRAINT [FK_PersonalNovedades_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PersonalNovedades_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_PersonalNovedades_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PersonalNovedades_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PersonalNovedades]  WITH CHECK ADD  CONSTRAINT [FK_PersonalNovedades_Conceptos] FOREIGN KEY([ConceptoId])
REFERENCES [dbo].[Conceptos] ([Id])
GO

ALTER TABLE [dbo].[PersonalNovedades] CHECK CONSTRAINT [FK_PersonalNovedades_Conceptos]
GO

ALTER TABLE [dbo].[PersonalNovedades]  WITH CHECK ADD  CONSTRAINT [FK_PersonalNovedades_Personal] FOREIGN KEY([PersonalId])
REFERENCES [dbo].[Personal] ([Id])
GO

ALTER TABLE [dbo].[PersonalNovedades] CHECK CONSTRAINT [FK_PersonalNovedades_Personal]
GO