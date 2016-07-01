using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAdministrativa.Entities.Dto;

namespace GestionAdministrativa.Business.Interfaces
{
    public interface ITalleresMovilesNegocio : IDisposable
    {
        //List<TalleresMovilesD> Listado(string sortBy, string sortDirection, int? numero, string patente, bool? activo, int pageIndex, int pageSize, out int pageTotal);
        //Movil ObtenerPorId(Guid movilId);

        List<TalleresMovilesDto> Listado(string sortBy, string sortDirection,int? numero, bool? activo, int pageIndex, int pageSize, out int pageTotal);
    }
}
