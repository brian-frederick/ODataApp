using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Data.Entity;
using ODataApp.Models;

namespace ODataApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<CampaignsContext>(new DropCreateDatabaseIfModelChanges<CampaignsContext>());
            GlobalConfiguration.Configure(WebApiConfig.Register);

        }
    }
}
