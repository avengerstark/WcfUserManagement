using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UserManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "EditUser/{id}",
                defaults: new { controller = "Home", action = "Edit" }
            );

            routes.MapRoute(
                name: null,
                url: "CreateUser",
                defaults: new { controller = "Home", action = "Create" }
            );

            routes.MapRoute(
               name: null,
               url: "users/{page}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               constraints: new { page = @"\d+" }
           );

            routes.MapRoute(
                name: null,
                url: "",
                defaults: new { controller = "Home", action = "Index", id = 1 }
            );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
