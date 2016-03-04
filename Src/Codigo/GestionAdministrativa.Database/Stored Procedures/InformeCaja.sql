CREATE PROCEDURE [dbo].[InformeCaja]
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null,
	@CajaId uniqueidentifier = null
AS

	DECLARE @Temp TABLE 
	(
		Tipo varchar(50),
		Titulo varchar(100),
		Movil varchar(20),
		Fecha datetime,
		Desde datetime,
		Hasta datetime,
		Concepto varchar(50),
		Chofer varchar(100),
		Operador varchar(50),
		ImpFac money,
		Importe money,
		Efectivo money,
		Vales money
	)

	-----------------------------------------------------------
	------------  Pagos Sistema  ------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Ingresos',
			'Pagos Sistema',
			M.Numero,
			CM.FechaAlta,
			PC.Desde,
			PC.Hasta,
			'Pagos Sistema',
			CH.Apellido,
			O.Usuario,
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Vales, 0)
	FROM CajasMovimientos CM
		LEFT JOIN PagosCelular PC
			ON CM.ComprobanteId = PC.Id
		LEFT JOIN Celulares C
			ON PC.CelularId = C.Id
		LEFT JOIN Choferes CH
			ON CH.CelularId = C.Id
		LEFT JOIN Moviles M
			ON M.Id = CH.MovilId
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 1 --Pago de Sistema
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
		AND (@CajaId IS NULL OR CM.CajaId = @CajaId)
		AND  PC.Monto IS NOT NULL
	
	SELECT * 
	FROM @Temp
	ORDER BY Tipo, Movil, Fecha
