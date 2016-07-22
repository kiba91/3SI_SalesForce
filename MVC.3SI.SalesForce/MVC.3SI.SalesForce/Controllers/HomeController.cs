using MVC._3SI.SalesForce.Infrastructure;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC._3SI.SalesForce.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logoff()
        {
            var accessToken = Convert.ToString(Session[Constants.AccessTokenSession]);
            var accessTokenService = new AccessTokenService();
            var apiService = new ApiService(accessToken);
            accessTokenService.PostRevoke(accessToken);
            Session.Abandon();
            Response.Cookies.Remove(Constants.RefreshAccessTokenSession);
            return RedirectToAction("Index","Home");
        }
    }
}