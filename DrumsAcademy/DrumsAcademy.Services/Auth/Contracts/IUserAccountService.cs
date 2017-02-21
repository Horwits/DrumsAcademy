using System;

using DrumsAcademy.Authentication;

namespace DrumsAcademy.Services.Auth.Contracts
{
    public interface IUserAccountService
    {
        int AddUserToRole(string role, string email);

        int DeleteUser(string email);

        ApplicationUser GetUserByEmail(string email);

        /*IQueryable<ApplicationUser> GetAllUsers();

        IQueryable<ApplicationUser> GetTopFiveUsers();*/
        ApplicationUser GetUserById(Guid? id);
    }
}