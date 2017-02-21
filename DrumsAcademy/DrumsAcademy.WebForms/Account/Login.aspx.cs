using System;
using System.Web;
using System.Web.UI;

using DrumsAcademy.Authentication;

using Microsoft.AspNet.Identity.Owin;

namespace DrumsAcademy.WebForms.Account
{
    public partial class Login : Page
    {
        protected void LogIn(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                var owinContext = HttpContext.Current.Request.GetOwinContext();

                // Validate the user password
                var signinManager = owinContext.GetUserManager<ApplicationSignInManager>();

                var manager = owinContext.GetUserManager<ApplicationUserManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                var result = signinManager.PasswordSignIn(
                    this.Email.Text,
                    this.Password.Text,
                    this.RememberMe.Checked,
                    shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:
                        if (signinManager.AuthenticationManager.User.Identity.IsAuthenticated)
                        {
                            IdentityHelper.RedirectToReturnUrl(this.Request.QueryString["/User/Default"], this.Response);
                        }

                        break;
                    case SignInStatus.LockedOut:
                        this.Response.Redirect("/Account/Lockout");
                        break;
                    case SignInStatus.RequiresVerification:
                        this.Response.Redirect(
                            string.Format(
                                "/account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}",
                                this.Request.QueryString["/User/Default"],
                                this.RememberMe.Checked),
                            true);
                        break;
                    case SignInStatus.Failure:
                    default:
                        this.FailureText.Text = "Invalid login attempt";
                        this.ErrorMessage.Visible = true;
                        break;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.RegisterHyperLink.NavigateUrl = "Register";

            // Enable this once you have account confirmation enabled for password reset functionality
            // ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            this.OpenAuthLogin.ReturnUrl = this.Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(this.Request.QueryString["ReturnUrl"]);
            if (!string.IsNullOrEmpty(returnUrl))
            {
                this.RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            if (this.Context.User.Identity.IsAuthenticated)
            {
                IdentityHelper.RedirectToReturnUrl(this.Request.QueryString["/User/Default"], this.Response);
            }
        }
    }
}