﻿using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
    public class CajaNegocio : BusinessBase, ICajaNegocio
    {
         public CajaNegocio(IGestionAdministrativaUow uow,IClock clock)
        {
            Uow = uow;

        }
        public List<CajasDto> Listado(string sortBy, string sortDirection, Guid? operador , bool? aprobado, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "ASC";

            System.Linq.Expressions.Expression<Func<Caja, bool>> where =
                                            x =>
                                                //(operador == null )//|| x.OperadorAltaId == operador) 
                                                //&& (x.FCierre != null || x.FCierre == fechaCierre)
                                                //&& (movilId == null || x.MovilId == movilId)
                                                 (x.FCierre !=null)
                                                 && (x.Aprobada == aprobado)
                                                 && ((x.Efectivo >0) || (x.Vales>0) ||(x.Egresos>0))
                                                ;

            var resultados = Uow.Cajas.Listado(criteros, where);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<CajasDto>().ToList();
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
