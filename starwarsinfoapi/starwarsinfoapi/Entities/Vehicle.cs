using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace starwarsinfoapi.Entities
{
    public class Vehicle
    {
        public string name { get; set; }
        public string model { get; set; }
        public string manufacturer { get; set; }
        public int cost_in_credits { get; set; }
        public double length { get; set; }
        public int max_atmosphering_speed { get; set; }
        public int crew { get; set; }
        public int passengers { get; set; }
        public int cargo_capacity { get; set; }
        public string consumables { get; set; }
        public string vehicle_class { get; set; }
        public List<string> pilots { get; set; }
        public List<string> films { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }
    }
}
