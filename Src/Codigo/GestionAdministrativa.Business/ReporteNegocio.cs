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
    public  class ReporteNegocio: BusinessBase, IReporteNegocio
    {
        private IClock _clock;

        public ReporteNegocio(IGestionAdministrativaUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
        }

        public List<Reporte_CajaResumida_Ingresos_Result> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            //return Uow.Reportes(inicio, fin, sucursalId, operadorId);
            return new List<Reporte_CajaResumida_Ingresos_Result>();
        }
    }
}
