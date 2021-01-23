using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}