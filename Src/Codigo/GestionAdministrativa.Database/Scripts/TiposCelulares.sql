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
Insert into [dbo].TiposCelulares ([Tipo],[Monto],FechaAlta,OperadorAltaId,SucursalAltaId) 
select  N'Propio',25,N'1900-01-01 01:00:00.923',N'4FB4CAF7-9FD7-4A39-BF85-B60F14C2E7AB',1 
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposCelulares WHERE Tipo = 'Propio')

Insert into [dbo].TiposCelulares ([Tipo],[Monto],FechaAlta,OperadorAltaId,SucursalAltaId) 
select N'Apipe',31,N'1900-01-01 01:00:00.923',N'4FB4CAF7-9FD7-4A39-BF85-B60F14C2E7AB',1 
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposCelulares WHERE Tipo = 'Apipe')

