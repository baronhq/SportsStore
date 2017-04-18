using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Route myRoute = routes.MapRoute(
            //      name: "MyRoute",
            //      url: "{controller}/{action}/{id}/{*catchall}",
            //      defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //      );
            //Route myRoute = routes.MapRoute(
            //       name: "MyRoute",
            //       url: "Home/{action}/{id}/{*catchall}",
            //       defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //       namespaces: new[] { "UrlsAndRoutes.AdditionalControllers" }
            //       );
            //myRoute.DataTokens["UseNamespaceFallback"] = false;

            routes.MapRoute(
               name: "MyRoute1",
               url: "{controller}/{action}/{id}/{*catchall}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               constraints: new
               {
                   controller = "^H.*",
                   action = "^Index$|^About$|^CustomVariable",
                   httpMethod = new HttpMethodConstraint("GET"),
                   id = new RangeRouteConstraint(10, 20)
               },
               namespaces: new[] { "UrlsAndRoutes.Controllers" }
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
