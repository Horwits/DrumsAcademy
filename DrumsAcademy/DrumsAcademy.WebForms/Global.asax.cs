using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

using DrumsAcademy.Authentication;
using DrumsAcademy.Authentication.Factories;

namespace DrumsAcademy.WebForms
{
    public class Global : HttpApplication
    {
        public void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}