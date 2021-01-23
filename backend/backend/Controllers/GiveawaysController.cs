using backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GiveawaysController : Controller
    {
        private readonly DataContext _dataContext;

        public GiveawaysController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Giveaway>> GetGiveaways()
        {
            return _dataContext.Giveaways;
        }

        [HttpGet("{giveawayId}")]
        public ActionResult<Giveaway> GetGiveaway(int giveawayId)
        {
            var result = _dataContext.Giveaways.Find(giveawayId);
            return result;
        }

        [HttpPost]
        public ActionResult<Giveaway> PostGiveaway(Giveaway giveaway)
        {
            var result = new Giveaway { Content = giveaway.Content, Participants = giveaway.Participants, Title = giveaway.Title };
            _dataContext.Add(result); ;
            _dataContext.SaveChanges();
            return result;
        }
    }
}
