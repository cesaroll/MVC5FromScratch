using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace S06_L18_Views
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "GetById", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Name",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Student", action = "GetByName", name = UrlParameter.Optional }
            );
        }
    }
}
