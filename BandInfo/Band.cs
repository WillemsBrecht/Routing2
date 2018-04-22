using System;
using System.Collections.Generic;

namespace MyClasses {
    public class Band {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<BandMember> Members { get; set; } = new List<BandMember>();
    }
}
