using System.ComponentModel.DataAnnotations;

namespace RecruitCatNguyt5.Models
{
    public class Industry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Industry name is required")]
        [StringLength(100, ErrorMessage = "Industry name cannot exceed 100 characters")]
        [Display(Name = "Industry Name")]
        public string Name { get; set; } = string.Empty;

        // Relationships
        [Display(Name = "Candidates in Industry")]
        public List<Candidate>? Candidates { get; set; }

        [Display(Name = "Companies in Industry")]
        public List<Company>? Companies { get; set; }
    }
}
