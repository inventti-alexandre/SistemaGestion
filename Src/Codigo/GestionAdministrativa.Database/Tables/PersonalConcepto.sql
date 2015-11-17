CREATE TABLE [dbo].[PersonalConcepto](
	[ID] [uniqueidentifier] NOT NULL,
	[PersonalId] [uniqueidentifier] NOT NULL,
	[ConceptoId] [int] NOT NULL,
	[Importe] [nchar](10) NOT NULL,
	[Vigente] [bit] NULL,
	[FechaAlta] [datetime] NOT NULL,
	[OperadorAltaId] [uniqueidentifier] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
 [SucursalAltaId] INT NULL, 
    [SucursalModificacionId] INT NULL, 
    CONSTRAINT [PK_PersonalConcepto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY], 
    CONSTRAINT [FK_PersonalConcepto_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PersonalConcepto_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_PersonalConcepto_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_PersonalConcepto_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PersonalConcepto]  WITH CHECK ADD  CONSTRAINT [FK_PersonalConcepto_Conceptos] FOREIGN KEY([ConceptoId])
REFERENCES [dbo].[Conceptos] ([Id])
GO

ALTER TABLE [dbo].[PersonalConcepto] CHECK CONSTRAINT [FK_PersonalConcepto_Conceptos]
GO

ALTER TABLE [dbo].[PersonalConcepto]  WITH CHECK ADD  CONSTRAINT [FK_PersonalConcepto_Personal] FOREIGN KEY([PersonalId])
REFERENCES [dbo].[Personal] ([Id])
GO

ALTER TABLE [dbo].[PersonalConcepto] CHECK CONSTRAINT [FK_PersonalConcepto_Personal]
GO