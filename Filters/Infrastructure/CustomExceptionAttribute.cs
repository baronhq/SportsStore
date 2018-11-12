using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    public class CustomExceptionAttribute : FilterAttribute, IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {

            if (!filterContext.ExceptionHandled && filterContext.Exception is ArgumentOutOfRangeException)
            {

                int val = (int)(((ArgumentOutOfRangeException)filterContext.Exception).ActualValue);
                filterContext.Result = new ViewResult
                {
                    ViewName = "CustomError",
                    ViewData = new ViewDataDictionary<int>(val)
                };
                //filterContext.Result = new RedirectResult("~/Content/RangeErrorPage.html");

                filterContext.ExceptionHandled = true;
            }
        }
    }
}