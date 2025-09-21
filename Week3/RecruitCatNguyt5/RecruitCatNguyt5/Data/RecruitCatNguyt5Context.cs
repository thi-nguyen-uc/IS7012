using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatNguyt5.Models;

namespace RecruitCatNguyt5.Data
{
    public class RecruitCatNguyt5Context : DbContext
    {
        public RecruitCatNguyt5Context (DbContextOptions<RecruitCatNguyt5Context> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatNguyt5.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitCatNguyt5.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitCatNguyt5.Models.Industry> Industry { get; set; } = default!;
        public DbSet<RecruitCatNguyt5.Models.JobTitle> JobTitle { get; set; } = default!;
    }
}
