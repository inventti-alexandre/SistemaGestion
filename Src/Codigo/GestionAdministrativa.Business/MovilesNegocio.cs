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
    public class MovilesNegocio : BusinessBase, IMovilesNegocio 
    {
        private IClock _clock;

        public MovilesNegocio(IGestionAdministrativaUow uow,IClock clock)
        {
            Uow = uow;
            //UowFactory = uowFactory;
            _clock = clock;
        }


        public Movil ObtenerPorId(Guid movilId)
        {
            using (var uow = UowFactory.Create<IGestionAdministrativaUow>())
            {
                return uow.Moviles.Obtener(c => c.Id == movilId);    
            }
        }

        public List<MovilesDto> Listado(string sortBy, string sortDirection, int? numero, string patente, bool? activo, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Denominacion";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Movil,bool> >where=
                                            x =>
                                                (numero == 0 || x.Numero.ToString().Contains(numero.ToString())) &&
                                                (string.IsNullOrEmpty(patente) || x.Patente.Contains(patente)) &&
                                                (x.Activo==activo);

            var resultados = Uow.Moviles.Listado(criteros,where,
                                                    x=> x.Numero);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<MovilesDto>().ToList();


        }


    }
}
