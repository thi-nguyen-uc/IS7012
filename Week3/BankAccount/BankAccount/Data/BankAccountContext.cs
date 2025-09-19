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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed one AccountHolder
            modelBuilder.Entity<AccountHolder>().HasData(
                new AccountHolder
                {
                    AccountHolderId = 10,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@example.com",
                    PhoneNumber = "123-456-7890",
                    DateOfBirth = new DateTime(1990, 1, 1)
                }
            );
        }
    }
}
