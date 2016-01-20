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
    public class PagoCelularNegocio : BusinessBase, IPagoCelularNegocio
    {
        private IClock _clock;
        public PagoCelularNegocio(IGestionAdministrativaUow uow, IClock clock)
        {
            Uow = uow;
        }

        public PagoCelular PagoCelularInicial(Guid celularId, decimal monto)
        {
            PagoCelular nuevoPago = new PagoCelular();
            nuevoPago.Desde = _clock.Now;
            nuevoPago.Desde = _clock.Now.AddDays(4);
            nuevoPago.Efectivo = monto * 5;
            nuevoPago.Monto = monto;
            nuevoPago.CelularId = celularId;
            nuevoPago.FechaAlta = _clock.Now;
            //nuevoPago.OperadorAltaId=
            //nuevoPago.SucursalAltaId=

            return nuevoPago;
        }

        public PagoCelular PagoCelularSemanal(Guid celularId, decimal monto)
        {
            PagoCelular nuevoPago = new PagoCelular();
            nuevoPago.Desde = _clock.Now;
            nuevoPago.Desde = _clock.Now.AddDays(6);
            nuevoPago.Efectivo = monto * 7;
            nuevoPago.Monto = monto;
            nuevoPago.CelularId = celularId;
            nuevoPago.FechaAlta = _clock.Now;
            //nuevoPago.OperadorAltaId=
            //nuevoPago.SucursalAltaId=

            return nuevoPago;
        }
    }
}
