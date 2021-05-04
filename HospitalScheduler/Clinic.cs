using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalScheduler
{
    class Clinic
    {
        public string ClinicID { get; set; }
        public string ClinicName { get; set; }
        public string HoursOfOperation { get; set; }
        public string Phone { get; set; }
        public string Mandatory { get; set; }
        public string Adults { get; set; }
        public string Pediatrics { get; set; }
        public string Specialty { get; set; }
        public string License { get; set; }
    }
}
