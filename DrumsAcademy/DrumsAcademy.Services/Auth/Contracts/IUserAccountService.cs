using System;
using System.Linq;

using DrumsAcademy.Authentication;

namespace DrumsAcademy.Services.Auth.Contracts
{
    public interface IUserAccountService
    {
        int AddUserToRole(string role, string email);

        int DeleteUser(string email);

        IQueryable<ApplicationUser> GetAllUsers();

        IQueryable<ApplicationUser> GetTopFiveUsers();

        ApplicationUser GetUserByEmail(string email);

        ApplicationUser GetUserById(Guid? id);
    }
}