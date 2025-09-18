using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankAccount.Models;

namespace BankAccount.Data
{
    public class BankAccountContext : DbContext
    {
        public BankAccountContext (DbContextOptions<BankAccountContext> options)
            : base(options)
        {
        }

        public DbSet<BankAccount.Models.AccountHolder> AccountHolder { get; set; } = default!;
        public DbSet<BankAccount.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
