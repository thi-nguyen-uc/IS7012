using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankAccount.Data;
using BankAccount.Models;

namespace BankAccount.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly BankAccount.Data.BankAccountContext _context;

        public IndexModel(BankAccount.Data.BankAccountContext context)
        {
            _context = context;
        }

        public IList<Models.BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount
                .Include(b => b.AccountHolder).ToListAsync();
        }
    }
}
