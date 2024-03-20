using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    class ConsolePrint: IPrintDriver
    {
        public void PrintRoad(Road road, Object o) {
            CharMatrix cm = (CharMatrix)o;
            int x, y;
            int CCx = Conversions.WCpointToCCpoint(road.GetXLocation());
            int CCy = Conversions.WCpointToCCpoint(-road.GetYLocation());
            int distance = 0;
            int CCRoadLength = Conversions.WClengthToCClength(road.GetLength());
            switch (road.GetHeading()) {
                case Heading.North:
                    x = (int)CCx;
                    if (x >= 0 && x < Constants.CharMapSize) {
                        while (distance < CCRoadLength){
                            y = (int)(CCy - distance);
                            if (y >= 0 && y < Constants.CharMapSize)
                            {
                                cm.map[y][x] = '|';
                                cm.map[y][x + 2] = '|';
                                cm.map[y][x + 4] = '|';
                            }
                            distance += 1;
                        }
                    }
                    break;
                case Heading.South:
                    break;
                case Heading.East:
                    y = (int)CCy;
                    if (y >= 0 && y < Constants.CharMapSize)
                    {
                        while (distance < CCRoadLength){
                            x = (int)(CCx + distance);
                            if (x >= 0 && x < Constants.CharMapSize)
                            {
                                cm.map[y][x] = '-';
                                cm.map[y + 2][x] = '-';
                                cm.map[y + 4][x] = '-';
                            }
                            distance += 1;
                        }
                    }
                    break;
                case Heading.West:
                    break;
                default:
                    break;
            }
        }

        public void PrintCar(Road road, Object o) { 
        
        }
    }
}
