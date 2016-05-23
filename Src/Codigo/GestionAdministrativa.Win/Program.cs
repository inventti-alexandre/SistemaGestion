using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Common.Tasks;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Security;
using GestionAdministrativa.Win.Forms;
//using GestionAdministrativa.Win;
using Ninject;
using log4net;
using GestionAdministrativa.Win.Forms.Autenticacion;

namespace GestionAdministrativa.Win
{
    static class Program
    {
        private static IMessageBoxDisplayService MessageBoxDisplayService;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if (!DEBUG)
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
#endif

            AutoMapperConfig.Execute();
            MetadataTypesRegister.InstallForThisAssembly();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            using (var kernel = new StandardKernel())
            {
                //Configurar bindings
                IoCConfig.Configure(kernel);

                //Set global container.
                Ioc.Container = new NinjectIocContainer(kernel);
                //Framework.Ioc.Ninject. = new NinjectIocContainer(kernel);

                //Config log4net
                log4net.Config.DOMConfigurator.Configure();

                MessageBoxDisplayService = Ioc.Container.Get<IMessageBoxDisplayService>();

                ////  Create a custom principal with an anonymous identity at startup
                var gestionAdministrativaPrincipal = new GestionAdministrativaPrincipal();
                AppDomain.CurrentDomain.SetThreadPrincipal(gestionAdministrativaPrincipal);

            #if(MOCK_SECURITY)
                            MockUser();
            #else
                using (var login = kernel.Get<FrmLogin>())
                {
                    var result = login.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    }
                }
            #endif
                RunAfterLoginTasks();
                var mainForm = kernel.Get<FrmPrincipal>();

                Application.Run(mainForm);
            }
        }

        private static void RunAfterLoginTasks()
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                foreach (var task in Ioc.Container.GetAll<IRunAfterLogin>())
                {
                    task.Execute();
                }
            }
        }

        private static void MockUser()
        {
            using (var uow = Ioc.Container.Get<IGestionAdministrativaUow>())
            {
               // var defaultUserId = Guid.Parse("a1ef533d-4016-497c-b065-61de49926181"); //Gabriel
                var defaultUserId = Guid.Parse("004045db-2b27-4ad7-8a96-a7b372aae7cf"); //Maria
                // var defaultUserId = Guid.Parse("f273ae90-a217-49f8-a581-7df22b150ba0"); //Abel
                

                var defaultSucursalId = 1;

                //Validate credentials through the authentication service
                Operador user = uow.Operadores.Obtener(o => o.Id == defaultUserId
                                                        //, o => o.Roles,
                                                          //  o => o.Personal
                                                          //  ,o => o.Personal.Provincia,
                                                            //o => o.Personal.Localidad,
                                                         //   o => o.OperadorSucursals.Select(op => op.Sucursal)
                                                         );
            
                Sucursal sucursal = uow.Sucursales.Obtener(s => s.Id == defaultSucursalId);

                //Get the current principal object
                GestionAdministrativaPrincipal gestionAdministrativaPrincipal = Thread.CurrentPrincipal as GestionAdministrativaPrincipal;
                if (gestionAdministrativaPrincipal == null)
                    throw new ArgumentException("The application's default thread principal must be set to a CustomPrincipal object on startup.");

                //Authenticate the user
                gestionAdministrativaPrincipal.Identity = new GestionAdministrativaIdentity(user, sucursal);
            }
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            //MessageBoxDisplayService.ShowError(mensaje);
            Application.Exit();
        }


        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
            //MessageBoxDisplayService.ShowError(mensaje);
            Application.Exit();
        }
    }
}
