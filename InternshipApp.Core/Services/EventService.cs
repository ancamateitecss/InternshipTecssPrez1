using InternshipApp.Core.Common.Interfaces;
using InternshipApp.Core.ViewModels;
using InternshipApp.Domain.Interfaces;
using System.Collections.Generic;

namespace InternshipApp.Core.Services
{
    public class EventService : IEventService
    {
        public IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public EventsViewModel GetEvents()
        {
            return new EventsViewModel()
            {
                Events = _eventRepository.GetEvents()
            };
        }

        public bool AddEvent(SingleEventViewModel eventViewModel)
        {

            return _eventRepository.AddEvent(eventViewModel.Event);
        }

        public bool UpdatateEntireEvent(SingleEventViewModel eventViewModel)
        {
            return _eventRepository.UpdatateEntireEvent(eventViewModel.Event);
        }

        public bool UpdatateEventsNames(Dictionary<int, string> eventNamesForUpdate)
        {
            return _eventRepository.UpdatateEventsNames(eventNamesForUpdate);
        }

        public bool DeleteEvent(int idToDelete)
        {
            return _eventRepository.DeleteEvent(idToDelete);
        }
    }
}
