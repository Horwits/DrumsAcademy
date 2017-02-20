using System;
using System.Web.UI;

namespace DrumsAcademy.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Context.User.Identity.IsAuthenticated)
            {
                this.Response.Redirect("User/Default.aspx");
            }
        }
    }
}