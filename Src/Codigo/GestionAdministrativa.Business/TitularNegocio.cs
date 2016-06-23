using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Framework.Common.Extentensions;
using Framework.Common.Utility;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Helpers;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Entities.Dto;

namespace GestionAdministrativa.Business
{
    public class TitularNegocio : BusinessBase, ITitularNegocio
    {
         public TitularNegocio(IGestionAdministrativaUow uow,IClock clock)
        {
            Uow = uow;
        }
        public List<TitularesDto> Listado(string sortBy, string sortDirection, int? dni, string apellido, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Apellido";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "ASC";

            System.Linq.Expressions.Expression<Func<Titulare, bool>> where =
                                            x =>
                                                (dni == 0 || x.DNI == dni) 
                                                && (string.IsNullOrEmpty(apellido) || SqlFunctions.PatIndex(apellido, x.Apellido) > 0)
                                                ;

            var resultados = Uow.Titulares.Listado(criteros, where);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<TitularesDto>().ToList();
        }
    }
}
