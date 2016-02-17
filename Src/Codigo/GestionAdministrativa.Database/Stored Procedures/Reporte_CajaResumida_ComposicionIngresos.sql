CREATE PROCEDURE [dbo].[Reporte_CajaResumida_ComposicionIngresos]
		@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null
AS
	SELECT Efectivo = ISNULL(SUM(CM.Efectivo), 0),
		   Vales = ISNULL(SUM(CM.Vales), 0)
		 --  Cheque = ISNULL(SUM(CM.Cheque), 0),
		  -- Depositos = ISNULL(SUM(CM.Deposito), 0),
		  -- Vales = 0
	FROM CajasMovimientos CM
	WHERE (CM.TipoMovimientoCajaId = 1
			--OR CM.TipoMovimientoCajaId = 2
			)
			AND CM.FechaAlta >= @FechaInicio
			AND CM.FechaAlta < @FechaFin
			AND CM.SucursalAltaId = @SucursalId
			AND (@OperadorId IS NULL OR @OperadorId = CM.OperadorAltaId)

