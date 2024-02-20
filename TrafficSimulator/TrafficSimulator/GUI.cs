using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    abstract class GUI : ISimInput, ISimOutput
    {
        public abstract double GetSpeed(Vehicle v);
        public abstract void SetSpeedLimit(Vehicle v, double speed);
    }
}