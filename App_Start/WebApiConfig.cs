using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Ejemplo01
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Marcos: Aqui se envian todos los controles en jSon Serializados

            var formater = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            formater.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

        }
    }
}
