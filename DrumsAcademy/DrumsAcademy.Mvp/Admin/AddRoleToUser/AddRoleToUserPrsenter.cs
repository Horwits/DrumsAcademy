using System;

using DrumsAcademy.Services.Auth.Contracts;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Admin.AddRoleToUser
{
    public class AddRoleToUserPrsenter : Presenter<IAddRoleToUserView>, IAddRoleToUserPrsenter
    {
        private readonly IUserAccountService service;

        public AddRoleToUserPrsenter(IAddRoleToUserView view, IUserAccountService service)
            : base(view)
        {
            this.service = service;

            this.View.OnGetUserByEmail += this.View_OnGetUserByEmail;
            this.View.OnAddRoleToUser += this.View_OnAddRoleToUser;
            this.View.OnGetAll += this.View_OnGetAll;
        }

        private void View_OnAddRoleToUser(object sender, ApplicationUserEventArgs e)
        {
            this.service.AddUserToRole(e.Role, e.Email);
        }

        private void View_OnGetAll(object sender, EventArgs e)
        {
            this.View.Model.Users = this.service.GetAllUsers();
        }

        private void View_OnGetUserByEmail(object sender, ApplicationUserEventArgs e)
        {
            this.View.Model.User = this.service.GetUserByEmail(e.Email);
        }
    }
}