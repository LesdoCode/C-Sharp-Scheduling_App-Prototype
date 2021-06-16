using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_app_prototype.Models
{
    public class Event
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string StartDate { get; set; }




        private List<string> ServiceIds = new List<string>();

        private void EquateServiceIds(List <string> Ids)
        {
            ServiceIds = Ids;
        }

        public void AddServiceId(string ServiceId)
        {
            ServiceIds.Add(ServiceId);
        }
        public string[] GetAllIds()
        {
            return ServiceIds.ToArray();
        }
        
        public Event(string _EventId, string _EventName, string _StartDate)
        {
            EventId = _EventId;
            EventName = _EventName;
            StartDate = _StartDate;
        }
        public Event() { }

        public List<string> GetAllAssignedServiceIds()
        {
            return ServiceIds;
        }

        internal List <Service> GetAllAssignedServices()
        {
            var services = new List<Service>();
            foreach(var Id in ServiceIds)
            {
                services.Add(ServiceRepository.GetService(Id));
            }
            return services;
        }
        public void EquateServices(List <string> _ServideIds)
        {
            ServiceIds = _ServideIds;
        }

    }
}
