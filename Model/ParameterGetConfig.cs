using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem.Model
{
    public class ParameterGetConfig
    {

        public string Oid { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public string MinValue { get; set; }
        public string Redcolor { get; set; }
        public string MaxValue { get; set; }
        public string Ambercolor { get; set; }
        public string Greencolor { get; set; }
        public string TimeStamp { get; set; }
        
        public ParameterGetConfig(string oid = null, string parametername = null, string parmsval = null, string minval = null,
            string maxval = null, string red = null, string amber = null, string green = null, string timestamp = null)
        {
            this.Oid = oid;
            this.ParameterName = parametername;
            this.ParameterValue = parmsval;
            this.MinValue = minval;
            this.MaxValue = maxval;
            this.Redcolor = red;
            this.Ambercolor = amber;
            this.Greencolor = green;
            this.TimeStamp = timestamp;
        }
        #region property       
       

        #endregion
    }
}
