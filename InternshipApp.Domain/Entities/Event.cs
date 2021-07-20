
using System;
using System.Collections.Generic;

namespace InternshipApp.Domain.Entities
{
    public class Event
    {
        public Event()
        {
            this.MusicTypes = new HashSet<MusicType>();
        }

        public int EventId { get; set; }

        public string EventName { get; set; }

        public DateTime? EventDate { get; set; }

        public virtual ICollection<MusicType> MusicTypes { get; set; }
    }
}
