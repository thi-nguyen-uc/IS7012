using System.ComponentModel.DataAnnotations;

namespace RecruitCatNguyt5.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Job title is required")]
        [StringLength(100, ErrorMessage = "Job title cannot exceed 100 characters")]
        [Display(Name = "Job Title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Minimum salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Minimum salary must be a positive value")]
        [Display(Name = "Minimum Salary")]
        public decimal MinSalary { get; set; }

        [Required(ErrorMessage = "Maximum salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Maximum salary must be a positive value")]
        [Display(Name = "Maximum Salary")]
        public decimal MaxSalary { get; set; }

        [Display(Name = "Remote Position")]
        public bool IsRemote { get; set; }

        // Relationships
        [Display(Name = "Candidates with this Job Title")]
        public List<Candidate>? Candidates { get; set; }
    }
}
