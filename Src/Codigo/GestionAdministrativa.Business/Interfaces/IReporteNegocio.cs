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
        List<Reporte_CajaResumida_Ingresos_Result> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId);
        List<Reporte_CajaResumida_ComposicionIngresos_Result> CajaResumidaIngresosComposicion(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId);
        List<InformeCaja_Result> InformeCaja(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? cajaId);
    }
}
