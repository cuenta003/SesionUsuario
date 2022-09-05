using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace SesionUsuario
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["Aplicaciones"] = 0;
            Application["SesionUsuario"] = 0;

            Application["Aplicaciones"] = (int)Application["Aplicaciones"] + 1;
        }

        void Session_Start(object sender, EventArgs e) 
        {
            Application["SesionUsuario"] = (int)Application["SesionUsuario"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            Application["SesionUsuario"] = (int)Application["SesionUsuario"] - 1;
        }
    }
}