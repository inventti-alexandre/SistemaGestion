CREATE PROCEDURE [dbo].[Reporte_CajaResumida_Ingresos]
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null,
	@CajaId uniqueidentifier = null
AS
	
	DECLARE @Conceptos TABLE
	(
		Id int,
		Nombre varchar(50)
	)

	INSERT INTO @Conceptos VALUES(1, 'Pago del sistema')

	DECLARE @Temp TABLE 
	(

		Concepto varchar(50),
		Cantidad int,
		Total money
	)

	INSERT INTO @Temp
	SELECT C.Nombre,
			COUNT(*),
			SUM(CM.Importe)
	FROM CajasMovimientos CM
		LEFT JOIN @Conceptos C
			ON CM.TipoMovimientoCajaId = C.Id
	WHERE	(CM.TipoMovimientoCajaId = 1 and Cm.TipoComprobante =2)
			AND CM.FechaAlta >= @FechaInicio
			AND CM.FechaAlta < @FechaFin
			AND CM.SucursalAltaId = @SucursalId
			AND (@OperadorId IS NULL OR @OperadorId = CM.OperadorAltaId)
			AND (@CajaId IS NULL OR @CajaId = CM.CajaId)
	GROUP BY C.Nombre

	
	INSERT INTO @Temp
	SELECT C.Nombre,
			COUNT(*),
			SUM((CM.Importe * -1))
	FROM CajasMovimientos CM
		LEFT JOIN @Conceptos C
			ON CM.TipoMovimientoCajaId = C.Id
	WHERE	(CM.TipoMovimientoCajaId = 1 and Cm.TipoComprobante =3)
			AND CM.FechaAlta >= @FechaInicio
			AND CM.FechaAlta < @FechaFin
			AND CM.SucursalAltaId = @SucursalId
			AND (@OperadorId IS NULL OR @OperadorId = CM.OperadorAltaId)
			AND (@CajaId IS NULL OR @CajaId = CM.CajaId)
	GROUP BY C.Nombre
		
	SELECT C.Nombre,
		   Cantidad =SUM(ISNULL(CTE.Cantidad, 0)),
		   Total = Sum(ISNULL(CTE.Total, 0))
	FROM @Conceptos C
		LEFT JOIN @Temp CTE
			ON C.Nombre = CTE.Concepto
	GROUP BY C.Nombre

