using System.Web.Http;

namespace MVC._3SI.SalesForce
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration httpConfiguration) {
            httpConfiguration.Routes.MapHttpRoute("Api Default"
                , "api/{controller}/{id}", new { id = RouteParameter.Optional });
        }
    }
}