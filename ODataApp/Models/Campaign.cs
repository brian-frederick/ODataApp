using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataApp.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Geotype { get; set; }
        public string District { get; set; }

        //public GeoSystem[] Systems {get; set;}
    }
}