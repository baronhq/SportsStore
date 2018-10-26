using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //启用属性路由
            routes.MapMvcAttributeRoutes();
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("new1", "App/Do222{action}", new { controller = "Home", vara = "aa" });

            routes.Add(new Route("SayHello", new CustomRouteHandler()));

            routes.Add(new LegacyRoute(
                  "~/articles/Windows_3.1_Overview.html",
                  "~/old/.NET_1.0_Class_Library"));

            routes.MapRoute(name: "MyRoute", url: "{controller}/{action}");

            routes.MapRoute("MyOtherRoute", "App/{action}", new { controller = "Home" });
        }
    }
}
