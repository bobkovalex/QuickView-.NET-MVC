using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace QuickView
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // enable CORS
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();
          
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{action}",
                defaults: new { controller = "QuickViewApiController" }
            );
        }
    }
}
