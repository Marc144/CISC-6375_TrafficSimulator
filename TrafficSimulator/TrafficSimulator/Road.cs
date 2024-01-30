using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    class Road{
        private static string name;
        private static double length;
        private static RoadItem head;

        public double GetLength(){
            return length;
        }

        public string GetRoadName(){
            return name;
        }

        public void AddRoadItem(RoadItem roadItem){
            //TODO
        }
    }
}