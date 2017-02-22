using System;

using WebFormsMvp;

namespace DrumsAcademy.Mvp.Admin.AddRoleToUser
{
    public interface IAddRoleToUserView : IView<AddRoleToUserControlViewModel>
    {
        event EventHandler<ApplicationUserEventArgs> OnAddRoleToUser;

        event EventHandler OnGetAll;

        event EventHandler<ApplicationUserEventArgs> OnGetUserByEmail;
    }
}