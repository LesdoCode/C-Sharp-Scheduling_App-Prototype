using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_app_prototype
{
    public class Service
    {
        public string ServiceId { get; private set; }
        public string ServiceName { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        private List<Venue> Venues = new List<Venue>();

        public List<Venue> GetPopulatedVenues()
        {
            return Venues.Where(i => i.HasWorkers()).ToList();
        }
        public void EquateVenues(List<Venue> venues)
        {
            Venues = venues;
        }
        public void SetService()
        {
            foreach (Venue venue in Venues)
            {
                venue.AssignWorkers(ServiceId);
            }
        }
        public void AddVenue(Venue _venue)
        {
            Venues.Add(_venue);
        }
        public void RemoveVenue(string _VenueId)
        {
            Venues.Remove(Venues.Where(i => i.VenueId == _VenueId).FirstOrDefault());
        }

        public void Update(string _ServiceId, string _StartTime)
        {
            ServiceId = _ServiceId;
            StartTime = _StartTime;
        }
        
        public List<Venue> ListVenues()
        {
            return Venues;
        }


        public Service(string _ServiceId, string _ServiceName, string _StartTime, string _Duration)
        {
            ServiceId = _ServiceId;
            StartTime = _StartTime;
            Duration = _Duration;
            ServiceName = _ServiceName;
        }
        public Service() { } // don't touch, dont use. for sql dapper data retreival purposes only
        

    }
}
