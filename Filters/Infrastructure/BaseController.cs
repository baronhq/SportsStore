using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    //[CustomAuth(true)]
    [RangeException]
    public class BaseController : Controller
    {
    }
}