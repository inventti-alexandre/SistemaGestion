

Insert into [dbo].[Proveedores]([Id],[Denominacion],[Gto],[Activo],[SucursalAltaId],[FechaAlta],[OperadorAltaId])
select N'd30ec82e-f42c-432f-8ad3-322ea5df28b9', N'Personal', 1, 1, 1, GETDATE(),N'3fab7da5-a380-4f98-93ef-860fc97584f6'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Proveedores] WHERE Id = N'd30ec82e-f42c-432f-8ad3-322ea5df28b9')

Insert into [dbo].[Proveedores]([Id],[Denominacion],[Gto],[Activo],[SucursalAltaId],[FechaAlta],[OperadorAltaId])
select N'574ef14d-acbc-4b7c-bf91-e5fca78afb28', N'Claro', 1, 1, 1, GETDATE(),N'3fab7da5-a380-4f98-93ef-860fc97584f6'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].[Proveedores] WHERE Id = N'574ef14d-acbc-4b7c-bf91-e5fca78afb28')