using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Scheduling_Application
{
    internal class ActivityLog
    {
        public static void TrackUserLogin(int UserID)
        {
            //Creates a log file called "Scheduler Log File" in bin\debug\net7.0-windows\log.txt if it does not exist, which then populates with user info and time of log-in.

            string path = @"log.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Scheduler Log File");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                string logText = $"User {UserID} logged in at {AppDatabase.LogTimeStamp()}" + Environment.NewLine;
                sw.WriteLine(logText);
            }


        }
    }
}
