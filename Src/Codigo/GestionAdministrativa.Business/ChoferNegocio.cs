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
    public class ChoferNegocio : BusinessBase, IChoferNegocio
    {
         public ChoferNegocio(IGestionAdministrativaUow uow,IClock clock)
        {
            Uow = uow;
        }
        public List<ChoferesDto> Listado(string sortBy, string sortDirection, int? dni, string apellido , Guid? movilId , bool? activo, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Apellido";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "ASC";

            System.Linq.Expressions.Expression<Func<Chofer, bool>> where =
                                            x =>
                                                (dni == 0 || x.Dni == dni) 
                                                && (string.IsNullOrEmpty(apellido) || SqlFunctions.PatIndex(apellido, x.Apellido) > 0)
                                                && (movilId == null || x.MovilId == movilId)
                                                 && (x.Activo == activo)
                                                ;

            var resultados = Uow.Choferes.Listado(criteros, where, x=> x.Movil);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<ChoferesDto>().ToList();
        }

        //public decimal DeudaSistema(Guid choferId)
        //{
        //    var cuentasCorrientes = Uow.ClientesCuentasCorrientes.Listado()
        //                                                         .Where(cc => cc.ClienteId == clienteId &&
        //                                                               (!sucursalId.HasValue || cc.SucursalAltaId == sucursalId));

        //    return (decimal)cuentasCorrientes.Select(cc => cc.Importe - cc.Pagado).DefaultIfEmpty(0).Sum();
        //}

     
    }
}
