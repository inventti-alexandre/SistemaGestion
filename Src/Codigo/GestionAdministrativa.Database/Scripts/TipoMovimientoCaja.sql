
INSERT INTO [dbo].[TiposMovimientosCajas] ([Id],[Nombre],[Abreviatura],[TipoMovimiento])
SELECT 1,'COBRANZA SISTEMA','Sistema',1
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[TiposMovimientosCajas] WHERE Abreviatura ='Sistema' )
