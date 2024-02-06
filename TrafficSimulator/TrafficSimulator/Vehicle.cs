using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    abstract class Vehicle : DynamicRoadItem
    {
        private double currentSpeed = 0.0;
        private double desiredSpeed;
        private static int currentDirection = 0;
        private static int[] currentLocation;



        protected abstract void Accelerate(int toSpeed);

        protected abstract void Decelerate(int toSpeed);

        public void Turn(int direction, int degrees)
        {
            //TODO
        }

        public double GetCurrentSpeed(){
            return currentSpeed;
        }

        /* public double GetSpeedLimit(){
            //TODO
        } */

        public void SetDesiredSpeed(double mph){
            desiredSpeed = mph;
        }

        protected void SetCurrentSpeed(double speed){
            if(currentSpeed <= speed){
                if(speed > desiredSpeed){
                    currentSpeed =desiredSpeed;
                }else{
                    currentSpeed =  speed;
                }
            }else{
                if(speed < desiredSpeed){
                    currentSpeed = desiredSpeed;
                }else{
                    currentSpeed = speed;
                }
            }
        }

        public void UpdateSpeed(int seconds){
            if(currentSpeed > desiredSpeed){
                Decelerate(seconds);
            }else if(currentSpeed < desiredSpeed){
                Accelerate(seconds);
            }
        }

        public override void Update(int seconds){
            //TODO
        }
    }
}
