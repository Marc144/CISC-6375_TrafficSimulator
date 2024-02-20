using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    class MetricGUI : GUI
    {
        public override double GetSpeed(Vehicle v)
        {
            return v.GetCurrentSpeed() * Constants.MpsToKph;
        }

        public override void SetSpeedLimit(Vehicle v, double speed)
        {
            v.SetDesiredSpeed(speed/Constants.MpsToKph);
        }
    }
}
