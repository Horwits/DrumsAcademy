using DrumsAcademy.Authentication.AssemblyId;

using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace DrumsAcademy.WebForms.BindingModules
{
    public class DefaulAuthenticationtModule : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind(
                x => x.FromAssemblyContaining<IDefaultAuthAssemblyId>().SelectAllClasses().BindDefaultInterface());
        }
    }
}