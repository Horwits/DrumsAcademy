using DrumsAcademy.Authentication;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace DrumsAcademy.Authentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            this.ConfigureAuth(app);
        }
    }
}
