CREATE PROCEDURE [dbo].[FueraDeSistema]

AS
	SELECT M.Numero, CH.Apellido, DATEDIFF(day,C.FechaVencimientoPago,getdate()) as 'Dias'
	from Celulares C
	INNER JOIN Choferes CH on CH.CelularId = C.Id
	INNER JOIN Moviles M on M.Id=ch.MovilId
	where C.FechaProximoPago < = GETDATE()
	order by M.Numero

