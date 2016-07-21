using MVC._3SI.SalesForce.Infrastructure;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using MVC._3SI.SalesForce.Models;
using System;
using System.Web.Mvc;

namespace MVC._3SI.SalesForce.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                var profileInfo = new ProfileModel(Convert.ToString(Session[Constants.AccessTokenSession]));
                return View(profileInfo);
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