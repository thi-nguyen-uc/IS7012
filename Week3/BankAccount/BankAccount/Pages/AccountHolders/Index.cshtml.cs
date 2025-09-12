using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankAccount.Data;
using BankAccount.Models;

namespace BankAccount.Pages.AccountHolders
{
    public class IndexModel : PageModel
    {
        private readonly BankAccount.Data.BankAccountContext _context;

        public IndexModel(BankAccount.Data.BankAccountContext context)
        {
            _context = context;
        }

        public IList<AccountHolder> AccountHolder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            AccountHolder = await _context.AccountHolder.ToListAsync();
        }
    }
}
