
INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 1,'Monto a Favor','MontoFavor'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'MontoFavor') 


INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 2,'Pago Sistema','PagoSis'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'PagoSis') 

INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 3,'Anulacion Pago Sistema','AnuPagoSis'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'AnuPagoSis') 

INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 4,'Egreso','Egreso'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'Egreso') 

INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 5,'Egreso Caja Anterior','EgresoCAnt'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'EgresoCAnt') 

INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 6,'Pago Base','PagoBase'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'PagoBase') 

INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 7,'Monto Favor Base','FavorBase'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'FavorBase') 