using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult<IEnumerable<Giveaway>>> GetGiveaways()
        {
            return await _dataContext.Giveaways.ToListAsync();
        }

        [HttpGet("{giveawayId}")]
        public async Task<ActionResult<Giveaway>> GetGiveaway(int giveawayId)
        {
            var result = await _dataContext.Giveaways.FindAsync(giveawayId);
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Giveaway>> PostGiveaway(Giveaway giveaway)
        {
            var result = new Giveaway { Content = giveaway.Content, Participants = giveaway.Participants, Title = giveaway.Title };
            await _dataContext.AddAsync(result); ;
            await _dataContext.SaveChangesAsync();
            return result;
        }
    }
}
