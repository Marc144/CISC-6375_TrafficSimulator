using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    interface ISimInput
    {
        void SetSpeedLimit(Vehicle v, double speed);
    }
}
