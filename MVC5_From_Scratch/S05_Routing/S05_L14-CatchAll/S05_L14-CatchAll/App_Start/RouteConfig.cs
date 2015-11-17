using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace S05_L14_CatchAll
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Namespaces and Constraints
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{*catchall}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "S05_L14_CatchAll.Controllers" },
                constraints: new
                {
                    action = "Index|About", 
                    httpMethod = new HttpMethodConstraint("GET"), 
                    //id = new IntRouteConstraint()
                    id = new CompoundRouteConstraint(new IRouteConstraint[] {new IntRouteConstraint(), new MinRouteConstraint(100), })
                }
            );
        }
    }
}
