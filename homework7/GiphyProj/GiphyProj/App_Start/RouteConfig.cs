using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GiphyProj
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "BoringRoute",
                url: "Word/BoringWords/{id}",
                defaults: new { controller = "Word", action = "BoringWords", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ExcitingRoute",
                url: "Word/FindGiphy/{id}",
                defaults: new { controller = "Word", action = "FindGiphy", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Giphy", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
