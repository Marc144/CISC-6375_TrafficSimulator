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

        public override Road CreateRoad(string name, double locx, double locy, double len, Heading hdg)
        {
            return new Road(name, locx / Constants.MetersToKm, locy / Constants.MetersToKm, len / Constants.MetersToKm, hdg);
        }
    }
}
