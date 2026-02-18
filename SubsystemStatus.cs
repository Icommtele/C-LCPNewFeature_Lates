using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCPReportingSystem
{
    public class SubsystemStatus
    {
        public string Ip { get; set; }
        public bool IsOnline { get; set; }
        public DateTime? FaultStartTime { get; set; }
        public int? ActiveFaultId { get; set; }
    }
}
