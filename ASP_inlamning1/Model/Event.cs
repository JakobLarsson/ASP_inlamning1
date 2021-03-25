using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_inlamning1.Model
{
    public class Event
    {
        public int ID { get; set; }

        public string title{ get; set; }

        public int organizer_id { get; set; }

        public string description { get; set; }
        
        public string place { get; set; }

        public string address { get; set; }

        public DateTime date { get; set; }

        public int spots_avalible { get; set; }

        public ICollection<Attendee> Attendee { get; set; }



    }
}
