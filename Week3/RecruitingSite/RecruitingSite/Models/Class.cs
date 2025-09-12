namespace RecruitingSite.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; } // PK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Resume { get; set; }

        // many-many: candidates-jobtitles
        public List<JobTitle> JobTitles { get; set; }
    }
    public class Company
    {
        public int CompanyId { get; set; }  // PK
        public string Name { get; set; }
        public string Location { get; set; }
        public int IndustryId { get; set; } // FK
        public Industry Industry { get; set; }

        // one-many: company-jobtitles
        public List<JobTitle> JobTitles { get; set; }
     }

    public class JobTitle
    {
        public int JobTitleId { get; set; } // PK
        public string Title { get; set; }
        public string Description { get; set; }

        // one-many: company-jobtitles
        public int CompanyId { get; set; } // FK
        public Company Company { get; set; }

        // many-many: jobtitles-candidates
        public List<Candidate> Candidates { get; set; }
    }
    public class Industry
    {
        public int IndustryId { get; set; } // PK
        public string Name { get; set; }

        // one-many: industry-companies
        public List<Company> Companies { get; set; }
    }

}
