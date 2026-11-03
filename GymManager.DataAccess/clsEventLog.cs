using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GymManager.DataAccess
{
    public class clsEventLog
    {
        public static void LogEvent(string message, EventLogEntryType eventLogEntryType)
        {
            string sourceName = "GymManagerApp";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            EventLog.WriteEntry(sourceName, message, eventLogEntryType);
        }
    }
}
