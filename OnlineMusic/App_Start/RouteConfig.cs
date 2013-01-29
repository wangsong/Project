using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineMusic
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var defaultTenant = "Music";

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{TenantId}/{controller}/{action}/{id}",
                defaults: new { TenantId=defaultTenant, controller = "Account", action = "LogOn", id = UrlParameter.Optional }
            );
        }
    }
}