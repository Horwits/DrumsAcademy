using System.Linq;

using DrumsAcademy.Authentication;

namespace DrumsAcademy.Mvp.Admin.AddRoleToUser
{
    public class AddRoleToUserControlViewModel
    {
        public ApplicationUser User { get; set; }

        public IQueryable<ApplicationUser> Users { get; set; }
    }
}