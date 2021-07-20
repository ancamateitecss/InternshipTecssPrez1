using InternshipApp.Domain.Entities;
using System.Collections.Generic;

namespace InternshipApp.Core.ViewModels
{
    public class EventsViewModel
    {
        public IEnumerable<Event> Events { get; set; }
    }
}
