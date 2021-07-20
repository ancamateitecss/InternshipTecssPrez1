using InternshipApp.Core.ViewModels;
using System.Collections.Generic;

namespace InternshipApp.Core.Common.Interfaces
{
    public interface IEventService
    {
        EventsViewModel GetEvents();
        bool AddEvent(SingleEventViewModel eventViewModel);
        bool UpdatateEntireEvent(SingleEventViewModel eventViewModel);
        bool UpdatateEventsNames(Dictionary<int, string> eventNamesForUpdate);
        bool DeleteEvent(int idToDelete);

    }
}
