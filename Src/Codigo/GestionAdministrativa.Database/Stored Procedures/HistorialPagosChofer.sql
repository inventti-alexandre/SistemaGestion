CREATE PROCEDURE [dbo].[HistorialPagosChofer]
	@Chofer uniqueidentifier = null
AS
	SELECT PC.FechaAlta, PC.Desde, PC.Hasta, PC.Monto, PC.Efectivo, PC.Vales, PC.Taller, PC.Descuento, PC.Senia 
FROM PagosCelular PC
INNER JOIN Celulares C ON C.Id = PC.CelularId
INNER JOIN Choferes CH ON CH.CelularId = C.Id
WHERE CH.Id=@Chofer

