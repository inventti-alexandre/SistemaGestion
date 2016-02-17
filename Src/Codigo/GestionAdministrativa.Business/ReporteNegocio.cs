using Framework.Common.Utility;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAdministrativa.Entities;

namespace GestionAdministrativa.Business
{
    public  class ReporteNegocio: BusinessBase, GestionAdministrativa.Business.Interfaces.IReporteNegocio   
    {
        private IClock _clock;

        public ReporteNegocio(IGestionAdministrativaUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
        }

        public List<Reporte_CajaResumida_Ingresos_Result> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.CajaResumidaIngresos(inicio, fin, sucursalId, operadorId);
        }

        public List<Reporte_CajaResumida_ComposicionIngresos_Result> CajaResumidaIngresosComposicion(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.CajaResumidaIngresosComposicion(inicio, fin, sucursalId, operadorId);
        }
    }
}
