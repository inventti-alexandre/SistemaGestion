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
	WHERE	(CM.TipoMovimientoCajaId = 1
			--OR CM.TipoMovimientoCajaId = 2
			)
			AND CM.FechaAlta >= @FechaInicio
			AND CM.FechaAlta < @FechaFin
			AND CM.SucursalAltaId = @SucursalId
			AND (@OperadorId IS NULL OR @OperadorId = CM.OperadorAltaId)
			AND (@CajaId IS NULL OR @CajaId = CM.CajaId)
	GROUP BY C.Nombre
		
	SELECT C.Nombre,
		   Cantidad = ISNULL(CTE.Cantidad, 0),
		   Total = ISNULL(CTE.Total, 0)
	FROM @Conceptos C
		LEFT JOIN @Temp CTE
			ON C.Nombre = CTE.Concepto

