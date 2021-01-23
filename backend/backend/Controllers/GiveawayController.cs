using backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GiveawayController : Controller
    {
        [HttpGet]
        public IEnumerable<Giveaways> GetGiveaways()
        {
            using (var db = new DataContext())
            {
                return db.Giveaways.OrderBy(x => x.GiveawayId);
            }
        }

        [HttpPost]
        public ActionResult PostGiveaway(Giveaways giveaway)
        {
            using (var db = new DataContext())
            {
                db.Add(new Giveaways { Content = giveaway.Content, Participants = giveaway.Participants, Title = giveaway.Title }); ;
                db.SaveChanges();
                return new AcceptedResult();
            }
        }
    }
}
