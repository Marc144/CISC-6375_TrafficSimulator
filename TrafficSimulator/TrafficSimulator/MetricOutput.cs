using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    class MetricOutput: ISimOutput
    {
        public double GetSpeed(Vehicle v){
            return v.GetCurrentSpeed() * 1.6;
        }
    }
}