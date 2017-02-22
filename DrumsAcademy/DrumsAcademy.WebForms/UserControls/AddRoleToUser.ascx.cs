using System;
using System.Collections.Generic;

using DrumsAcademy.Authentication;
using DrumsAcademy.Mvp.Admin.AddRoleToUser;

using WebFormsMvp;
using WebFormsMvp.Web;

namespace DrumsAcademy.WebForms.UserControls
{
    [PresenterBinding(typeof(AddRoleToUserPrsenter))]
    public partial class AddRoleToUserControl : MvpUserControl<AddRoleToUserControlViewModel>, IAddRoleToUserView
    {
        public event EventHandler<ApplicationUserEventArgs> OnAddRoleToUser;

        public event EventHandler OnGetAll;

        public event EventHandler<ApplicationUserEventArgs> OnGetUserByEmail;

        public ApplicationUser User { get; private set; }

        /*public void FormView_AddRoleToUser()
        {
            var role = "User";
            var mail = this.LiteralSearchQuery.Text;
            this.OnAddRoleToUser?.Invoke(this, new ApplicationUserEventArgs(mail, role));
        }*/

        /*protected void OnClick(object sender, EventArgs e)
        {
            this.OnGetUserByEmail?.Invoke(this, new ApplicationUserEventArgs("horwits@abv.bg"));
           this.User = this.Model.User;

            if (!this.IsPostBack)
            {
                this.FormView.DataSource = this.User;
                this.FormView.DataBind();
            }
        }*/
        public IEnumerable<ApplicationUser> On_GetAllUsers()
        {
            this.OnGetAll?.Invoke(this, new EventArgs());
            return this.Model.Users;
        }
    }
}