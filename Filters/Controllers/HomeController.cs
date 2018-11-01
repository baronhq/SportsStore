﻿using Filters.Infrastructure;
using System;
using System.Collections.Generic;
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
    }
}