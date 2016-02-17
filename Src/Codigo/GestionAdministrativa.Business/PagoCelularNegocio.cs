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

        public PagoCelular AutoPago(Celular _celular,DateTime desde,DateTime hasta)
        {
            var nuevoPago = Uow.PagosCelulares.Listado().Where(p=> p.CelularId == _celular.Id).OrderByDescending(pc => pc.FechaAlta).FirstOrDefault();
            var celular = Uow.Celulares.Obtener(c => c.Id == _celular.Id, c => c.TiposCelulares);
            if (nuevoPago == null)
            {
                nuevoPago = PagoCelularInicial(_celular,desde,hasta);
            }
            else
            {
                nuevoPago = PagoCelularSemanal(_celular,desde,hasta);
            }

      
            return nuevoPago;
        }
        public PagoCelular PagoCelularInicial(Celular celular,DateTime desde,DateTime hasta)
        {
            var _monto = celular.TiposCelulares.MontoInicial; //Ver Contexto
            //monto = celular.TiposCelulares.MontoInicial;
            PagoCelular nuevoPago = new PagoCelular();
            nuevoPago.Id = Guid.NewGuid();
            nuevoPago.Desde = desde;
            TimeSpan dias = hasta - desde;
            nuevoPago.Hasta = hasta;
            nuevoPago.Monto = _monto * (dias.Days+1);
            nuevoPago.CelularId = celular.Id;
            nuevoPago.FechaAlta = _clock.Now;
            nuevoPago.OperadorAltaId = Guid.Parse("4fb4caf7-9fd7-4a39-bf85-b60f14c2e7ab");
            nuevoPago.SucursalAltaId=1;
            
            return nuevoPago;
        }

        public PagoCelular PagoCelularSemanal(Celular celular,DateTime desde,DateTime hasta)
        {
            PagoCelular nuevoPago = new PagoCelular();
            nuevoPago.Id = Guid.NewGuid();
            nuevoPago.Desde = desde.Date;
            nuevoPago.Hasta = hasta.Date;
            TimeSpan dias = hasta - desde;            
            nuevoPago.Monto = celular.TiposCelulares.Monto * (dias.Days+1);
            nuevoPago.CelularId = celular.Id;
            nuevoPago.FechaAlta = _clock.Now;
            nuevoPago.OperadorAltaId =  Guid.Parse("4fb4caf7-9fd7-4a39-bf85-b60f14c2e7ab");
            nuevoPago.SucursalAltaId = 1;

            return nuevoPago;
        }
    }
}
