using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Data;
using MovieSystem.Models;

namespace MovieSystem.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieSystemContext _context;

        public IndexModel(MovieSystemContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; } = default!;

        // Bind property to get search query from URL
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var moviesQuery = from m in _context.Movie
                              select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                moviesQuery = moviesQuery.Where(m => m.Title.Contains(SearchString));
            }

            Movie = await moviesQuery.ToListAsync();
        }
    }
}
