using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity;

namespace DrumsAcademy.WebForms
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";

        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";

        private string _antiXsrfTokenValue;

        protected void ManageUserButtonId_OnServerClick(object sender, EventArgs e)
        {
            if (this.Context.User.Identity.IsAuthenticated)
            {
                if (this.Context.User.IsInRole("Admin"))
                {
                    this.Response.Redirect("Admin/AdminPanel.aspx");
                }
                else if (this.Context.User.IsInRole("Teacher"))
                {
                    this.Response.Redirect("Teacher/ManageTeacherAccount.aspx");
                }
                else
                {
                    this.Response.RedirectLocation = "Account/Manage.aspx";

                    var url = HttpContext.Current.Request.Url.AbsolutePath;
                    if (!url.Contains("Account"))
                    {
                        this.Response.Redirect(this.Response.RedirectLocation);
                    }
                }
            }
            else
            {
                this.Response.Redirect("Account/Login.aspx");
            }
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                // Set Anti-XSRF token
                this.ViewState[AntiXsrfTokenKey] = this.Page.ViewStateUserKey;
                this.ViewState[AntiXsrfUserNameKey] = this.Context.User.Identity.Name ?? string.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)this.ViewState[AntiXsrfTokenKey] != this._antiXsrfTokenValue
                    || (string)this.ViewState[AntiXsrfUserNameKey] != (this.Context.User.Identity.Name ?? string.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = this.Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                this._antiXsrfTokenValue = requestCookie.Value;
                this.Page.ViewStateUserKey = this._antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                this._antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                this.Page.ViewStateUserKey = this._antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                                         {
                                             HttpOnly = true,
                                             Value = this._antiXsrfTokenValue
                                         };
                if (FormsAuthentication.RequireSSL && this.Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }

                this.Response.Cookies.Set(responseCookie);
            }

            this.Page.PreLoad += this.master_Page_PreLoad;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.adminLink.Visible = false;
            this.teacherLink.Visible = false;

            if (HttpContext.Current.User.IsInRole("Admin"))
            {
                this.adminLink.Visible = true;
            }

            if (HttpContext.Current.User.IsInRole("Teacher"))
            {
                this.teacherLink.Visible = true;
            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            this.Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}