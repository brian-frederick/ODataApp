
using ODataApp.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace ODataApp.Controllers
{
    public class CampaignsController : ODataController
    {
        CampaignsContext db = new CampaignsContext();
        private bool CampaignExists(int key)
        {
            return db.Campaigns.Any(c => c.Id == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        [EnableQuery]
        public IQueryable<Campaign> Get()
        {
            return db.Campaigns;
        }
        [EnableQuery]
        public SingleResult<Campaign> Get([FromODataUri] int key)
        {
            IQueryable<Campaign> result = db.Campaigns.Where(c => c.Id == key);
            return SingleResult.Create(result);
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Campaign campaign)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Campaigns.Add(campaign);
            await db.SaveChangesAsync();
            return Created(campaign);

        }

    }
}