using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Net;
using System.Web.Optimization;
using MvcApp.App_Start;

namespace MVC._3SI.SalesForce
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ServicePointManager.SecurityProtocol
                = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
