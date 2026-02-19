using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public class ExerciseDataModel
    {
        public string _type=string.Empty;
        public string _description = string.Empty;
        public DateTime _exerciseStartTime;
        public DateTime? _exerciseEndTime;
     
        // public SnmpFaultData() { }
        public ExerciseDataModel(string exerciseType, string exercisedescription , DateTime exerciseStartTime, DateTime? exerciseEndTime)
        {
            _type = exerciseType;
            _description = exercisedescription;
            _exerciseStartTime = exerciseStartTime;
            _exerciseEndTime = exerciseEndTime ;
        }

        public string ExerciseType
        {
            get { return _type; }
        }

        public string ExerciseDescription
        {
            get { return _description; }
        }

        public DateTime ExerciseStartTime
        {
            get { return _exerciseStartTime; }
        }

        public DateTime? ExerciseEndTime
        {
            get { return _exerciseEndTime; }
        }

    }
}
