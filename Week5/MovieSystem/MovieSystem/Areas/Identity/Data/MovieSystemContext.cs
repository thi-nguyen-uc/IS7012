using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Models;

namespace MovieSystem.Data;

public class MovieSystemContext : IdentityDbContext<IdentityUser>
{
    public MovieSystemContext(DbContextOptions<MovieSystemContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<MovieSystem.Models.Movie> Movie { get; set; } = default!;

public DbSet<MovieSystem.Models.Director> Director { get; set; } = default!;
}
