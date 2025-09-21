using System.ComponentModel.DataAnnotations;

namespace RecruitCatNguyt5.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        [StringLength(100, ErrorMessage = "Company name cannot exceed 100 characters")]
        [Display(Name = "Company Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Position name is required")]
        [StringLength(50, ErrorMessage = "Position name cannot exceed 50 characters")]
        [Display(Name = "Position Name")]
        public string PositionName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Minimum salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Minimum salary must be a positive value")]
        [Display(Name = "Minimum Salary")]
        public decimal MinSalary { get; set; }

        [Required(ErrorMessage = "Maximum salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Maximum salary must be a positive value")]
        [Display(Name = "Maximum Salary")]
        public decimal MaxSalary { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, ErrorMessage = "Location cannot exceed 100 characters")]
        [Display(Name = "Company Location")]
        public string Location { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Number of employees must be at least 1")]
        [Display(Name = "Number of Employees")]
        public int NumberOfEmployees { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Annual revenue must be a positive value")]
        [DataType(DataType.Currency)]
        [Display(Name = "Annual Revenue")]
        public decimal AnnualRevenue { get; set; }

        // Relationships
        [Display(Name = "Candidates")]
        public List<Candidate>? Candidates { get; set; }

        [Display(Name = "Industry")]
        public int IndustryId { get; set; }
        public Industry? Industry { get; set; }
    }
}
