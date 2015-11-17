CREATE TABLE [dbo].[TiposGastos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Abreviatura] [nvarchar](10) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[BienDeUso] [bit] NULL,
	[FechaAlta] [datetime] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[SucursalAltaId] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
 CONSTRAINT [PK_s00Gasto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[TiposGastos]  WITH CHECK ADD  CONSTRAINT [FK_TiposGastos_OperadoresAlta] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[TiposGastos] CHECK CONSTRAINT [FK_TiposGastos_OperadoresAlta]
GO

ALTER TABLE [dbo].[TiposGastos]  WITH CHECK ADD  CONSTRAINT [FK_TiposGastos_OperadoresModificacion] FOREIGN KEY([OperadorAltaId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[TiposGastos] CHECK CONSTRAINT [FK_TiposGastos_OperadoresModificacion]
GO

ALTER TABLE [dbo].[TiposGastos]  WITH CHECK ADD  CONSTRAINT [FK_TiposGastos_SucursalesAlta] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[TiposGastos] CHECK CONSTRAINT [FK_TiposGastos_SucursalesAlta]
GO

ALTER TABLE [dbo].[TiposGastos]  WITH CHECK ADD  CONSTRAINT [FK_TiposGastos_SucursalesModificacion] FOREIGN KEY([SucursalAltaId])
REFERENCES [dbo].[Sucursales] ([Id])
GO

ALTER TABLE [dbo].[TiposGastos] CHECK CONSTRAINT [FK_TiposGastos_SucursalesModificacion]
GO


