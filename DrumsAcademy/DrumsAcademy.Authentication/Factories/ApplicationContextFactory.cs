using DrumsAcademy.Authentication.Contracts.Factories;

using Microsoft.AspNet.Identity.EntityFramework;

namespace DrumsAcademy.Authentication.Factories
{
    public class ApplicationContextFactory : IApplicationContextFactory
    {
        public IdentityDbContext<ApplicationUser> GetApplicationDbContext()
        {
            return ApplicationDbContext.Create();
        }
    }
}