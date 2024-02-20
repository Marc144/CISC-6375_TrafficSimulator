using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    class Truck : Vehicle
    {
        private int loadWeight;

        public Truck(int weight){
            loadWeight = weight;
        }

        protected override void Accelerate(int secondsDelta)
        {
            if(loadWeight <= 5){
                SetCurrentSpeed(GetCurrentSpeed() + Constants.AccRateEmpty * secondsDelta);
            }else{
                SetCurrentSpeed(GetCurrentSpeed() + Constants.AccRateFull * secondsDelta);
            }
        }

        protected override void Decelerate(int secondsDelta)
        {
            if(loadWeight <= 5){
                SetCurrentSpeed(GetCurrentSpeed() - Constants.DecRateEmpty * secondsDelta);
            }else{
                SetCurrentSpeed(GetCurrentSpeed() - Constants.DecRateFull * secondsDelta);
            }
        }

    }
}
