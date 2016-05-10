using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
namespace GestionAdministrativa.Data.Repository
{
    public class ReporteRepository : EFBaseRepository, IReporteRepository
    {
        public ReporteRepository()
        {
        }

        public ReporteRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public List<Reporte_CajaResumida_Ingresos_Result> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId)
        {
            return GestionAdministrativaDbContext.Reporte_CajaResumida_Ingresos(sucursalId, inicio, fin, operadorId, cajaId).ToList();
        }

        public List<Reporte_CajaResumida_ComposicionIngresos_Result> CajaResumidaIngresosComposicion(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId)
        {
            return GestionAdministrativaDbContext.Reporte_CajaResumida_ComposicionIngresos(sucursalId, inicio, fin, operadorId, cajaId).ToList();
        }

        public List<Reporte_CajaResumida_Egresos_Result> CajaResumidaEgresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId)
        {
            return GestionAdministrativaDbContext.Reporte_CajaResumida_Egresos(sucursalId, inicio, fin, operadorId, cajaId).ToList();
        }

        public List<InformeCaja_Result> InformeCaja(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId)
        {
            return GestionAdministrativaDbContext.InformeCaja(sucursalId, inicio, fin, operadorId, cajaId).ToList();
        }
        public List<MovilesPorCajaId_Result> MovilesPorCajaId(Guid? cajaId)
        {
            return GestionAdministrativaDbContext.MovilesPorCajaId(cajaId).ToList();
        }
        public List<HistorialPagosChofer_Result> HistorialPagosChofer(Guid choferId)
        {
            return GestionAdministrativaDbContext.HistorialPagosChofer(choferId).ToList();
        }
        public List<FueraDeSistema_Result> FueraDeSistema()
        {
            return GestionAdministrativaDbContext.FueraDeSistema().ToList();
        }
        //public IQueryable<ComprobantesByVentaId_Result> ComprobantesByVentaId(Guid ventaId)
        //{
        //    return AlejandriaDbContext.ComprobantesByVentaId(ventaId).AsQueryable();
        //}

        //public IQueryable<ComprobantesDelDia1_Result> ComprobantesDelDia()
        //{
        //    return AlejandriaDbContext.ComprobantesDelDia().AsQueryable();
        //}

        //public IQueryable<ProximasCuotasByCobrador_Result> ProximasCuotasByCobrador(int cobradorId)
        //{
        //    return AlejandriaDbContext.ProximasCuotasByCobrador(cobradorId).AsQueryable();
        //}
    }
}