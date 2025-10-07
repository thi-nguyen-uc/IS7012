using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EventManagement.Data;
using EventManagement.Models;

namespace EventManagement.Pages.Events
{
    public class CreateModel : PageModel
    {
        private readonly EventManagement.Data.EventManagementContext _context;

        public CreateModel(EventManagement.Data.EventManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OrganizerId"] = new SelectList(_context.Organizers, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public EventManagement.Models.Event Event { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Events.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
