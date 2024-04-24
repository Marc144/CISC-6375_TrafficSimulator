using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    class Light : DynamicRoadItem
    { 
        private int redTime;
        private int yellowTime;
        private int greenTime;
        private string lit;
        private int timeOn;
        public Light(int r_T, int y_T, int g_T, string startColor, double location) {
            redTime = r_T;
            yellowTime = y_T;
            greenTime = g_T;
            lit = startColor;
            mileMarker = location;
            timeOn = 0;
        }
        public override void Update(int seconds){
            timeOn += seconds;
            if (lit == "green") {
                if (timeOn == greenTime) {
                    timeOn = 0;
                    lit = "yellow";
                }
                int lightTimer = greenTime;
                while (timeOn > lightTimer) {
                    if (lit == "green")
                    {
                        timeOn = timeOn - greenTime;
                        lit = "yellow";
                        lightTimer = yellowTime;
                    }
                    if (lit == "yellow")
                    {
                        timeOn = timeOn - yellowTime;
                        lit = "red";
                        lightTimer = redTime;
                    }
                    if (lit == "red")
                    {
                        timeOn = timeOn - redTime;
                        lit = "green";
                        lightTimer = greenTime;
                    }
                }
            }
            if (lit == "yellow") {
                if (timeOn == yellowTime ) {
                    timeOn = 0;
                    lit = "red";
                }
                int lightTimer = yellowTime;
                while (timeOn > lightTimer)
                {
                    if (lit == "green")
                    {
                        timeOn = timeOn - greenTime;
                        lit = "yellow";
                        lightTimer = yellowTime;
                    }
                    if (lit == "yellow")
                    {
                        timeOn = timeOn - yellowTime;
                        lit = "red";
                        lightTimer = redTime;
                    }
                    if (lit == "red")
                    {
                        timeOn = timeOn - redTime;
                        lit = "green";
                        lightTimer = greenTime;
                    }
                }
            }
            if (lit == "red") {
                if (timeOn == redTime) {
                    timeOn = 0;
                    lit = "green";
                }
                int lightTimer = redTime;
                while (timeOn > lightTimer)
                {
                    if (lit == "green")
                    {
                        timeOn = timeOn - greenTime;
                        lit = "yellow";
                        lightTimer = yellowTime;
                    }
                    if (lit == "yellow")
                    {
                        timeOn = timeOn - yellowTime;
                        lit = "red";
                        lightTimer = redTime;
                    }
                    if (lit == "red")
                    {
                        timeOn = timeOn - redTime;
                        lit = "green";
                        lightTimer = greenTime;
                    }
                }
            }
        }

        public string GetLightColor(){
            return lit;
        }

        public double getMileMarker() {
            return mileMarker;
        }

        public override char PrintRoadItem() {
            if (lit == "green") {
                return 'O';
            }
            if(lit == "red"){
                return 'X';
            }
            if (lit == "yellow")
            {
                return '-';
            }
            return  ' ';
        }
    }
}