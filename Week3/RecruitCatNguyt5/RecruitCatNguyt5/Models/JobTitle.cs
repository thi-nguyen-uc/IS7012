namespace RecruitCatNguyt5.Models
{
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
}
