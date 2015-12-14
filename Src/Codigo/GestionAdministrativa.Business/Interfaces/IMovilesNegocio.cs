using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Entities.Dto;

namespace GestionAdministrativa.Business.Interfaces
{
    public interface IMovilesNegocio : IDisposable
    {
        List<MovilesDto> Listado(string sortBy, string sortDirection, int numero, string patente, bool? activo, int pageIndex, int pageSize, out int pageTotal);
        Movil ObtenerPorId(Guid movilId);
    }
}
