using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP_inlamning1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Model.Attendee> Attendees { get; set; }
        public DbSet<Model.Event> Events { get; set; }
        public DbSet<Model.Organizer> Organizers { get; set; }


        
        public void Seed()
        {
            this.Attendees.RemoveRange();
            this.Events.RemoveRange();
            this.Organizers.RemoveRange();

            this.Attendees.AddRange(new List<Model.Attendee>() 
            { 
                new Model.Attendee(){name = "Jakob", email = "jakob.larsson@live.se", phoneNumber = 03663252},
                new Model.Attendee(){name = "Bengt", email = "bengt@live.se", phoneNumber = 078456555},
                new Model.Attendee(){name = "Gustav", email = "Gustavsson@live.se", phoneNumber = 070811223}

            });

            this.Events.AddRange(new List<Model.Event>() 
            {
                new Model.Event(){title = "Summerburst", organizer_id = 1, description = "This is the sickest festival !", place = "Globen", address= "Globengatan", date = new DateTime(20200101), spots_avalible = 10000}
            });

            this.Organizers.AddRange(new List<Model.Organizer>()
            {
                new Model.Organizer(){name = "SwedishClub AB", email = "sc.info@hotmail.com", phoneNumber = 082334566}
            });

            this.SaveChanges();
        }


    }
}
