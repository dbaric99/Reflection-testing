using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Tesla :ICar
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public double Wheels { get; set; }
        public bool HasAutopilot { get; set; }
    }
}
