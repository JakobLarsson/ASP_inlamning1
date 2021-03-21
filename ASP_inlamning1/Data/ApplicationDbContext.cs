using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP_inlamning1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Model.Attendee> Attendees { get; set; }
        public DbSet<Model.Event> Events { get; set; }
        public DbSet<Model.Organizer> Organizers { get; set; }


    }
}
