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
                var groupInfo = new GroupModel(Convert.ToString(Session[Constants.AccessTokenSession]));
                return View(groupInfo);
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