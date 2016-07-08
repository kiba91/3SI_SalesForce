using System.Web.Mvc;

namespace MVC._3SI.SalesForce.Controllers
{
    public class ChatterController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}