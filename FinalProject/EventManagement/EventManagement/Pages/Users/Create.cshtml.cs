using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EventManagement.Data;
using EventManagement.Models;

namespace EventManagement.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly EventManagementContext _context;

        public CreateModel(EventManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
