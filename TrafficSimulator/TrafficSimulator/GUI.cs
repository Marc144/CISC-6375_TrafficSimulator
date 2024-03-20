using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    abstract class GUI : ISimInput, ISimOutput
    {
        public abstract double GetSpeed(Vehicle v);
        public abstract void SetSpeedLimit(Vehicle v, double speed);
        public abstract Road CreateRoad(string name, double locx, double locy, double len, Heading hdg);
    }
}