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
    public class JoinModel : PageModel
    {
        private readonly ASP_inlamning1.Data.ApplicationDbContext _context;

        public JoinModel(ASP_inlamning1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public Attendee Attendee { get; set; }

        public bool Joined { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            Event = await _context.Events.Include(o => o.Attendee).FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null)
            {
                return NotFound();
            }
            Joined = false;
            return Page();
        }

        public async Task<IActionResult> OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.Include(o => o.Attendee).FirstOrDefaultAsync(m => m.ID == id);

            var attendeModel = await _context.Attendees.FirstOrDefaultAsync(m => m.name == "Jakob");

            Event.Attendee.Add(attendeModel);

            _context.SaveChanges();

            Joined = true;
            return Page();
           // return RedirectToPage("/JoinedEvents");
        }
    }
}
