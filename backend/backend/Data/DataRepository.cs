using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly DataContext _dataContext;

        public DataRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ActionResult<Giveaway>> GetGiveaway(int giveawayId)
        {
            var result = await _dataContext.Giveaways.FindAsync(giveawayId);
            return result;
        }

        public async Task<ActionResult<IEnumerable<Giveaway>>> GetGiveaways()
        {
            return await _dataContext.Giveaways.ToListAsync();
        }

        public async Task<ActionResult<Participant>> JoinGiveaway(int giveawayId, Participant participant)
        {
            var result = new Participant { Name = participant.Name, GiveawayId = giveawayId };
            await _dataContext.AddAsync(result);
            await _dataContext.SaveChangesAsync();
            return result;
        }

        public async Task<ActionResult<Giveaway>> PostGiveaway(GiveawayPostRequest giveawayPostRequest)
        {
            var result = new Giveaway { Content = giveawayPostRequest.Content, Participants = giveawayPostRequest.participants, Title = giveawayPostRequest.Title };
            await _dataContext.AddAsync(result); ;
            await _dataContext.SaveChangesAsync();
            return result;
        }
    }
}
