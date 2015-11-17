using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace GestionAdministrativa.Security
{
    public interface IGestionAdministrativaContext
    {
        //Operador OperadorActual { get; }
        //Sucursal SucursalActual { get; }
        //Caja CajaActual { get; }
        bool IsInRole(string roles);
        bool EsOpedatorAdmin { get; }
    }
}
