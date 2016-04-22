CREATE PROCEDURE [dbo].[HistorialPagosChofer]
	@Chofer uniqueidentifier = null
AS
	SELECT PC.Id, PC.FechaAlta, PC.Desde, PC.Hasta, M.Numero, PC.Monto, PC.Efectivo, PC.Vales, PC.Taller, PC.Descuento, PC.Senia 
FROM PagosCelular PC
INNER JOIN Choferes CH ON CH.Id=PC.ChoferId
INNER JOIN Moviles M ON M.Id = PC.MovilId
WHERE CH.Id=@Chofer AND (PC.Anulada = 0 OR PC.Anulada IS NUll) 
ORDER BY PC.FechaAlta DESC

