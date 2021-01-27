using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class GiveawayJoinRequest
    {
        public int GiveawayId { get; set; }

        public Participant Participants { get; set; }
    }
}
