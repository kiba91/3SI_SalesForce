using MVC._3SI.SalesForce.Infrastructure;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using MVC._3SI.SalesForce.Models;
using System;
using System.Web.Mvc;

namespace MVC._3SI.SalesForce.Controllers
{
    public class GroupController : Controller
    {
        //
        // GET: /Group/

        public ActionResult Index()
        {
            try
            {
                var session = this.Session;
                if (session["GroupInfo"] != null)
                {
                    return View(session["GroupInfo"]);
                }
                else
                {
                    var groupInfo = new GroupModel(Convert.ToString(Session[Constants.AccessTokenSession]));
                    Session["GroupInfo"] = groupInfo;
                    return View(session["GroupInfo"]);
                }
            }
            catch (Exception)
            {
                var accessTokenService = new AccessTokenService();
                return Redirect(accessTokenService.AuthorizationEndpoint);
                throw;
            }
        }
    }
}