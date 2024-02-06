using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    class Light : DynamicRoadItem
    { 
        private static int redTime;
        private static int yellowTime;
        private static int greenTime;
        private static string lit;
        private static int timeOn;

        public override void Update(int seconds){
            //TODO
        }

        public string GetLightColor(){
            return lit;
        }
    }
}