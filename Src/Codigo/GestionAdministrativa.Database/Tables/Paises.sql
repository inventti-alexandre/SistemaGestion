CREATE TABLE [dbo].[Paises](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Abreviatura] [varchar](10) NULL,
	[Descripcion] [varchar](50) NULL,
	[Prioridad] [int] NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]