using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("Organizer")]
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
