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

        public PagoCelular AutoPago(Celular _celular)
        {
            var nuevoPago = Uow.PagosCelulares.Listado().Where(p=> p.CelularId == _celular.Id).OrderByDescending(pc => pc.FechaAlta).FirstOrDefault();
            var celular = Uow.Celulares.Obtener(c => c.Id == _celular.Id, c => c.TiposCelulares);
            if (nuevoPago == null)
            {
                nuevoPago = PagoCelularInicial(_celular);
            }
            else
            {
                nuevoPago = PagoCelularSemanal(_celular);
            }

      
            return nuevoPago;
        }
        public PagoCelular PagoCelularInicial(Celular celular)
        {
            var _monto = celular.TiposCelulares.MontoInicial; //Ver Contexto
            //monto = celular.TiposCelulares.MontoInicial;
            PagoCelular nuevoPago = new PagoCelular();
            nuevoPago.Desde = _clock.Now;
            nuevoPago.Hasta = _clock.Now.AddDays(4);
            nuevoPago.Monto = _monto * 5;
            nuevoPago.CelularId = celular.Id;
            nuevoPago.FechaAlta = _clock.Now;
            //nuevoPago.OperadorAltaId=
            //nuevoPago.SucursalAltaId=

            return nuevoPago;
        }

        public PagoCelular PagoCelularSemanal(Celular celular)
        {
            PagoCelular nuevoPago = new PagoCelular();
            nuevoPago.Desde = _clock.Now;
            nuevoPago.Hasta = _clock.Now.AddDays(6);
            nuevoPago.Monto = celular.TiposCelulares.Monto * 7;
            nuevoPago.CelularId = celular.Id;
            nuevoPago.FechaAlta = _clock.Now;
            //nuevoPago.OperadorAltaId=
            //nuevoPago.SucursalAltaId=

            return nuevoPago;
        }
    }
}
