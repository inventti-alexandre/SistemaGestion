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
            _clock = clock;
        }

        public PagoCelular AutoPago(Guid celularId)
        {
            var nuevoPago = Uow.PagosCelulares.Listado().Where(p=> p.CelularId == celularId).OrderByDescending(pc => pc.FechaAlta).FirstOrDefault();
            var celular = Uow.Celulares.Obtener(c=>c.Id == celularId, c=>c.TiposCelulares);
            if (nuevoPago == null)
            {
                nuevoPago = PagoCelularInicial(celularId, celular.TiposCelulares.Monto);
            }
            else
            {
                nuevoPago = PagoCelularSemanal(celularId, celular.TiposCelulares.Monto);
            }

      
            return nuevoPago;
        }
        public PagoCelular PagoCelularInicial(Guid celularId, decimal monto)
        {
            var _monto = 20; //Ver Contexto
            monto = 20;
            PagoCelular nuevoPago = new PagoCelular();
            nuevoPago.Desde = _clock.Now;
            nuevoPago.Hasta = _clock.Now.AddDays(4);
            nuevoPago.Monto = monto * 5;
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
            nuevoPago.Hasta = _clock.Now.AddDays(6);
            nuevoPago.Monto = monto * 7;
            nuevoPago.CelularId = celularId;
            nuevoPago.FechaAlta = _clock.Now;
            //nuevoPago.OperadorAltaId=
            //nuevoPago.SucursalAltaId=

            return nuevoPago;
        }
    }
}
