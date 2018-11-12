using Filters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filters.Controllers
{
    [CustomOverrideAuthFilters]
    public class GoogleAccountController : Controller
    {
        // GET: GoogleAccount
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            if (username.EndsWith("@google.com") && password == "secret")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnUrl ?? Url.Action("index", "home"));
            }
            else
            {
                ModelState.AddModelError("", "Incorrect username or password");
                return View();
            }
        }
    }
}