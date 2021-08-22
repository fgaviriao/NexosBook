using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BookApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            config.EnableCors();

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional },
                constraints: new { id = @"^[0-9]+$" }
            );

            config.Routes.MapHttpRoute(
                name: "ActionIdApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional}
            );

           // config.Routes.MapHttpRoute(
           //    name: "ActionApi",
           //    routeTemplate: "api/{controller}/{action}",
           //    defaults: new { id = RouteParameter.Optional },
           //    constraints: new { id = @"^[0-9]+$" }
           //);
        }
    }
}
