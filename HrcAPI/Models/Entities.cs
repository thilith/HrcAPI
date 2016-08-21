using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HrcAPI.Models
    {
    public class Entities
        {
        public int SpinId { get; set; }
        public int FTW { get; set; }
        public int Watt_Avg { get; set; }
        public int Watt_Max { get; set; }
        public int RPM_Avg { get; set; }
        public int RPM_Max { get; set; }
        public int Speed_Avg { get; set; }
        public int Speed_Max { get; set; }
        public int HR_Avg { get; set; }
        public int HR_Max { get; set; }
        public int White { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }
        public int Yellow { get; set; }
        public int Red { get; set; }
        }
    }