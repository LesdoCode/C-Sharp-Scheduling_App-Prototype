using schedule_app_prototype.DBAccess;
using schedule_app_prototype.Repositories;
using schedule_app_prototype.Models;
using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using schedule_app_prototype.BusinessLogic;
using schedule_app_prototype.GUI;

namespace schedule_app_prototype
{
    public static class ChurchLogic
    {
        public static void AddWorker(string _WorkerId, string _Name, int _VenueRating, string _Surname, string _Address, string _CellNumber, int _Age, string _Email)
        {
            if (!WorkerRepository.Exsists(_WorkerId))
            {
                var worker = new Worker(_WorkerId, _Name, _VenueRating)
                {
                    Surname = _Surname,
                    Address = _Address,
                    CellNumber = _CellNumber,
                    Age = _Age,
                    Email = _Email
                };
                SqlDataAccess.SaveData(SqlQueries.AddWorker, worker);
                WorkerRepository.AddWorker(worker);
            }
            else
            {
                throw new ArgumentException("Sorry, the ID you entered already exists");
            }
            
        }

        internal static async Task<List<Worker>> LoadWorkers()
        {
            return await Task.Run(() => SqlDataAccess.LoadData<Worker>(SqlQueries.GetAllWorkers));
        }
        public static void DeleteWorker(string _WorkerId)
        {
            if (WorkerRepository.Exsists(_WorkerId))
            {
                SqlDataAccess.DeleteData(SqlQueries.DeleteAllWorkers, WorkerRepository.GetWorker(_WorkerId));
                WorkerRepository.DeleteWorker(_WorkerId);
            }
            else
            {
                throw new ArgumentException("Sorry, the item you're trying to delete does not exist");
            }
            
        }
        public static void UpdateWorker(string _workerId, string _newWorkerId, string _newName, int _newVenueRating, 
                string _newSurname, string _newAddress, string _newCellNumber, string _newEmailAddress, 
                int _newAge)

        {
            
            if (WorkerRepository.Exsists(_workerId))
            {
                var NewWorker = new Worker(_newWorkerId, _newName, _newVenueRating)
                {
                    Surname = _newSurname,
                    Address = _newAddress,
                    CellNumber = _newCellNumber,
                    Email = _newEmailAddress,
                    Age = _newAge
                };
                WorkerRepository.UpdateWorker(_workerId, NewWorker);

                SqlDataAccess.UpdateData(SqlQueries.UpdateWorker, NewWorker);
            }
            else
            {
                throw new ArgumentException("Sorry, the worker you're trying to update does not exist");
            }
            
        }


        public static void AddVenue(string _VenueId, string _VenueName, string _VenueAddress, int _Rating, int _MaxWorkers)
        {
            if (!VenueRepository.Exists(_VenueId))
            {
                var venue = new Venue(_VenueId, _VenueName, _VenueAddress, _MaxWorkers, _Rating);
                VenueRepository.AddVenue(venue);

                SqlDataAccess.SaveData(SqlQueries.AddVenue, venue);
            }
            else
            {
                throw new ArgumentException("A venue with the same Id already exists. Please use another ID or delete the first one.");
            }
            
        }

        internal static List<Venue> LoadVenues()
        {
            return SqlDataAccess.LoadData<Venue>(SqlQueries.LoadVenues);
        }

        public static void UpdateVenue(string _VenueId, string _newVenueId, string _newVenueName, string _newVenueAddress, int _newVenueRating, int _newMaxWorkers)
        {
            if (VenueRepository.Exists(_VenueId))
            {
                var NewVenue = new Venue(_VenueId,_newVenueName, _newVenueAddress, _newMaxWorkers, _newVenueRating);
                VenueRepository.UpdateVenue(_VenueId, NewVenue);

                SqlDataAccess.UpdateData(SqlQueries.UpdateVenue, NewVenue);
            }
            else { throw new ArgumentException("The Venue youre trying to update does not exist"); }           
        }

        internal static void SaveAll()
        {
            SaveEventServices();
            SaveServiceVenues();
            SaveVenueWorkers();
        }

        public static void DeleteVenue(string _VenueId)
        {
            if (VenueRepository.Exists(_VenueId))
            {
                var venue = VenueRepository.GetVenue(_VenueId);
                SqlDataAccess.DeleteData(SqlQueries.DeleteVenue, venue);
                VenueRepository.DeleteVenue(_VenueId);
            }
            else
            {
                throw new ArgumentException("Sorry, the venue you're trying to delete does not exist");
            }
        }

