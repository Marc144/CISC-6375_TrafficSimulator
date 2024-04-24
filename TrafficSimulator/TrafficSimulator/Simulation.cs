using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    class Simulation
    {
        private static List<RoadItem> roadItems = new List<RoadItem>();


        public Simulation() { 
        
        }
        public void Update(int seconds){
            foreach (DynamicRoadItem item in roadItems) {
                item.Update(seconds);
            }
        }

        public void AddRoadItem(RoadItem item){
            roadItems.Add(item);
        }
    }
}