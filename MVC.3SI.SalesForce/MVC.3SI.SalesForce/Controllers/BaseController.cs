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
            //verify user login is added to session
            if (string.IsNullOrEmpty(Convert.ToString(Session[Constants.AccessTokenSession]))) {
                Response.Redirect(ApiService.GetLoginUrl());
            }
            base.OnActionExecuting(filterContext);
        }
    }
}