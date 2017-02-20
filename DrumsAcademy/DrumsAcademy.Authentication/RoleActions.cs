using System;
using System.Linq;

using DrumsAcademy.Authentication.Contracts;
using DrumsAcademy.Authentication.Contracts.Factories;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DrumsAcademy.Authentication
{
    public class RoleActions : IRoleActions
    {
        /*private readonly IApplicationContextFactory applicationContextFactory;*/
        private readonly IdentityDbContext<ApplicationUser> context;

        /*public RoleActions(IApplicationContextFactory applicationContextFactory)
        {
            this.applicationContextFactory = applicationContextFactory;
        }*/

        public RoleActions(IdentityDbContext<ApplicationUser> context)
        {
            this.context = context;
        }


        public void CreateRole(string role)
        {
            /*this.context = this.applicationContextFactory.GetApplicationDbContext();*/

            using (this.context)
            {
                IdentityRole identityRole = new IdentityRole(role);

                var roleExist = this.context.Roles.Find(role);

                if (roleExist == null)
                {
                    this.context.Roles.Add(identityRole);
                }

                /*var roleStore = new RoleStore<IdentityRole>(this.context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                if (!roleManager.RoleExists(role))
                {
                    var identityRoleResult = roleManager.Create(new IdentityRole(role));

                    if (!identityRoleResult.Succeeded)
                    {
                        throw new Exception("Role assignment is not successfull.");
                    }
                }*/

                this.context.SaveChanges();
            }
        }

        public void AddUserToRole(string role, string userId)
        {
            using (this.context)
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.context));

                var user = this.context.Users.SingleOrDefault(x => x.Id == userId);

                var identityUserResult = userManager.AddToRole(user.Id, role);

                this.context.SaveChanges();
            }
        }
    }
}