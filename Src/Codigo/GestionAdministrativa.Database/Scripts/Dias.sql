/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
Insert into [dbo].[Dias] ([Id],[Descripcion]) 
select 1, N'Domingo' WHERE NOT EXISTS (SELECT 1 FROM [DBO].Dias WHERE Id = 1)
Insert into [dbo].[Dias] ([Id],[Descripcion]) 
select 2, N'Lunes' WHERE NOT EXISTS (SELECT 1 FROM [DBO].Dias WHERE Id = 2)
Insert into [dbo].[Dias] ([Id],[Descripcion]) 
select 3, N'Martes' WHERE NOT EXISTS (SELECT 1 FROM [DBO].Dias WHERE Id = 3)
Insert into [dbo].[Dias] ([Id],[Descripcion]) 
select 4, N'Miercoles' WHERE NOT EXISTS (SELECT 1 FROM [DBO].Dias WHERE Id = 4)
Insert into [dbo].[Dias] ([Id],[Descripcion]) 
select 5, N'Jueves' WHERE NOT EXISTS (SELECT 1 FROM [DBO].Dias WHERE Id = 5)
Insert into [dbo].[Dias] ([Id],[Descripcion]) 
select 6, N'Viernes' WHERE NOT EXISTS (SELECT 1 FROM [DBO].Dias WHERE Id = 6)
Insert into [dbo].[Dias] ([Id],[Descripcion]) 
select 7, N'Sábado' WHERE NOT EXISTS (SELECT 1 FROM [DBO].Dias WHERE Id = 7)
