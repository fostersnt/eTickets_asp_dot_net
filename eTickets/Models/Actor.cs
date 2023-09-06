using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ProfilePictureURL { get; set; }
        [Required]
        public string Bio { get; set;}
    }
}
