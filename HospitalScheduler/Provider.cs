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
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Preferences { get; set; }
        public string ApprovedLeave { get; set; }
        public string Type { get; set; }
        public string Specialty { get; set; }
        public string License { get; set; }
        public string ScheduleType { get; set; }
    }
}
