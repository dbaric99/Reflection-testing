﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Audi :ICar
    {
        public string Name { get; set; } = "Audi";
        public string Model { get; set; } = "e-tron";
        public string Engine { get; set; }
        public double Wheels { get; set; }
        public string SteeringSystem { get; set; }
    }
}
