using System;

namespace DrumsAcademy.Mvp.Admin.AddRoleToUser
{
    public class ApplicationUserEventArgs : EventArgs
    {
        public ApplicationUserEventArgs(string email)
        {
            this.Email = email;
        }

        public ApplicationUserEventArgs(string email, string role)
            : this(email)
        {
            this.Role = role;
        }

        public string Email { get; private set; }

        public string Role { get; private set; }
    }
}