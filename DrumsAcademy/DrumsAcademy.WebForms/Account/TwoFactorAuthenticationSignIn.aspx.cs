﻿using System;
using System.Linq;
using System.Web;
using System.Web.UI;

using DrumsAcademy.Authentication;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace DrumsAcademy.WebForms.Account
{
    public partial class TwoFactorAuthenticationSignIn : Page
    {
        private ApplicationUserManager manager;

        private ApplicationSignInManager signinManager;

        public TwoFactorAuthenticationSignIn()
        {
            this.manager = this.Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            this.signinManager = this.Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();
        }

        protected void CodeSubmit_Click(object sender, EventArgs e)
        {
            bool rememberMe = false;
            bool.TryParse(this.Request.QueryString["RememberMe"], out rememberMe);

            var result = this.signinManager.TwoFactorSignIn<ApplicationUser, string>(
                this.SelectedProvider.Value,
                this.Code.Text,
                isPersistent: rememberMe,
                rememberBrowser: this.RememberBrowser.Checked);
            switch (result)
            {
                case SignInStatus.Success:
                    IdentityHelper.RedirectToReturnUrl(this.Request.QueryString["ReturnUrl"], this.Response);
                    break;
                case SignInStatus.LockedOut:
                    this.Response.Redirect("/Account/Lockout");
                    break;
                case SignInStatus.Failure:
                default:
                    this.FailureText.Text = "Invalid code";
                    this.ErrorMessage.Visible = true;
                    break;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var userId = this.signinManager.GetVerifiedUserId<ApplicationUser, string>();
            if (userId == null)
            {
                this.Response.Redirect("/Account/Error", true);
            }

            var userFactors = this.manager.GetValidTwoFactorProviders(userId);
            this.Providers.DataSource = userFactors.Select(x => x).ToList();
            this.Providers.DataBind();
        }

        protected void ProviderSubmit_Click(object sender, EventArgs e)
        {
            if (!this.signinManager.SendTwoFactorCode(this.Providers.SelectedValue))
            {
                this.Response.Redirect("/Account/Error");
            }

            var user = this.manager.FindById(this.signinManager.GetVerifiedUserId<ApplicationUser, string>());
            if (user != null)
            {
                var code = this.manager.GenerateTwoFactorToken(user.Id, this.Providers.SelectedValue);
            }

            this.SelectedProvider.Value = this.Providers.SelectedValue;
            this.sendcode.Visible = false;
            this.verifycode.Visible = true;
        }
    }
}