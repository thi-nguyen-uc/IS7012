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
        private readonly MovieSystem.Data.MovieSystemContext _context;

        public IndexModel(MovieSystem.Data.MovieSystemContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
