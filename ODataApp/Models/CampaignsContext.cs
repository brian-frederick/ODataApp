using System.Data.Entity; 

namespace ODataApp.Models
{
    public class CampaignsContext : DbContext
    {
        public CampaignsContext()
                : base("name=CampaignsContext")
        {

        }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<GeoSystem> GeoSystems { get; set; }
    }
}