using System;

namespace DrumsAcademy.Authentication.Contracts
{
    public interface IRoleActions
    {
        void CreateRole(string role);

        void AddUserToRole(string role, string userId);
    }
}
