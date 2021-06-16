using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_app_prototype
{
    public static class ServiceRepository
    {
        private readonly static List<Service> services = new List<Service>();

        internal static void AddService(Service _Service)
        {
            services.Add(_Service);
        }
        
        public static void DeleteService(string _ServiceId)
        {
            services.Remove(services.Where(i => i.ServiceId == _ServiceId).FirstOrDefault());
        }
        internal static void UpdateService(string _ServiceId, Service _Service)
        {
            int Index = services.FindIndex(i => i.ServiceId == _ServiceId);
            services[Index] = _Service;
        }
        internal static Service GetService(string _ServiceId)
        {
            return services.Where(i => i.ServiceId == _ServiceId).FirstOrDefault();
        }
        internal static Service[] GetAllServices()
        {
            return services.ToArray();
        }
        internal static string[] GetAllById()
        {
            var ServiceIds = services.Select(i => i.ServiceId).ToArray();
            return ServiceIds;
        }
        public static void AddVenue(string _ServiceId, string _VenueId, string _VenueName, string _VenueAddress, int _Rating, int _MaxWorkers)
        {
            var serviceIndex = services.FindIndex(i => i.ServiceId == _ServiceId);
            if (serviceIndex > -1)
                services[serviceIndex].AddVenue(new Venue(_VenueId, _VenueName, _VenueAddress, _MaxWorkers, _Rating));
        }
        internal static void AddMultiple(List<Service> _Services)
        {
            services.AddRange(_Services);
        }

        public static bool Exists(string _ServiceId)
        {
            return services.Exists(i => i.ServiceId ==_ServiceId);
        }

        internal static void Clear()
        {
            services.Clear();
        }
    }
}
