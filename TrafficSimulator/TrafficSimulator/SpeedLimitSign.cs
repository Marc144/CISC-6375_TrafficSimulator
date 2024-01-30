using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    class SpeedLimitSign : StaticRoadItem
    {
        private static double speedLimit;
        
        public double GetSpeedLimit(){
            return speedLimit;
        }
    }
}