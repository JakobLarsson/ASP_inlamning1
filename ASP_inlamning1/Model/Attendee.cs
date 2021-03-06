using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_inlamning1.Model
{
    public class Attendee
    {

        public int ID { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public int phoneNumber { get; set; }
        
        public ICollection<Event> Event{ get; set; } 
    }
}
