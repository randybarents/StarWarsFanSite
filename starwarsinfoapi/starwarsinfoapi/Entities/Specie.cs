using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace starwarsinfoapi.Entities
{
    public class Specie
    {
        public string name { get; set; }
        public string classification { get; set; }
        public string designation { get; set; }
        public int average_height { get; set; }
        public List<string> skin_colors { get; set; }
        public List<string> hair_colors { get; set; }
        public List<string> eye_colors { get; set; }
        public int average_lifespan { get; set; }
        public string homeworld { get; set; }
        public string language { get; set; }
        public List<string> people { get; set; }
        public List<string> films { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }
    }
}
