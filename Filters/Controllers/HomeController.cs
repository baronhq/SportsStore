using Filters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {

        //[CustomAuth(true)]
        [Authorize]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }

        public string Index2()
        {
            return "This is the Index2 action on the Home controller";
        }

        [GoogleAuth]
        [Authorize(Users = "bob@google.com")]
        public string List()
        {
            return "This is the List action on the Home controller";
        }

        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return String.Format("The id value is: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        //[CustomAction]
        //[ProfileAction]
        //[ProfileResult]
        //[ProfileAll]
        public string FilterTest()
        {
            return "This is the FilterTest action";
        }
    }
}