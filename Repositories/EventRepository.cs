using schedule_app_prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_app_prototype.GUI
{
    public static class EventRepository
    {
        private readonly static List<Event> Events = new List<Event>();

        public static void Add(Event @event)
        {
            Events.Add(@event);
        }
        public static Event Get(string _EventId)
        {
            return Events.Where(i => i.EventId == _EventId).FirstOrDefault();
        }
        public static Event[] GetAll()
        {
            return Events.ToArray();
        }
        public static void Update(string _EventId, Event _Event)
        {
            var @event = Events.Find(i => i.EventId == _EventId);
            @event = _Event;
        }
        public static void Delete(string _EventId)
        {
            int index = Events.FindIndex(i => i.EventId == _EventId);
            Events.RemoveAt(index);
        }
        public static void AddMultiple(List <Event> events)
        {
            Events.AddRange(events);
        }
        public static bool Exists(string _EventId)
        {
            return Events.Exists(i => i.EventId == _EventId);
        }
    }
}
