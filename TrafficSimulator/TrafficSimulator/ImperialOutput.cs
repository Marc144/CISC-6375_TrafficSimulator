using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TrafficSimulator
{
    class ImperialOutput: ISimOutput
    {
        public double GetSpeed(Vehicle v){
            return v.GetCurrentSpeed();
        }
    }
}