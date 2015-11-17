using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Ioc;
using GestionAdministrativa.Data.Interfaces;

namespace GestionAdministrativa.Data.Helpers
{
    public class UowFactory : IUowFactory
    {
        private readonly IIocContainer _container;

        public UowFactory(IIocContainer container)
        {
            _container = container;
        } 

        public T Create<T>()
        {
            return _container.Get<T>();
        }
    }
}
