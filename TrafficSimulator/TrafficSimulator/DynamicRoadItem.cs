using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    abstract class DynamicRoadItem : RoadItem
    {
        public abstract void Update(int seconds);
    }
}