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
            this.Attendees.RemoveRange(this.Attendees);
            this.Events.RemoveRange(this.Events);
            this.Organizers.RemoveRange(this.Organizers);
            var user1 = new Model.Attendee() { name = "Jakob", email = "jakob.larsson@live.se", phoneNumber = 03663252, };
            var user2 = new Model.Attendee() { name = "Bengt", email = "bengt@live.se", phoneNumber = 078456555 };
            this.Attendees.AddRange(new List<Model.Attendee>() 
            {
                user1
               // new Model.Attendee(){name = "Bengt", email = "bengt@live.se", phoneNumber = 078456555},
                //new Model.Attendee(){name = "Gustav", email = "Gustavsson@live.se", phoneNumber = 070811223}

            });

            this.Events.AddRange(new List<Model.Event>() 
            {
                new Model.Event() { title = "Summerburst",  organizer_id = 1, description = "This is the sickest festival !", place = "Globen", 
                    address = "Globengatan", date = new DateTime(20200101), spots_avalible = 10000, Attendee = new List<Model.Attendee>{ user1, user2} },
                
                new Model.Event(){title = "PoolDay", organizer_id = 1, description = "Fun pool day for the whole family, comedians and artist will entertain you the whole day", place = "Flahultsbadet",
                    address= "Grågatan", date = new DateTime(20200102), spots_avalible = 500, Attendee = new List<Model.Attendee>{ user1}},
                new Model.Event(){title = "WhiteParty", organizer_id = 2, description = "Small party with dress code: White clothes only", place = "Puben runt hörnet", address= "Bargatan", date = new DateTime(20200510), spots_avalible = 50}
            });

            this.Organizers.AddRange(new List<Model.Organizer>()
            {
                new Model.Organizer(){name = "SwedishClub AB", email = "sc.info@hotmail.com", phoneNumber = 082334566},
                new Model.Organizer(){name = "FestFixarna", email = "fest@hotmail.com", phoneNumber = 070665544},
                new Model.Organizer(){name = "SickestParty", email = "sickestparty.info@hotmail.com", phoneNumber = 08114477}
            });

            

            this.SaveChanges();
        }


    }
}
