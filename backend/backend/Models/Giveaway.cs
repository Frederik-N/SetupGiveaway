using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Giveaway
    {
        [Key]
        public int GiveawayId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public List<Users> Participants { get; set; }
    }
}
