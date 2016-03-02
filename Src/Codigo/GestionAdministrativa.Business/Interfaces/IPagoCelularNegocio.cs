using GestionAdministrativa.Entities;
using GestionAdministrativa.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Business.Interfaces
{
    public interface IPagoCelularNegocio : IDisposable
    {
        PagoCelular AutoPago(Celular celular, DateTime desde, DateTime hasta, Guid operadorId);
        PagoCelular PagoCelularInicial(Celular _celular, DateTime desde, DateTime hasta, Guid operadorId);
        PagoCelular PagoCelularSemanal(Celular _celular, DateTime desde, DateTime hasta, Guid operadorId);
    }
}
