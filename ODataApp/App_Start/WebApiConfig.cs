using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ODataApp.Models;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Campaign>("Campaigns");
            builder.EntitySet<GeoSystem>("GeoSystems");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
            // Web API configuration and services

            // Web API routes


        }
    }
}
