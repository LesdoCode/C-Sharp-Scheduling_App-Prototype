using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace schedule_app_prototype
{
    public class Venue
    {
        public Venue(string _VenueId, string _VenueName, string _VenueAddress, int _MaxWorkers, int _Rating)
        {
            VenueId = _VenueId;
            VenueName = _VenueName;
            VenueAddress = _VenueAddress;
            MaxWorkers = _MaxWorkers;
            VenueRating = _Rating;
        }
        public Venue()
        {
            //DO NOT USE. FOR DAPPER SQL PURPOSES ON
        }
        public string VenueId { get; set; }
        public int MaxWorkers { get; set; }
        public int VenueRating { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        /////private Queue<Worker> Workers = new Queue<Worker>();
        private List<Worker> AssignedWorkers = new List<Worker>();

        public bool IsFull()
        {
            return AssignedWorkers.Count >= MaxWorkers;
        }

        public void AssignWorkers(string ServiceId)
        {
            //To be called by the Service class
            // !IsFull() is not called because the AssignedWorkers list is cleared at the start. So the method starts with an empty list either way. It always starts empty
            Clear(); //Make sure no one's assigned to this venue
            List<Worker> AvailableWorkers = WorkerRepository.GetAllWorkers().Where(i => i.Available(ServiceId)).ToList(); //List of all available workers for a particular service.
            
            PopulateService(AvailableWorkers, VenueRating, ServiceId, AssignedWorkers); // Assigns workers with a rating that matches the service.
            if(!IsFull()) // if not enough workers with exact rating for the job, assign people with a higher rating who are still available
            {
                PopulateService(AvailableWorkers, ServiceId, AssignedWorkers);
            }
        }
        internal void AssignWorker(Worker worker)
        {
            if (!IsFull())
                AssignedWorkers.Add(worker);
            else
                throw new ArgumentException("This venue has reached it's maximum worker capacity.");
        }

        internal void EquateAssignedWorkers(List<Worker> workers)
        {
            AssignedWorkers = workers;
        }
        public void Clear()
        {
            AssignedWorkers.Clear();
        }

        public bool HasWorker(string _WorkerId)
        {
            return AssignedWorkers.Exists(i => i.WorkerId == _WorkerId);
        }
        internal bool HasWorker(Worker _Worker)
        {
            return AssignedWorkers.Exists(i => i == _Worker);
        }
        public bool HasWorkers()
        {
            return AssignedWorkers.Count > 0;
        }
        public int GetSpacesLeft()
        {
            return MaxWorkers - AssignedWorkers.Count;
        }
        private void PopulateService(List<Worker> AvailableWorkers, int _VenueRating, string _ServiceId, List<Worker> _AssignedWorkers)
        {   /// this is to find workers with the exact venue rating of the venue itself.
            foreach (Worker worker in AvailableWorkers.Where(i => i.VenueRating == _VenueRating).OrderByDescending(i => i.QueuePosition))                   //.where(i => i.isAssigned = false && i.available(AM1) && i.VenueRating = this.VenueRating && ).Orderby(i => i.QueuePosition))
            {
                if (!IsFull())
                {
                    /// ALREADY ORDERED                        
                    worker.AssignWorker(_AssignedWorkers, _ServiceId); /// assign then return worker to the back of the queue
                    
                    if (!worker.StillAvailable()) // if worker is still available for other services, dont requeue them
                        WorkerRepository.RequeueWorkers(worker); //Assign worker to the back of queue and change queue order to last on queue
                }
                else
                    return;

                WorkerRepository.RequeueEveryone();
            }            
        }

        private void PopulateService(List<Worker> AvailableWorkers, string _ServiceId, List<Worker> _AssignedWorkers)
        {   /// this is to find workers with a higher venue rating than the venue itself.
            foreach (Worker worker in AvailableWorkers.Where(i => i.VenueRating >= this.VenueRating).OrderByDescending(i => i.QueuePosition))                   //.where(i => i.isAssigned = false && i.available(AM1) && i.VenueRating = this.VenueRating && ).Orderby(i => i.QueuePosition))
            {
                if (!IsFull())
                {
                    /// ALREADY ORDERED                        
                    worker.AssignWorker(_AssignedWorkers, _ServiceId); /// assign then return worker to the back of the queue

                    if (!worker.StillAvailable()) // if worker is still available for other services, dont requeue them
                        WorkerRepository.RequeueWorkers(worker); //Assign worker to the back of queue and change queue order to last on queue
                }
                else
                    return;

                WorkerRepository.RequeueEveryone();
            }
        }
        
        internal List<Worker> GetAllAssignedWorkers()
        {
            return AssignedWorkers;
        }


    }
}
