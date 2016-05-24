
INSERT INTO [dbo].[TiposMovimientosCajas] ([Id],[Nombre],[Abreviatura],[TipoMovimiento])
SELECT 1,'COBRANZA SISTEMA','Sistema',1
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[TiposMovimientosCajas] WHERE Abreviatura ='Sistema' )


INSERT INTO [dbo].[TiposMovimientosCajas] ([Id],[Nombre],[Abreviatura],[TipoMovimiento])
SELECT 2,'PAGO A PROVEEDORES','PagoProv',2
WHERE NOT EXISTS (SELECT 2 FROM [dbo].[TiposMovimientosCajas] WHERE Abreviatura ='PagoProv' )


INSERT INTO [dbo].[TiposMovimientosCajas] ([Id],[Nombre],[Abreviatura],[TipoMovimiento])
SELECT 3,'PAGO A PROVEEDORES CON CAJA ANTERIOR','PagoProvCant',2
WHERE NOT EXISTS (SELECT 3 FROM [dbo].[TiposMovimientosCajas] WHERE Abreviatura ='PagoProvCant' )

INSERT INTO [dbo].[TiposMovimientosCajas] ([Id],[Nombre],[Abreviatura],[TipoMovimiento])
SELECT 4,'PAGO BASE','PagoBase',3
WHERE NOT EXISTS (SELECT 4 FROM [dbo].[TiposMovimientosCajas] WHERE Abreviatura ='PagoBase' )