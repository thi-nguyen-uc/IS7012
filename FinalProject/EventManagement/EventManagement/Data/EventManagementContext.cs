using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventManagement.Models;

namespace EventManagement.Data
{
    public class EventManagementContext : DbContext
    {
        public EventManagementContext (DbContextOptions<EventManagementContext> options)
            : base(options)
        {
        }

        public DbSet<EventManagement.Models.Event> Events { get; set; } = default!;
        public DbSet<EventManagement.Models.Organizer> Organizers { get; set; } = default!;
        public DbSet<EventManagement.Models.User> Users { get; set; } = default!;
        public DbSet<EventManagement.Models.Registration> Registration { get; set; } = default!;
    }
}
