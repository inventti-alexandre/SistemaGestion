CREATE TABLE [dbo].[TiposDocumentosIdentidad](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Abreviatura] [nvarchar](10) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Prioridad] [int] NULL,
	[FechaAlta] [datetime] NULL,
 CONSTRAINT [PK_TiposDocumentosIdentidad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
