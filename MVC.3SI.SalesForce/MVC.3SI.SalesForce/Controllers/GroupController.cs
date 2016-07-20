using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC._3SI.SalesForce.Models;
using MVC._3SI.SalesForce.Infrastructure;

namespace MVC._3SI.SalesForce.Controllers
{
    public class GroupController : Controller
    {
        //
        // GET: /Group/
        public ActionResult Index()
        {
            var groupInfo = new GroupModel(Convert.ToString(Session[Constants.AccessTokenSession]));
            return View(groupInfo);
        }
	}
}