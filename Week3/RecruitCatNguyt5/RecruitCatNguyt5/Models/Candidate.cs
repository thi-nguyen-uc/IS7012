namespace RecruitCatNguyt5.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }

        // Additional Properties
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Relationships
        // 1 company
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
        // 1 job title
        public int JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }
        // 1 industry
        public int IndustryId { get; set; }
        public Industry? Industry { get; set; }
    }
}
