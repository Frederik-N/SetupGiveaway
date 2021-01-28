using backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public interface IDataRepository
    {
        public Task<ActionResult<Participant>> JoinGiveaway(int giveawayId, Participant participant);

        public Task<ActionResult<Giveaway>> PostGiveaway(GiveawayPostRequest giveawayPostRequest);

        public Task<ActionResult<Giveaway>> GetGiveaway(int giveawayId);

        public Task<ActionResult<IEnumerable<Giveaway>>> GetGiveaways();

        public Task<ActionResult<List<Participant>>> GetParticipants(int giveawayId);
    }
}
