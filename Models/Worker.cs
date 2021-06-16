using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_app_prototype
{
    class Worker
    {
        public string WorkerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string CellNumber { get; set; }
        
        public string Email { get; set; }

        public int VenueRating { get; set; }
        private readonly List<string> AvailableServices = new List<string>();  // which servicews are you availavle ot serve
        private readonly List<Venue> AssignedVenues = new List<Venue>();// Keeps track of services the worker is assigned to
        public int QueuePosition { get; set; }
        /*
            Once assigned, the specific availability for the service, eg. AM1, is removed
            This eliminates the use of the IsAssigned variable.
        */

        //public bool IsAssigned { get; set; }
        public void AssignVenue(Venue venue)
        {
            AssignedVenues.Add(venue);
        }

        
        public bool IsAssignedFor(string venueId)
        {
            return AssignedVenues.Exists(i => i.VenueId == venueId);
        }
        public void UnassignVenue(string venueId)
        {
            int index = AssignedVenues.FindIndex(i => i.VenueId == venueId);
            AssignedVenues.RemoveAt(index);
        }
        public List<string> GetAvailableServices()
        {
            return AvailableServices;
        }
        public void MakeAvailable(List<string> ServiceIds)
        {

        }
        public void MakeAvailable(string _ServiceId)
        {
            AvailableServices.Add(_ServiceId);
        }

        public bool Available(string serviceId)
        {
            return AvailableServices.Contains(serviceId);
        }
        public bool StillAvailable()
        {
            return AvailableServices.Count > 0;
        }
        public void AssignWorker(List<Worker> _AssignedWorkers, string _serviceId)
        {//Assigns a worker to a venue then removes their serivce from availability so they're not booked twice or more than once.
            //Use this method for ALL assignments to venue
            _AssignedWorkers.Add(this);
            AvailableServices.Remove(_serviceId);
        }

        public Worker(string _Id, string _Name, int _VenueRating)
        {
            this.WorkerId = _Id;
            this.Name = _Name;
            this.VenueRating = _VenueRating;
        }
        public Worker()
        {
            // FOR SQL USE ONLY. DONT USE THIS CONSTRUCTPR
        }
    }
}
