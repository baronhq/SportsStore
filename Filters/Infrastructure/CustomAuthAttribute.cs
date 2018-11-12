using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {
        private bool localAllowed;

        private string controller;
        private string action;

        public CustomAuthAttribute(bool allowedParam)
        {
            localAllowed = allowedParam;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            controller = (string)filterContext.RouteData.Values["controller"];
            action = (string)filterContext.RouteData.Values["action"];
            base.OnAuthorization(filterContext);
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsAuthenticated)
            {
                if ((controller.ToLower() == "home" || controller.ToLower() == "customer") && (action.ToLower() == "list" || action.ToLower() == "index" || action.ToLower() == "rangetest"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //if (httpContext.Request.IsLocal)
            //{
            //    return localAllowed;
            //}
            //else
            //{
            //    return true;
            //}
        }
    }
}