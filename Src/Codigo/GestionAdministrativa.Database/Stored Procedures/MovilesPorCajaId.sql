CREATE PROCEDURE [dbo].[MovilesPorCajaId]

	@CajaId uniqueidentifier = null
AS
SELECT  Distinct(m.Numero) as Movil
FROM PagosCelular PC
INNER JOIN CajasMovimientos CM ON CM.ComprobanteId=PC.Id
INNER JOIN Choferes CH ON CH.CelularId = PC.CelularId
INNER JOIN Moviles M ON M.Id = CH.MovilId
WHERE (@CajaId IS NULL OR CM.CajaId = @CajaId)

