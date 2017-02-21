using Microsoft.AspNet.Identity.EntityFramework;

namespace DrumsAcademy.Authentication.Contracts.Factories
{
    public interface IApplicationContextFactory
    {
        IdentityDbContext<ApplicationUser> GetApplicationDbContext();
    }
}