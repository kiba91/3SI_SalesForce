using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVC._3SI.SalesForce.Infrastructure;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;

namespace MVC._3SI.SalesForce.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //verify user login is added to cookie
            //var tokenCookie = Convert.ToString(Session[Constants.AccessTokenSession]);
            //if (string.IsNullOrEmpty(tokenCookie))
            //{
            //    var accessToken = new AccessTokenService();
            //    Response.Redirect(accessToken.AuthorizationEndpoint);
            //}
            base.OnActionExecuting(filterContext);
        }
    }
}