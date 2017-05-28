using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProdutosWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            // roteamento de atributos
            // Ex.: Livros de tal autor; Filmes com tal ator; Pedidos de tal cliente;
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
