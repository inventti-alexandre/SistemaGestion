
Insert into [dbo].[Operadores]([Id],[Usuario],	[Habilitado] )
select N'004045db-2b27-4ad7-8a96-a7b372aae7cf', N'Maria', 1
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Operadores] WHERE Id = N'004045db-2b27-4ad7-8a96-a7b372aae7cf')

Insert into [dbo].[Operadores]([Id],[Usuario],	[Habilitado] )
select N'625224f9-8dc4-44ac-8b05-e011781ec8d7', N'Chino', 1
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Operadores] WHERE Id = N'625224f9-8dc4-44ac-8b05-e011781ec8d7')

Insert into [dbo].[Operadores]([Id],[Usuario],	[Habilitado] )
select N'fb7b61a9-9ef9-409b-93ab-16d190acc505', N'Hugo', 1
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Operadores] WHERE Id = N'fb7b61a9-9ef9-409b-93ab-16d190acc505')

Insert into [dbo].[Operadores]([Id],[Usuario],	[Habilitado] )
select N'f273ae90-a217-49f8-a581-7df22b150ba0', N'Abel', 1
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Operadores] WHERE Id = N'f273ae90-a217-49f8-a581-7df22b150ba0')

Insert into [dbo].[Operadores]([Id],[Usuario],	[Habilitado] )
select N'a1ef533d-4016-497c-b065-61de49926181', N'Gabriel', 1
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Operadores] WHERE Id = N'a1ef533d-4016-497c-b065-61de49926181')

Insert into [dbo].[Operadores]([Id],[Usuario],	[Habilitado] )
select N'3fab7da5-a380-4f98-93ef-860fc97584f6', N'Santy', 1
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Operadores] WHERE Id = N'3fab7da5-a380-4f98-93ef-860fc97584f6')


Insert into [dbo].[Operadores]([Id],[Usuario],	[Habilitado] )
select N'b43f3432-08d2-409e-9b82-aa400142bbe6', N'Sil', 1
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Operadores] WHERE Id = N'b43f3432-08d2-409e-9b82-aa400142bbe6')