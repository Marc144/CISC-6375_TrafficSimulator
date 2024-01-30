using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    class Vehicle : DynamicRoadItem
    {
        private static double currentSpeed;
        private static int currentDirection;
        private static int[] currentLocation;



        public void Accelerate(int toSpeed) { 
            //TODO
        }

        public void Decelerate(int toSpeed)
        {
            //TODO
        }

        public void Turn(int direction, int degrees)
        {
            //TODO
        }

        public double GetCurrentSpeed(){
            return currentSpeed;
        }

        public double GetSpeedLimit(){
            //TODO
        }

        public void SetDesiredSpeed(double speed){
            currentSpeed = speed;
        }

        public override Update(int seconds){
            //TODO
        }
    }
}
