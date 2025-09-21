using System.ComponentModel.DataAnnotations;

namespace RecruitCatNguyt5.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Range(10000, 500000, ErrorMessage = "Target salary must be between $10,000 and $500,000")]
        [DataType(DataType.Currency)]
        [Display(Name = "Target Salary")]
        public decimal TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Available Start Date")]
        public DateTime? StartDate { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        // Relationships
        [Display(Name = "Company")]
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public int JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }

        [Required]
        [Display(Name = "Industry")]
        public int IndustryId { get; set; }
        public Industry? Industry { get; set; }
    }
}
