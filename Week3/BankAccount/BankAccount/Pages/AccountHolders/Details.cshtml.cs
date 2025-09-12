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
    public class DetailsModel : PageModel
    {
        private readonly BankAccount.Data.BankAccountContext _context;

        public DetailsModel(BankAccount.Data.BankAccountContext context)
        {
            _context = context;
        }

        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.AccountHolderId == id);
            if (accountholder == null)
            {
                return NotFound();
            }
            else
            {
                AccountHolder = accountholder;
            }
            return Page();
        }
    }
}
