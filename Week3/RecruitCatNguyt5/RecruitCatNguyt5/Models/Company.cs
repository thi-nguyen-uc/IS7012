namespace RecruitCatNguyt5.Models
{
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
