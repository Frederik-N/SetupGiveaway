using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ParticipantsController : Controller
    {
        private readonly IDataRepository _dataRepository;

        public ParticipantsController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Participant>>> GetParticipants(int giveawayId)
        {
            return await _dataRepository.GetParticipants(giveawayId);
        }
    }
}
