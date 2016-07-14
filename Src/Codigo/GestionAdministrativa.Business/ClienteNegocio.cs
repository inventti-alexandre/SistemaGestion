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
    public class ClienteNegocio : BusinessBase, IClienteNegocio
    {
         public ClienteNegocio(IGestionAdministrativaUow uow,IClock clock)
        {
            Uow = uow;
        }
        public List<ClientesDto> Listado(string sortBy, string sortDirection, int? dni, string apellido , Guid? numero , bool? activo, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Apellido";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "ASC";

            System.Linq.Expressions.Expression<Func<Cliente, bool>> where =
                                            x =>
                                                (dni == 0 || x.Dni == dni) 
                                                && (string.IsNullOrEmpty(apellido) || SqlFunctions.PatIndex(apellido, x.Apellido) > 0)
                                                && (numero == Guid.Empty || x.Id == numero)
                                                 && (x.Activo == activo)
                                                ;

            var resultados = Uow.Clientes.Listado(criteros, where);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<ClientesDto>().ToList();
        }
     
    }
}
