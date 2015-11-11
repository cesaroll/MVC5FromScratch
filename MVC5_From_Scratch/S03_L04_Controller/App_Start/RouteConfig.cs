using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace S03_L04_Controller
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{name}/{surname}",
                defaults: new { controller = "HelloWorld", action = "SayHello", name = UrlParameter.Optional, surname = UrlParameter.Optional}
            );

            /*
            routes.MapRoute(
                name: "HelloName",
                url: "{controller}/{action}/{name}/{surname}",
                defaults: new {controller = "HelloWorld", action = "SayHelloName"}
                );
            */
        }
    }
}
