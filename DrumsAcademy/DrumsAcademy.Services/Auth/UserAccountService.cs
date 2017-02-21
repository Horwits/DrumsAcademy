using System;
using System.Linq;

using Bytes2you.Validation;

using DrumsAcademy.Authentication;
using DrumsAcademy.Services.Auth.Contracts;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DrumsAcademy.Services.Auth
{
    public class UserAccountService : IUserAccountService
    {
        private readonly IdentityDbContext<ApplicationUser> context;

        public UserAccountService(IdentityDbContext<ApplicationUser> context)
        {
            this.context = context;
        }

        public int AddUserToRole(string role, string email)
        {
            Guard.WhenArgument(role, "role").IsNullOrEmpty().IsNullOrWhiteSpace().Throw();

            Guard.WhenArgument(email, "email").IsNullOrEmpty().IsNullOrWhiteSpace().Throw();

            var identityRole = new IdentityRole(role);

            var roleExist = this.context.Roles.Find(role);
            if (roleExist != null)
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.context));

                var user = this.context.Users.SingleOrDefault(x => x.Email == email);
                Guard.WhenArgument(user, "user").IsNull().Throw();

                userManager.AddToRole(user.Id, role);
            }

            return this.context.SaveChanges();
        }

        public int DeleteUser(string email)
        {
            var toBeDeleted = this.context.Users.SingleOrDefault(x => x.Email.Contains(email));
            Guard.WhenArgument(toBeDeleted, "user").IsNull().Throw();

            this.context.Users.Remove(toBeDeleted);

            return this.context.SaveChanges();
        }

        public ApplicationUser GetUserByEmail(string email)
        {
            var user = this.context.Users.SingleOrDefault(x => x.Email.Contains(email));
            Guard.WhenArgument(user, "user").IsNull().Throw();

            return user;
        }

        /* public IQueryable<ApplicationUser> GetAllUsers()
        {
            var result = this.context.Users.Include(x => x.Resources);
            Guard.WhenArgument(result, "users").IsNull().Throw();

            return result;
        }

        public IQueryable<ApplicationUser> GetTopFiveUsers()
        {
            var result = this.context.Users.Include(x => x.Resources).Take(5);
            Guard.WhenArgument(result, "users").IsNull().Throw();

            return result;
        }*/
        public ApplicationUser GetUserById(Guid? id)
        {
            var user = this.context.Users.Find(id);
            Guard.WhenArgument(user, "user").IsNull().Throw();

            return user;
        }

        public int InsertRole(string role)
        {
            Guard.WhenArgument(role, "role").IsNullOrEmpty().IsNullOrWhiteSpace().Throw();

            var identityRole = new IdentityRole(role);

            var roleExist = this.context.Roles.Find(role);

            if (roleExist == null)
            {
                this.context.Roles.Add(identityRole);
            }

            return this.context.SaveChanges();
        }
    }
}