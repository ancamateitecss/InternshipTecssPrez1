using InternshipApp.Domain.Entities;
using InternshipApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternshipApp.Infrastructure.Persistence.Repositories
{
    public class EventRepository : IEventRepository
    {
        public ApplicationDbContext _context;
        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Event> GetEvents()
        {
            return _context.Events.Include(e => e.MusicTypes);
        }

        public bool AddEvent(Event newEvent)
        {
            var eventToAdd = newEvent;
            var musicTypes = new List<MusicType>();
            musicTypes.AddRange(newEvent.MusicTypes.ToList());

            eventToAdd.MusicTypes = null;
            _context.Events.Add(eventToAdd);

            if (_context.SaveChanges() > 0)
            {
                if (musicTypes.Count == 0)
                {
                    return true;
                }

                //foreach (var musicType in musicTypes)
                //{
                //    musicType.EventId = eventToAdd.EventId;
                //}

                musicTypes = musicTypes.Select(c => { c.EventId = eventToAdd.EventId; return c; }).ToList();

                _context.MusicTypes.AddRange(musicTypes);

                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool UpdatateEntireEvent(Event updatedEvent)
        {
            var eventFound = _context.Events.Find(updatedEvent.EventId);
            eventFound.EventDate = updatedEvent.EventDate;
            eventFound.MusicTypes = updatedEvent.MusicTypes;
            eventFound.EventName = updatedEvent.EventName;
            _context.Events.Update(eventFound);

            return _context.SaveChanges() > 0;
        }

        public bool UpdatateEventsNames(Dictionary<int, string> eventNamesForUpdate)
        {
            foreach (var eventToUpdate in eventNamesForUpdate)
            {
                var eventFound = _context.Events.Find(eventToUpdate.Key);
                eventFound.EventName = eventToUpdate.Value;
                _context.Events.Update(eventFound);
            }
            return _context.SaveChanges() > 0;
        }

        public bool DeleteEvent(int idToDelete)
        {
            var eventFound = _context.Events.FirstOrDefault(e => e.EventId == idToDelete);
            _context.Events.Remove(eventFound);
            return _context.SaveChanges() > 0;
        }
    }
}
