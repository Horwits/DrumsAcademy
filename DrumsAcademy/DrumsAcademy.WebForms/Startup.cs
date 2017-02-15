using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrumsAcademy.WebForms.Startup))]
namespace DrumsAcademy.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
