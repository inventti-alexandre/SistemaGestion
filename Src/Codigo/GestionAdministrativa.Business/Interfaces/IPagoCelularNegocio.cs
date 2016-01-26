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
        PagoCelular AutoPago(Guid celularId);
        PagoCelular PagoCelularInicial(Guid celularId, decimal monto);
        PagoCelular PagoCelularSemanal(Guid celularId, decimal monto);
    }
}
