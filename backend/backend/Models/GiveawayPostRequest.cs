using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class GiveawayPostRequest
    {
        public string Content { get; set; }
        public string Title { get; set; }

        public List<Participant> participants { get; set; }
    }
}
