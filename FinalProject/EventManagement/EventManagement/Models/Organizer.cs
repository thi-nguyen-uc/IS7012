using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models
{
    public class Organizer
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public List<Event> Events { get; set; }
    }
}
