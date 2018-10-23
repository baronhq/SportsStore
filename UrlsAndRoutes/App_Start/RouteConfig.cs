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

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                 constraints: new
                 {
                     customConstraint = new UserAgentConstraint("Chrome")
                 },
                namespaces: new[] { "UrlsAndRoutes.Controllers" }
            );

            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("myRoute", myRoute);
            //routes.MapRoute("MyRoute2", "{controller}/{action}", new { controller = "Home", action = "Index" });
            //routes.MapRoute("MyRoute", "p{controller}/{action}", new { controller = "Home", action = "Index" });
            //routes.MapRoute("MyRoute1", "{controller}/{action}", new { controller = "Home", action = "Index" });

            //routes.MapRoute(
            //    name: "ChromeRoute",
            //    url: "{*catchall}",
            //    defaults: new { controller = "Home", action = "Index" },
            //    constraints: new
            //    {
            //        customConstraint = new UserAgentConstraint("Chrome")
            //    },
            //namespaces: new[] { "UrlsAndRoutes.AdditionalControllers" }
            //);

            //Route route1 = routes.MapRoute("Default", "{controller}/{action}/{id}/{*aaa}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    },
            //    new
            //    {
            //        controller = "^H.*",
            //        action = "^Index$|^CustomVariable$",
            //        httpMethod = new HttpMethodConstraint("GET"),
            //        //id = new RangeRouteConstraint(10, 20)
            //        id = new CompoundRouteConstraint(new IRouteConstraint[] {
            //            new AlphaRouteConstraint(),
            //            new MinLengthRouteConstraint(6)
            //        })
            //    },
            //    new[] { "UrlsAndRoutes.Controllers" });

            //routes.MapRoute("Default2", "{controller}/{action}/{id}/{*aaa}",
            // new
            // {
            //     controller = "Home",
            //     action = "Index2",
            //     id = UrlParameter.Optional
            // },
            // new[] { "UrlsAndRoutes.AdditionalControllers2" });

            //route1.DataTokens["UseNamespaceFallback"] = false;
        }
    }
}
