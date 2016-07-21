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

                var session = this.Session;
                if (session["UserProfile"] != null)
                {
                    return View(session["UserProfile"]);
                }
                else
                {
                    var profileInfo = new ProfileModel(Convert.ToString(Session[Constants.AccessTokenSession]));
                    Session["UserProfile"] = profileInfo;
                    return View(session["UserProfile"]);
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