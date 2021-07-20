using InternshipApp.Domain.Entities;
using System.Collections.Generic;

namespace InternshipApp.Domain.Interfaces
{
    public  interface IEventRepository
    {
        IEnumerable<Event> GetEvents();

        bool AddEvent(Event newEvent);

        bool UpdatateEntireEvent(Event updatedEvent);

        bool UpdatateEventsNames(Dictionary<int, string> eventNamesForUpdate);

        bool DeleteEvent(int idToDelete);

    }
}
