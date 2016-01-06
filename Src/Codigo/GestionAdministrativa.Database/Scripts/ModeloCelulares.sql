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
Insert into [dbo].ModelosCelulares([Id],[Descripcion]) 
select 1, N'LG F60' WHERE NOT EXISTS (SELECT 1 FROM [DBO].ModelosCelulares WHERE Id = 1)

