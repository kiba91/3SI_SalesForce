using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC._3SI.SalesForce.Models;
using MVC._3SI.SalesForce.Infrastructure;

namespace MVC._3SI.SalesForce.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Index()
        {
            var profileInfo = new ProfileModel(Convert.ToString(Session[Constants.AccessTokenSession]));
            return View(profileInfo);
        }
        //
        // GET: /Profile/
        public string GetGroup()
        {
            var profileInfo = new ProfileModel(Convert.ToString(Session[Constants.AccessTokenSession]));
            return profileInfo.GroupJson;
        }

	}
}