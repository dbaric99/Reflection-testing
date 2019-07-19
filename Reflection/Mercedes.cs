using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Mercedes :ICar
    {
        public string Name { get; set; } = "Mercedes";
        public string Model { get; set; } = "AMG GT";
        public string Engine { get; set; }
        public double Wheels { get; set; }
        public string TransmissionSystem { get; set; }
    }
}
