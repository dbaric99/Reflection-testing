using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class Audi :ICar
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private string _model;
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        private string _engine;
        public string Engine
        {
            get => _engine;
            set => _engine = value;
        }

        private double _wheels;
        public double Wheels
        {
            get => _wheels;
            set => _wheels = value;
        }

        private string _steeringSystem;
        public string SteeringSystem
        {
            get => _steeringSystem;
            set => _steeringSystem = value;
        }
    }
}
