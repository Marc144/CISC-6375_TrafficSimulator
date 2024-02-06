using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    class Car : Vehicle
    {
        protected override void Accelerate(int secondsDelta)
        {
            SetCurrentSpeed(GetCurrentSpeed() + Constants.AccRate * secondsDelta * Constants.MpsToMph);
        }

        protected override void Decelerate(int secondsDelta)
        {
            SetCurrentSpeed(GetCurrentSpeed() - Constants.AccRate * secondsDelta * Constants.MpsToMph);
        }
    }
}
