using backend.Data;
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
        private readonly IDataRepository _dataRepository;

        public GiveawaysController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Giveaway>>> GetGiveaways()
        {
            return await _dataRepository.GetGiveaways();
        }

        [HttpGet("{giveawayId}")]
        public async Task<ActionResult<Giveaway>> GetGiveaway(int giveawayId)
        {
            return await _dataRepository.GetGiveaway(giveawayId);
        }

        [HttpPost]
        public async Task<ActionResult<Giveaway>> PostGiveaway(GiveawayPostRequest giveawayPostRequest)
        {
            return await _dataRepository.PostGiveaway(giveawayPostRequest);
        }


        [HttpPost("{giveawayId}")]
        public async Task<ActionResult<Participant>> JoinGiveaway(int giveawayId, Participant participant)
        {
            return await _dataRepository.JoinGiveaway(giveawayId, participant);
        }
    }
}
