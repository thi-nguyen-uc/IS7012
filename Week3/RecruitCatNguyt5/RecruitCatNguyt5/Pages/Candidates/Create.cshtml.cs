using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatNguyt5.Data;
using RecruitCatNguyt5.Models;

namespace RecruitCatNguyt5.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatNguyt5.Data.RecruitCatNguyt5Context _context;

        public CreateModel(RecruitCatNguyt5.Data.RecruitCatNguyt5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "Id");
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "Id", "Id");
        ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
