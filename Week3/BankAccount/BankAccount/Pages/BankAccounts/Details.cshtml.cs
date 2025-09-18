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
    public class DetailsModel : PageModel
    {
        private readonly BankAccount.Data.BankAccountContext _context;

        public DetailsModel(BankAccount.Data.BankAccountContext context)
        {
            _context = context;
        }

        public BankAccount BankAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount.FirstOrDefaultAsync(m => m.BankAccountId == id);
            if (bankaccount == null)
            {
                return NotFound();
            }
            else
            {
                BankAccount = bankaccount;
            }
            return Page();
        }
    }
}
