using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule_app_prototype.BusinessLogic
{
    public static class SqlQueries
    {
        public static string GetAllWorkers = @"SELECT * FROM DBO.WORKERS ORDER BY(QUEUEPOSITION)";
        public static string DeleteAllWorkers = @"DELETE FROM DBO.WORKERS WHERE Workerid = @Workerid;";
        public static string AddWorker = @"insert into dbo.Workers values (@WorkerId, @Name, @Surname, @Age, @Address, @CellNumber, @VenueRating, @QueuePosition, @Email);";
        public static string UpdateWorker = @"UPDATE DBO.WORKERS SET name = @name, venuerating = @venuerating, queueposition = @queueposition, surname = @Surname, address = @Address, cellnumber = @CellNumber, email = @Email, age = @Age WHERE workerid = @Workerid";

        public static string AddVenue = @"INSERT INTO DBO.VENUES VALUES (@VENUEID, @VENUENAME, @VENUEADDRESS, @MAXWORKERS, @VENUERATING);";
        public static string LoadVenues = @"SELECT * FROM DBO.VENUES;";
        public static string DeleteVenue = @"DELETE FROM DBO.VENUES WHERE venueid = @VENUEID";
        public static string UpdateVenue = @"UPDATE DBO.VENUES SET venueid = @Venueid, venuename= @Venuename, venueaddress=@Venueaddress, maxworkers = @Maxworkers, venuerating = @Venuerating WHERE venueid = @venueid";


        public static string DeleteService = @"DELETE FROM DBO.SERVICES WHERE serviceid = @Serviceid";
        public static string AddService = @"INSERT INTO DBO.SERVICES VALUES (@ServiceId, @servicename, @StartTime, @Duration)";
        public static string LoadServices = @"SELECT * FROM DBO.SERVICES";
        public static string UpdateServices = @"UPDATE DBO.SERVICES SET serviceid = @ServiceId, servicename = @servicename, starttime = @StartTime, duration = @Duration WHERE serviceid = @serviceid;";

        public static string DeleteEvent = @"DELETE FROM DBO.EVENTS WHERE eventid = @Eventid";
        public static string AddEvent = @"INSERT INTO DBO.EVENTS VALUES (@EventId, @eventname, @Startdate)";
        public static string LoadEvents = @"SELECT * FROM DBO.EVENTS";
        public static string UpdateEvents = @"UPDATE DBO.EVENTS SET eventid = @EventId, eventname = @eventname, startdate = @Startdate, WHERE eventid = @eventid;";

    }
}
