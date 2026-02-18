using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem
{
    public class ActivityReportData
    {
        public int _activityId;
        public string _activityType = string.Empty;
        public DateTime _activityDatetime;
        public string _activityInfo = string.Empty;
        public string _username = string.Empty;

        // Constructor
        public ActivityReportData(string activityType = null, DateTime? activityDatetime = null,
                              string activityInfo = null, string username = null, int activityId = 0)
        {
            _activityId = activityId;
            _activityType = activityType ?? string.Empty;
            _activityDatetime = activityDatetime ?? DateTime.Now;
            _activityInfo = activityInfo ?? string.Empty;
            _username = username ?? string.Empty;
        }

        // Properties
        public int Activity_Id
        {
            get { return _activityId; }
        }

        public string Activity_Type
        {
            get { return _activityType; }
        }

        public DateTime Activity_Datetime
        {
            get { return _activityDatetime; }
        }

        public string Activity_Info
        {
            get { return _activityInfo; }
        }

        public string Username
        {
            get { return _username; }
        }
    }
}
