using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator
{
    interface IPrintDriver
    {
        void PrintRoad(Road road, Object o);
        void PrintCar(Road road, Object o);
    }
}
