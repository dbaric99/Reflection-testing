using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public interface ICar
    {
        string Name { get; set; }
        string Model { get; set; }
        string Engine { get; set; }
        double Wheels { get; set; }
    }
}
