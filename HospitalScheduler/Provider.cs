using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalScheduler
{
    public class Provider
    {
        public string ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string Mon { get; set; }
        public string Tue { get; set; }
        public string Wed { get; set; }
        public string Thu { get; set; }
        public string Fri { get; set; }
        public string Sat { get; set; }
        public string Sun { get; set; }
        public string ApprovedLeave { get; set; }
        public string Type { get; set; }
        public string Specialty { get; set; }
        public string ScheduleType { get; set; }
    }
}
