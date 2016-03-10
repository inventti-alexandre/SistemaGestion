using GestionAdministrativa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Data.Interfaces
{
    public interface IReporteRepository
    {
        //IQueryable<ComprobantesByVentaId_Result> ComprobantesByVentaId(Guid ventaId);
        //IQueryable<ComprobantesDelDia1_Result> ComprobantesDelDia();
        //IQueryable<ProximasCuotasByCobrador_Result> ProximasCuotasByCobrador(int cobradorId);

        List<Reporte_CajaResumida_Ingresos_Result> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId);
        List<Reporte_CajaResumida_ComposicionIngresos_Result> CajaResumidaIngresosComposicion(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId);
        List<InformeCaja_Result > InformeCaja(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId);
        List<MovilesPorCajaId_Result> MovilesPorCajaId(Guid? cajaId);
        List<HistorialPagosChofer_Result> HistorialPagosChofer(Guid choferId);
    }

}
