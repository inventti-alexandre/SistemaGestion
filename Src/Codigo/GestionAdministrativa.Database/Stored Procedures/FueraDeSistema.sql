CREATE PROCEDURE [dbo].[FueraDeSistema]

AS
	SELECT M.Numero AS Numero, CH.Apellido as Apellido, DATEDIFF(day,C.FechaVencimientoPago,getdate()) as 'Dias', COM.comentario AS Comentario
	FROM ComentariosChofer CC
	INNER JOIN CHOFERES CH ON CH.Id = CC.ChoferId
	INNER JOIN Celulares C ON C.Id = CH.CelularId
	INNER JOIN Moviles M ON M.Id = CH.MovilId
	INNER JOIN Comentarios COM ON COM.Id = CC.ComentarioId
	WHERE CC.Id IN (SELECT TOP 1 Id FROM ComentariosChofer CC2 WHERE CC2.ChoferId = CH.Id)
	AND C.FechaProximoPago < = GETDATE()
	AND CH.Activo = 1 