        public static void LoadVenueWorkers()
        {
            string sql = "SELECT * FROM dbo.venueworkers";
            var data = SqlDataAccess.LoadData<VenueWorkerModel>(sql);

            foreach(var model in data)
            {
                var worker = WorkerRepository.GetWorker(model.WorkerId);
                var venueId = model.VenueId;
                var venue = VenueRepository.GetVenue(venueId);
                if (venue != null)
                    venue.AssignWorker(worker);
            }
        }

        public static void LoadEventServices()
        {
            string sql = "SELECT * FROM dbo.eventservices";
            var data = SqlDataAccess.LoadData<EventServiceModel>(sql);

            foreach (var model in data)
            {
                var service = ServiceRepository.GetService(model.ServiceId);
                var @eventId = model.EventId;
                var @event = EventRepository.Get(@eventId);
                if (@event != null)
                    @event.AddServiceId(service.ServiceId); ;
            }
        }
        public static void AddService(string _ServiceId, string _ServiceName, string _StartTime, string _Duration)
        {
            if (!ServiceRepository.Exists(_ServiceId))
            {
                var service = new Service(_ServiceId, _ServiceName, _StartTime, _Duration);
                SqlDataAccess.SaveData(SqlQueries.AddService, service);
                ServiceRepository.AddService(service);
            }
            else
            {
                throw new ArgumentException("A service with the same Id already exists. Please use another ID or delete the first one.");
            }
        }

        public static void DeleteAllWorkers()
        {
            WorkerRepository.Clear();
            SqlDataAccess.DeleteData("DELETE FROM dbo.workers", new Worker());
        }
        public static void DeleteAllVenues()
        {
            VenueRepository.Clear();
            SqlDataAccess.DeleteData("DELETE FROM dbo.venues", new Worker());
        }

        public static void DeleteAllServices()
        {
            ServiceRepository.Clear();
            SqlDataAccess.DeleteData("DELETE FROM dbo.services", new Worker());
        }
        public static List<string> CreateSchedule(Event @event)
        {
            return Schedule.EnumerateSchedule(@event);
        }
     
        internal static void UpdateService(string _ServiceId, string _NewId, string _NewServiceName, string _NewStartTime, string _NewDuration)
        {
            if (ServiceRepository.Exists(_ServiceId))
            {
                var service = new Service(_NewId, _NewServiceName, _NewStartTime, _NewDuration);
                SqlDataAccess.UpdateData(SqlQueries.UpdateServices, service);
                ServiceRepository.UpdateService(_ServiceId, service);
            }
            else
            {
                throw new ArgumentException("Sorry, the service you're trying to update does not exist. Consider using the Add button instead.");
            }
        }

        public static void DeleteService(string _ServiceId)
        {
            if (ServiceRepository.Exists(_ServiceId))
            {
                var service = ServiceRepository.GetService(_ServiceId);
                SqlDataAccess.DeleteData(SqlQueries.DeleteService, service);
                ServiceRepository.DeleteService(_ServiceId);
            }
            else
            {
                throw new ArgumentException("Sorry, the venue you're trying to delete does not exist");
            }
        }

        internal static void AddEvent(string _EventId, string _EventName, string _StartDate, List<Service> services)
        {
            Event @event = new Event(_EventId, _EventName, _StartDate);
            EventRepository.Add(@event);
            EquateEventServices(services, @event);
            SqlDataAccess.SaveData(SqlQueries.AddEvent, @event);
            

        }
        internal static void EquateEventServices(List<Service> services, Event @event)
        {
            var ServiceIds = services.Select(i => i.ServiceId).ToList();
            @event.EquateServices(ServiceIds);
        }
        internal static void EquateEventServices(List <Service> services, string EventId)
        {
            var @event = EventRepository.Get(EventId);
            var ServiceIds = services.Select(i => i.ServiceId).ToList();
            @event.EquateServices(ServiceIds);
        }
        public static void DeleteEvent(string _EventId)
        {
            EventRepository.Delete(_EventId);
        }
        public static void UpdateEvent(string _EventId, string _EventName, string _StartDate)
        {
            EventRepository.Update( _EventId, new Event(_EventId, _EventName, _StartDate));
        }

