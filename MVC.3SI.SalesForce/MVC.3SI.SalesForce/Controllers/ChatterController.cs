using System.Web.Mvc;
using MVC._3SI.SalesForce.Infrastructure;
using MVC._3SI.SalesForce.Models;
using System;

namespace MVC._3SI.SalesForce.Controllers
{
    public class ChatterController : BaseController
    {
        public ActionResult Index()
        {
            var chatter = new ChatterModel(Convert.ToString(Session[Constants.AccessTokenSession]));
            return View(chatter);
        }
    }
}