using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;

namespace EventManagement.Pages.Registrations
{
    public class DetailsModel : PageModel
    {
        private readonly EventManagement.Data.EventManagementContext _context;

        public DetailsModel(EventManagement.Data.EventManagementContext context)
        {
            _context = context;
        }

        public Registration Registration { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registration = await _context.Registration.FirstOrDefaultAsync(m => m.Id == id);
            if (registration == null)
            {
                return NotFound();
            }
            else
            {
                Registration = registration;
            }
            return Page();
        }
    }
}
