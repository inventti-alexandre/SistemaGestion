using System.Threading;
using Framework.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Security
{
    public class GestionAdministrativaContext : IGestionAdministrativaContext
    {
        //public Operador OperadorActual
        //{
        //    get { return GestionAdministrativaIdentity.Operador; }
        //}

        private GestionAdministrativaIdentity GestionAdministrativaIdentity
        {
            get
            {
                var gestionAdministrativaPrincipal = Thread.CurrentPrincipal as GestionAdministrativaPrincipal;
                return gestionAdministrativaPrincipal != null ? gestionAdministrativaPrincipal.Identity as GestionAdministrativaIdentity : null;
            }
        }

        private GestionAdministrativaPrincipal GestionAdministrativaPrincipal
        {
            get
            {
                return Thread.CurrentPrincipal as GestionAdministrativaPrincipal;
            }
        }

        //public Sucursal SucursalActual
        //{
        //    get { return GestionAdministrativaIdentity.Sucursal; }
        //}

        //public Caja CajaActual
        //{
        //    get
        //    {
        //        return new Caja();
        //        //using (var cajaNegocio = Ioc.Container.Get<ICajaNegocio>())
        //        //{
        //        //    return cajaNegocio.UltimaCaja(this.OperadorActual.Id, this.SucursalActual.Id);
        //        //}
        //    }
        //}

        public bool IsInRole(string role)
        {
            return GestionAdministrativaPrincipal.IsInRole(role);
        }


        public bool EsOpedatorAdmin
        {
            get
            {
                return this.IsInRole(RolesNames.Admin) || this.IsInRole(RolesNames.SuperAdmin);
            }
        }
    }
}
