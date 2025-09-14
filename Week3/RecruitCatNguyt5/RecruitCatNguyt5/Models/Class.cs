namespace RecruitCatNguyt5.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        // many candidates
        public List<Candidate>? Candidates { get; set; }
        // many companies
        public List<Company>? Companies { get; set; }
    }

    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }

        // Additional Properties
        public bool isRemote { get; set; }

        // Relationships
        // many candidates
        public List<Candidate>? Candidates { get; set; }
    }

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

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }

        // Additional Properties
        public int NumberOfEmployees { get; set; }
        public decimal AnnualRevenue { get; set; }

        // Relationships
        // multiple candidates
        public List<Candidate>? Candidates { get; set; }
        // 1 industry
        public int IndustryId { get; set; }
        public Industry? Industry { get; set; }
    }
}
