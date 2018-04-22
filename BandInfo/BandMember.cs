using System;
using System.Collections.Generic;
using System.Text;

namespace MyClasses {
    public enum GenderOptions {
        Male,
        Female
    }
    public class BandMember {
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderOptions Gender { get; set; }
        public bool IsAlive { get; set; }
    }
}
