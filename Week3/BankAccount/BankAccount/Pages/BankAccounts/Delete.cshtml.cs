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
    public class DeleteModel : PageModel
    {
        private readonly BankAccount.Data.BankAccountContext _context;

        public DeleteModel(BankAccount.Data.BankAccountContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.BankAccount BankAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount.Include(b => b.AccountHolder).FirstOrDefaultAsync(m => m.BankAccountId == id);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount.FindAsync(id);
            if (bankaccount != null)
            {
                BankAccount = bankaccount;
                _context.BankAccount.Remove(BankAccount);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
