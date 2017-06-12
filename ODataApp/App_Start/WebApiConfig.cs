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
            var builder = new ODataConventionModelBuilder();

            builder.EntitySet<Campaign>("Campaigns");

            config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());


        }
    }
}
