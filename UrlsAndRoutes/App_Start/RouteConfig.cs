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
            routes.MapRoute(
                name: "MyRoute",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = "DefaultId" }
            );
            //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //    routes.MapRoute(
            //   name: "ShopSchema",
            //   url: "Shop/{action}",
            //   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //    routes.MapRoute(
            //      name: "",
            //      url: "X{controller}/{action}",
            //      defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //   );

            //    routes.MapRoute(
            //        name: "MyRoute",
            //        url: "{controller}/{action}",
            //        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //    );

            //    routes.MapRoute(
            //     name: "",
            //     url: "Public/{controller}/{action}",
            //     defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            // );


            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("MyRoute", myRoute);
        }
    }
}
