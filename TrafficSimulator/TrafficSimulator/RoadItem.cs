using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    class RoadItem{
        protected double mileMarker;
        protected Road currentRoad;
        protected RoadItem nextItem;
        protected RoadItem prevItem;


        public double GetMileMarker(){
            return mileMarker;
        }

        public Road GetCurrentRoad(){
            return currentRoad;
        }

        public void setCurrentRoad(Road road){
            //TODO
        }

        public RoadItem GetNext(){
            return nextItem;
        }

        public void setNext(RoadItem item){
            nextItem = item;
        }

        public RoadItem GetPrevious(){
            return prevItem;
        }

        public void setPrevious(RoadItem item){
            prevItem = item;
        }
    }
}