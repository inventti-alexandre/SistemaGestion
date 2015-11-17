CREATE TABLE [dbo].[OperadoresRoles](
	[OpetadorId] [uniqueidentifier] NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OpetadorId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[OperadoresRoles]  WITH CHECK ADD  CONSTRAINT [FK_OperadoresRoles_Operadores] FOREIGN KEY([OpetadorId])
REFERENCES [dbo].[Operadores] ([Id])
GO

ALTER TABLE [dbo].[OperadoresRoles] CHECK CONSTRAINT [FK_OperadoresRoles_Operadores]
GO

ALTER TABLE [dbo].[OperadoresRoles]  WITH CHECK ADD  CONSTRAINT [FK_OperadoresRoles_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO

ALTER TABLE [dbo].[OperadoresRoles] CHECK CONSTRAINT [FK_OperadoresRoles_Roles]
GO
