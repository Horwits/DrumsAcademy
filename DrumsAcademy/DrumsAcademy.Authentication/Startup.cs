using System;

using DrumsAcademy.Authentication;
using DrumsAcademy.Authentication.Factories;

using Microsoft.Owin;

using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace DrumsAcademy.Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            RoleActions roleActions = new RoleActions(ApplicationDbContext.Create());
            /*roleActions.CreateRole("User");*/
            /*roleActions.AddUserToRole("Admin", "f178cd37-7a28-4e35-9276-9a6d5b2ae3ac");*/
            this.ConfigureAuth(app);
        }
    }
}