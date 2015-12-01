using Framework.Common.Tasks;
using Framework.Common.Utility;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using GestionAdministrativa.Security;
using GestionAdministrativa.Security.Interfaces;
using GestionAdministrativa.Win.Helpers;
using Ninject;
using Ninject.Extensions.Conventions;

namespace GestionAdministrativa.Win
{
    public class IoCConfig
    {
        public static void Configure(StandardKernel kernel)
        {
            kernel.Bind(x => x.FromAssembliesMatching("GestionAdministrativa.*")
                                 .SelectAllClasses()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InTransientScope()));

            kernel.Bind(x => x.FromAssembliesMatching("Framework.*")
                                 .SelectAllClasses()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InTransientScope()));

            kernel.Bind(x => x.FromAssembliesMatching("GestionAdministrativa.*")
                                 .SelectAllInterfaces()
                                 .EndingWith("Factory")
                                 .BindToFactory()
                                 .Configure(c => c.InSingletonScope()));

            kernel.Bind(x => x.FromThisAssembly()
                                 .SelectAllInterfaces()
                                 .Including<IRunAfterLogin>()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InSingletonScope()));

            kernel.Bind<IIocContainer>().To<NinjectIocContainer>().InSingletonScope();
            kernel.Rebind<IClock>().To<Clock>().InSingletonScope();
           // kernel.Bind<IMessageBoxDisplayService>().To<MessageBoxDisplayService>().InSingletonScope();

            //Custom Factories
            //kernel.Rebind<ICajaMovientoFactory>().To<CajaMovimientoFactory>();

            //Overide defaults bindings.
            kernel.Unbind<IGestionAdministrativaContext>();
            kernel.Bind<IGestionAdministrativaContext>().To<GestionAdministrativaContext>().InSingletonScope();

            kernel.Unbind<IFormRegistry>();
            kernel.Bind<IFormRegistry>().To<FormRegistry>().InSingletonScope();


            kernel.Unbind<IEncryptionService>();
            kernel.Bind<IEncryptionService>().To<EncryptionService>().InSingletonScope();

            //kernel.Bind<IRepository<TituloStockMigracion>>().To<EFRepository<TituloStockMigracion>>()
            //      .WithConstructorArgument("dbContext", (p) =>
            //      {
            //          var dbContext = new MigracionLaPazEntities();

            //          // Do NOT enable proxied entities, else serialization fails
            //          dbContext.Configuration.ProxyCreationEnabled = false;

            //          // Load navigation properties explicitly (avoid serialization trouble)
            //          dbContext.Configuration.LazyLoadingEnabled = false;

            //          // Because Web API will perform validation, we don't need/want EF to do so
            //          dbContext.Configuration.ValidateOnSaveEnabled = false;

            //          return dbContext;
            //      });
        }
    }
}
