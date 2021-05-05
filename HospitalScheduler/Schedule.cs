using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalScheduler
{
    public class Schedule
    {
        public DateTime dt_value { get; set; }
        public string Date { get; set; }
        public string Shift { get; set; }
        public string Provider { get; set; }
        public string Location { get; set; }
    }
}
