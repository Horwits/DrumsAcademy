using System;
using System.ComponentModel.Design;
using System.Web;
using System.Web.Security;

using DrumsAcademy.Data;
using DrumsAcademy.Data.Contracts.DbContext;
using DrumsAcademy.Services.Auth;
using DrumsAcademy.Services.Auth.Contracts;
using DrumsAcademy.Services.Data;
using DrumsAcademy.Services.Data.Contracts;
using DrumsAcademy.WebForms.BindingModules;

using Microsoft.Web.Infrastructure.DynamicModuleHelper;

using Ninject;
using Ninject.Web.Common;

using WebFormsMvp.Binder;

using IResourceService = DrumsAcademy.Services.Data.Contracts.IResourceService;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(DrumsAcademy.WebForms.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(DrumsAcademy.WebForms.App_Start.NinjectWebCommon), "Stop")]
namespace DrumsAcademy.WebForms.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Load(new MvpNinjectModule());
            kernel.Load(new DefaulAuthenticationtModule());

            PresenterBinder.Factory = kernel.Get<IPresenterFactory>();

            kernel.Bind(typeof(IDrumsAcademyContext), typeof(IDrumsAcademyBaseContext))
               .To<DrumsAcademyContext>().InRequestScope();

            kernel.Bind<IResourceService>().To<ResourceService>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<IUserAccountService>().To<UserAccountService>();
        }
    }
}
