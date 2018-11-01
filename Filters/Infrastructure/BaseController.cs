using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    [CustomAuth(true)]
    public class BaseController : Controller
    {
    }
}