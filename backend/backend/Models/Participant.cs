using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Participant
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }

        [ForeignKey("Giveaway")]
        public int GiveawayId { get; set; }
    }
}