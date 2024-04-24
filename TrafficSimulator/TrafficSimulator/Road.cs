using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    public enum Heading {
        North, South, East, West
    }

    class Road{
        private static string name;
        private static double length;
        private double xlocation;
        private double ylocation;
        private Heading heading;
        public static int NumOfRoads= 0;
        private List<RoadItem> roadItems = new List<RoadItem>();



        //private static RoadItem head;


        public Road(string streetName, double locX, double locY, double len, Heading hdg) {
            name = streetName;
            length = len;
            heading = hdg;
            xlocation = locX;
            ylocation = locY;
            NumOfRoads++;
        }


        public double GetLength(){
            return length;
        }

        public string GetRoadName(){
            return name;
        }

        public double GetXLocation()
        {
            return xlocation;
        }

        public double GetYLocation()
        {
            return ylocation;
        }

        public Heading GetHeading() {
            return heading;
        }

        public void Print(IPrintDriver print, Object o) {
            print.PrintRoad(this, o);
        }
        public void AddRoadItem(RoadItem roadItem){
            roadItems.Add(roadItem);
        }

        public List<RoadItem> GetRoadItems() {
            return roadItems;
        }
    }
}