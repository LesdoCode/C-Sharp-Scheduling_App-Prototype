using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using schedule_app_prototype.Repositories;

namespace schedule_app_prototype
{
    public static class WorkerRepository
    {
        //private static Queue<Worker> Workers = new Queue<Worker>();
        private static List<Worker> Workers = new List<Worker>();
        
        internal static void AddWorker(Worker _worker)
        {
            _worker.QueuePosition = Workers.Count;
            Workers.Add(_worker);
        }
        internal static void AddMultiple(List<Worker> _workers)
        {
            Workers.AddRange(_workers);
        }
        public static void Clear()
        {
            Workers.Clear();
        }
        internal static Worker[] GetAvailableWorkers()
        {
            return Workers.Where(i => i.GetAvailableServices().Count > 0).ToArray();
        }
        public static void DeleteWorker(string WorkerId)
        {
            Workers.Remove(Workers.Where(i => i.WorkerId == WorkerId).First());
        }
        internal static void DeleteWorker(Worker Worker)
        {
            Workers.Remove(Worker);
        }

        internal static void UpdateWorker(string WorkerId, Worker _worker)
        {
            var index = Workers.FindIndex(i => i.WorkerId == WorkerId);
            Workers[index] = _worker;
        }
        internal static Worker GetWorker(string WorkerId)
        {
            return Workers.Where(i => i.WorkerId == WorkerId).FirstOrDefault();
        }
        public static bool Exsists(string _WorkerId)
        {
            return Workers.Exists(i => i.WorkerId == _WorkerId);
        }
        internal static Worker[] GetAllWorkers()
        {
            return Workers.ToArray();
        }
        internal static void RequeueWorkers(Worker _worker)
        {
            DeleteWorker(_worker);
            AddWorker(_worker);
        }
        public static void RequeueEveryone()
        {

            foreach(Worker worker in Workers)
            {
                worker.QueuePosition = Workers.IndexOf(worker);
            }
        }

        




    }


}