        private class VenueWorkerModel
        {
            public string WorkerId { get; set; }
            public string VenueId { get; set; }
        }
        public static void SaveVenueWorkers()
        {
            List<VenueWorkerModel> venueWorkers = new List<VenueWorkerModel>();
            foreach(var venue in VenueRepository.GetAllVenues())
            {
               
                foreach (string workerId in venue.GetAllAssignedWorkers().Where(i => i != null).Select(i => i.WorkerId))
                    venueWorkers.Add(new VenueWorkerModel { VenueId = venue.VenueId, WorkerId = workerId });
            }

            string //Sql = @"INSERT INTO dbo.venueworkers VALUES (@venueid, @workerid)";
            Sql = @"IF NOT EXISTS (SELECT * FROM dbo.venueworkers WHERE venueid = @venueId AND workerid = @workerid)
                    BEGIN
                    INSERT INTO dbo.venueworkers VALUES (@venueid, @workerid)
                    END";
            SqlDataAccess.SaveMultiple(Sql, venueWorkers);
        }


        public class EventServiceModel
        {
            public string EventId { get; set; }
            public string ServiceId { get; set; }
            public string PairKey { get; set; }
        }

        public static string CreateEventServiceKey(string EventId, string ServiceId)
        {
            return EventId + ServiceId;            
        }
        public static void SaveEventServices()
        {
            List<EventServiceModel> eventServices = new List<EventServiceModel>();
            foreach (var @event in EventRepository.GetAll())
            {
                foreach (string serviceId in @event.GetAllAssignedServices().Select(i => i.ServiceId))
                    eventServices.Add(new EventServiceModel { EventId = @event.EventId, ServiceId = serviceId, PairKey = CreateEventServiceKey(@event.EventId, serviceId) });
            }

            string //Sql = @"INSERT INTO dbo.eventservices VALUES (@eventid, @serviceid)";
            Sql = @"IF NOT EXISTS (SELECT * FROM dbo.eventservices WHERE pairkey = @pairkey)
                    BEGIN
                    INSERT INTO dbo.eventservices VALUES (@pairkey, @eventid, @serviceid)
                    END";
            SqlDataAccess.SaveMultiple(Sql, eventServices);
        }
        private class ServiceVenueModel
        {
            public string ServiceId { get; set; }
            public string VenueId { get; set; }
        }
        internal static void SaveServiceVenues()
        {
            
            List<ServiceVenueModel> ServiceVenues = new List<ServiceVenueModel>();
            foreach (var service in ServiceRepository.GetAllServices())
            {
                foreach (string VenueId in service.ListVenues().Select(i => i.VenueId))
                    ServiceVenues.Add(new ServiceVenueModel { ServiceId = service.ServiceId, VenueId = VenueId });
            }

            string //Sql = @"INSERT INTO dbo.venueworkers VALUES (@venueid, @workerid)";
            Sql = @"IF NOT EXISTS (SELECT * FROM dbo.servicevenues WHERE (serviceid = @serviceId AND venueid = @venueid) )
                    BEGIN
                    INSERT INTO dbo.servicevenues VALUES (@serviceId, @venueid)
                    END";
            SqlDataAccess.SaveMultiple(Sql, ServiceVenues);
        }

        public static void LoadServiceVenues()
        {
            string sql = "SELECT * FROM dbo.servicevenues";
            var data = SqlDataAccess.LoadData<ServiceVenueModel>(sql);

            foreach (var model in data)
            {
                var venue = VenueRepository.GetVenue(model.VenueId);
                var serviceId = model.ServiceId;
                var service = ServiceRepository.GetService(serviceId);
                if (service != null)
                    service.AddVenue(venue);
            }
        }

        public static void LoadEvents()
        {
            List<Event> events = SqlDataAccess.LoadData<Event>(SqlQueries.LoadEvents);
            EventRepository.AddMultiple(events);
        }
        public static void LoadServices()
        {
            List<Service> services = SqlDataAccess.LoadData<Service>(SqlQueries.LoadServices);
            ServiceRepository.AddMultiple(services);
        }
        public static void LoadDBWorkers()
        {
            List<Worker> workers = SqlDataAccess.LoadData<Worker>(SqlQueries.GetAllWorkers);
            WorkerRepository.AddMultiple(workers);
        }

        public static void LoadDBVenues()
        {
            List<Venue> venues = SqlDataAccess.LoadData<Venue>(SqlQueries.LoadVenues);
            VenueRepository.AddMultiple(venues);
        }
        public static void StartUp()
        {
            
        }
        public static List <Action> PrepStartupActions()
        {
            List<Action> StartupTasks = new List<Action>();
            StartupTasks.Add(() => LoadDBWorkers());
            StartupTasks.Add(() => LoadDBVenues());
            StartupTasks.Add(() => LoadServices());
            StartupTasks.Add(() => LoadEvents());
            StartupTasks.Add(() => LoadVenueWorkers());
            StartupTasks.Add(() => LoadServiceVenues());
            StartupTasks.Add(() => LoadEventServices());

            return StartupTasks;
        }

        
    }
}
