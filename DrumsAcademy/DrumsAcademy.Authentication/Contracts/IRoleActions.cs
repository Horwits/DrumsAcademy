namespace DrumsAcademy.Authentication.Contracts
{
    public interface IRoleActions
    {
        void AddUserToRole(string role, string userId);

        void CreateRole(string role);
    }
}