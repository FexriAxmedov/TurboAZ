using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Models
{
   public abstract class Vehicle
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public bool StartStop { get; set; }
        public string GoForward { get; set; }
        public string GoBackward { get; set; }
        public bool ShiftupShiftdown { get; set; }

    }
}
