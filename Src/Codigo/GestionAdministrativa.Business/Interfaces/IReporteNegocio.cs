using GestionAdministrativa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace GestionAdministrativa.Business.Interfaces
{
    public interface IReporteNegocio : IDisposable
    {
        List<Reporte_CajaResumida_Ingresos_Result> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);
    }
}
