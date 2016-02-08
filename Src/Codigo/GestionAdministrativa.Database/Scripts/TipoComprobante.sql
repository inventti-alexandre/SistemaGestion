
INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 1,'Monto a Favor','MontoFavor'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'MontoFavor') 


INSERT INTO [dbo].[TiposComprobantes] ([Id] ,[Nombre] ,[Abreviatura])
SELECT 2,'Pago Sistema','PagoSis'
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposComprobantes WHERE Abreviatura = 'PagoSis') 