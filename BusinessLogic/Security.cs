using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using schedule_app_prototype.DBAccess;

namespace schedule_app_prototype.BusinessLogic
{
    public static class Security
    {
        public static string Encrypt(string str)
        {
            using (SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = sha256.ComputeHash(utf8.GetBytes(str));
                return Convert.ToBase64String(data);
            }
        }
        internal class WorkerPasswordModel
        {
            public string WorkerId { get; set; }
            public string Password { get; set; }
        }

        public static bool VerifyLogin(string _Username, string _Password)
        {
            var WPM = new WorkerPasswordModel()
            {
                WorkerId = _Username,
                Password = Encrypt(_Password)
            };
            var sql = "SELECT * FROM dbo.Admin WHERE workerid = @workerid";
            var workers = SqlDataAccess.Query(sql, WPM);
            WorkerPasswordModel worker;
            if (workers.Count > 0)
            {
                worker = workers[0];
                return worker.WorkerId == _Username && worker.Password == Encrypt(_Password);
            }
            else
            {
                return false;
            }
               
        }

        public static void AddOrUpdateAdmin(string userId, string userPass, string AdminId, string AdminPass)
        {
            if (VerifyLogin(AdminId, AdminPass))
            {
                var wpm = new WorkerPasswordModel()
                {
                    WorkerId = userId,
                    Password = Encrypt(userPass)
                };

                var sql = @"IF EXISTS( SELECT * FROM DBO.ADMIN WHERE workerid = @workerid)
                            BEGIN
                            UPDATE DBO.ADMIN SET password = @password WHERE workerid = @workerid
                            END
                        ELSE
                           BEGIN
                            INSERT INTO DBO.ADMIN VALUES (@workerid, @password)
                            END";
                SqlDataAccess.SaveData(sql, wpm);
            }
            else
            {
                throw new InvalidOperationException("Sorry, the admin credentials are not valid.");
            }
        }

    }
}
