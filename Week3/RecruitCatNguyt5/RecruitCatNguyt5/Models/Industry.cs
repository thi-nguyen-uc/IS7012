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
}
