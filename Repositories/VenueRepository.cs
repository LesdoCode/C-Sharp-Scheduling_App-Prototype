using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_app_prototype.Repositories
{
    internal static class VenueRepository
    {
        private static List<Venue> Venues = new List<Venue>();

        internal static void AddVenue(Venue Venue)
        {
            Venues.Add(Venue);
        }
        public static void Clear()
        {
            Venues.Clear();
        }
        public static void AddMultiple(List<Venue> _Venues)
        {
            Venues.AddRange(_Venues);
        }
        public static void DeleteVenue(string VenueId)
        {
            Venues.Remove(Venues.Where(i => i.VenueId == VenueId).First());
        }
        internal static void DeleteVenue(Venue Venue)
        {
            Venues.Remove(Venue);
        }
        internal static void UpdateVenue(string VenueId, Venue _Venue)
        {
            var index = GetAllVenues().ToList().FindIndex(i => i.VenueId == VenueId);
            Venues[index] = _Venue;
         }
        internal static Venue GetVenue(string VenueId)
        {
            if (Exists(VenueId) && Venues.Count != 0)
                return Venues.Where(i => i.VenueId == VenueId).FirstOrDefault();
            else
                return null;
        }
        internal static Venue[] GetAllVenues()
        {
            return Venues.ToArray();
        }
        public static List<string> GetAllById()
        {
            return Venues.Select(i => i.VenueId).ToList();
        }
        public static bool Exists(string _VenueId)
        {
            return Venues.Exists(i => i.VenueId == _VenueId);
        }
       
        
    }
}
