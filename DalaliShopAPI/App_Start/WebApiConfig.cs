
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace DIVAAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // config.Filters.Add(new LoggingFilterAttribute());
            //config.Filters.Add(new GlobalExceptionAttribute());
            // Web API routes
            config.MapHttpAttributeRoutes();

            // Web API routes
            //config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
              routeTemplate: "API/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
