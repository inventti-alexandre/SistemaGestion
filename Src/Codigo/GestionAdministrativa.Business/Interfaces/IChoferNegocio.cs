using GestionAdministrativa.Entities;
using GestionAdministrativa.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Business.Interfaces
{
    public interface IChoferNegocio :IDisposable
    {
        List<ChoferesDto> Listado(string sortBy, string sortDirection, int? dni, string apellido, Guid? movilId, bool? activo, int pageIndex, int pageSize, out int pageTotal);
      
    }
}
