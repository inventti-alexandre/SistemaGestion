using GestionAdministrativa.Entities;
using GestionAdministrativa.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Business.Interfaces
{
    public interface ICajaNegocio :IDisposable
    {
        List<CajasDto> Listado(string sortBy, string sortDirection,Guid? operador, bool? aprobado, int pageIndex, int pageSize, out int pageTotal);
      
    }
}
