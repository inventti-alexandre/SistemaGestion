using System;

using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Services.Interfaces;

namespace GestionAdministrativa.Services
{
    public class ServiceBase : IServive
    {
        protected IGestionAdministrativaUow Uow { get; set; }

        protected IUowFactory UowFactory { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Uow != null)
                {
                    Uow.Dispose();
                    Uow = null;
                }
            }
        }

        #endregion
    }
}
