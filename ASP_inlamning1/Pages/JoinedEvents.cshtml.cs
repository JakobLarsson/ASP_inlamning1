using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_inlamning1.Data;
using ASP_inlamning1.Model;

namespace ASP_inlamning1.Pages
{
    public class JoinedEventsModel : PageModel
    {
        private readonly ASP_inlamning1.Data.ApplicationDbContext _context;

        public JoinedEventsModel(ASP_inlamning1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public Attendee Attendee { get; set; }

       public List<Event> eventList { get; set; }

        public async Task OnGetAsync()


        {

            var attendeModel = await _context.Attendees.FirstOrDefaultAsync(m => m.name == "Jakob");
            var Event = await _context.Events.Include(o => o.Attendee).ToListAsync();
             eventList = new List<Event>();
            foreach(var item in Event)
            {
                if (item.Attendee.Contains(attendeModel))
                {
                    eventList.Add(item);
                }
            }

        }
    }
}
