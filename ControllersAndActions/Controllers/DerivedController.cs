using ControllersAndActions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        // GET: Derived
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Indexmethod" + Request.UserHostAddress + "  " + Request.Url + "  " + RouteData.Route;
            return View("MyView");
        }

        public ActionResult ProductOutput()
        {
            return Redirect("/Basic/Index");
        }

        public ActionResult RenameProduct()
        {
            string userName = User.Identity.Name;
            string serverName = Server.MachineName;
            string clientIP = Request.UserHostAddress;
            DateTime dateStamp = HttpContext.Timestamp;
            return View("MyView");
        }
    }
}