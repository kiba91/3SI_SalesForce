using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC._3SI.SalesForce.Infrastructure;
namespace MVC._3SI.SalesForce.Controllers
{
    public class AuthenticationController : Controller
    {
        public void Index(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                Session[Constants.AccessTokenSession] = code;
                Response.Redirect("/chatter");
            }
            Response.Write("Sorry, we can not get your access token. Please try again.");
        }
    }
}