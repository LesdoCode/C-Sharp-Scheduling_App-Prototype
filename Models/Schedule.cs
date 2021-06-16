using schedule_app_prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_app_prototype
{
    public static class Schedule
    {
        
        public static string PrintSchedule(Event @event)
        {
            string sSchedule = "";
            foreach(string row in EnumerateSchedule(@event))
            {
                sSchedule += row + '\n';
            }
            return sSchedule;
        }

        public static List<string> EnumerateSchedule(Event @event)
        {
            var schedule = new List<string>();
            foreach(Service service in @event.GetAllAssignedServices())
            {
                foreach(Venue venue in service.ListVenues())
                {
                    //venue.AssignWorkers(service.ServiceId);
                    foreach (Worker worker in venue.GetAllAssignedWorkers())
                    { 

                        if (worker != null && worker.GetAvailableServices().Contains(service.ServiceId))
                        {
                            schedule.Add(service.ServiceId + "\t |\t" + venue.VenueId + "\t |\t" + worker.Name);
                            //worker.RemoveAssignedService(service);
                        }
                            
                    }
                }
                schedule.Add("\n\n");
            }
            return schedule;

        }
    }
}
