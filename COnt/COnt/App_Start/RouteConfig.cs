using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace COnt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //    routes.MapRoute(
            //       name: "Address",
            //       url: "student",
            //       defaults: new { controller = "Route", action = "student", id = UrlParameter.Optional }
            //   );
            //    routes.MapRoute(
            //     name: "studentbyid",
            //     url: "studentbyid/{id}",
            //     defaults: new { controller = "Route", action = "studentbyid", id = UrlParameter.Optional },
            //     constraints: new {id = @"\d+"}

            // );
            //    routes.MapRoute(
            //    name: "studentaddress",
            //    url: "studentaddress/{id}/adress",
            //    defaults: new { controller = "Route", action = "studentbyid", id = UrlParameter.Optional },
            //    constraints: new { id = @"\d+" }

            //);
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
