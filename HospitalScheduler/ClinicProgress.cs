using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalScheduler
{
    class ClinicProgress
    {
        public Clinic clinic { get; set; }
        public int minAdult {get;set;}
        public int minPed { get; set; }
        public int AssignedAdult { get; set; }
        public int AssignedPed { get; set; }


    }
}
