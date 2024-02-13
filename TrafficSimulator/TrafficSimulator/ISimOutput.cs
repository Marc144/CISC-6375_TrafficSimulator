using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    interface ISimOutput{
        double GetSpeed(Vehicle v);
    }
}