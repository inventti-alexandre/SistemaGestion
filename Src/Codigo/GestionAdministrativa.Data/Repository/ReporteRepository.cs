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

        public List<Reporte_CajaResumida_Ingresos_Result> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return GestionAdministrativaDbContext.Reporte_CajaResumida_Ingresos(sucursalId, inicio, fin, operadorId).ToList();
        }

        public List<Reporte_CajaResumida_ComposicionIngresos_Result> CajaResumidaIngresosComposicion(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return GestionAdministrativaDbContext.Reporte_CajaResumida_ComposicionIngresos(sucursalId, inicio, fin, operadorId).ToList();
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