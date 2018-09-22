using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myAspData.Models
{
    public class Session
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Presenter { get; set; }
        public int Attendees { get; set; }
        public DateTime Timeslot { get; set; }

        public Session()
        {
            Attendees = 0;
            Timeslot = DateTime.UtcNow;
        }
    }
}
