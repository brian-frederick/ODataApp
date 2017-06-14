using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataApp.Models
{
    public class GeoSystem
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string SystemType { get; set; }
        public string Provider { get; set; }
    }
}