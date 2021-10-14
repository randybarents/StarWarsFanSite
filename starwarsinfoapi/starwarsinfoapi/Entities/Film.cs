﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace starwarsinfoapi.Entities
{
    public class Film
    {
        public int id { get; set; }
        public List<string> vehicles { get; set; }
        public string url { get; set; }
        public List<string> starships { get; set; }
        public string title { get; set; }
        public List<string> species { get; set; }
        public string producer { get; set; }
        public List<string> planets { get; set; }
        public string director { get; set; }
        public List<string> characters { get; set; }
        public string opening_crawl { get; set; }
    }
}
