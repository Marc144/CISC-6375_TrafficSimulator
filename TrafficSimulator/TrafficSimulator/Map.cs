using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    class Map
    {
        private List<Road> roads;

        public Map() {
            roads = new List<Road>();
        }

        public void AddRoad(Road road) {
            roads.Add(road);
        }

        public void Print(IPrintDriver pd, Object o) {
            foreach (Road road in roads){
                road.Print(pd, o);
            }
        }
    }
}