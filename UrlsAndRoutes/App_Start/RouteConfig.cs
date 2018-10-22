using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("myRoute", myRoute);
            routes.MapRoute("MyRoute2", "{controller}/{action}", new { controller = "Home", action = "Index" });
            routes.MapRoute("MyRoute", "p{controller}/{action}", new { controller = "Home", action = "Index" });
            routes.MapRoute("MyRoute1", "{controller}/{action}", new { controller = "Home", action = "Index" });
        }
    }
}
