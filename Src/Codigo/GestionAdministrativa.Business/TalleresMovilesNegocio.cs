using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Framework.Common.Utility;
using GestionAdministrativa.Business.Interfaces;
using GestionAdministrativa.Data.Helpers;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Entities.Dto;

namespace GestionAdministrativa.Business
{
    public class TalleresMovilesNegocio : BusinessBase,ITalleresMovilesNegocio
    {
        private IClock _clock;

        public TalleresMovilesNegocio(IGestionAdministrativaUow uow, IClock clock)
        {
            Uow = uow;
            clock = _clock;
        }

        public List<TalleresMovilesDto> Listado(string sortBy, string sortDirection,int? numero, bool? activo, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<TalleresMovile, bool>> where =
                                            x =>
                                                (numero == 0 || x.Movil.Numero.ToString().Contains(numero.ToString())) &&
                                                //(string.IsNullOrEmpty(patente) || x.Patente.Contains(patente)) &&
                                                (x.Activo == activo);

            var resultados = Uow.TalleresMoviles.Listado(criteros, where,
                                                    x => x.Activo);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<TalleresMovilesDto>().ToList();


        }
    }
}
