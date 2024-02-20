using System;
using System.Collections.Generic;

namespace TrafficSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI gui;
            Car car = new Car(); car.SetDesiredSpeed(65.0);
            Truck truck1 = new Truck(4); truck1.SetDesiredSpeed(55.0);
            Truck truck2 = new Truck(8); truck2.SetDesiredSpeed(50.0);
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(car); vehicles.Add(truck1); vehicles.Add(truck2);
            
            
            //The following block of code gets the desired retrun type from the user, be it Imperial Units, or Metric Units, and validates the input
            Console.WriteLine("Type I for Imperial Units or M for Metric Units: ");
            string unitType = Console.ReadLine();
            unitType = unitType.ToUpper();
            while ((unitType != "I") && (unitType != "M")) {
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("Type I for Imperial Units or M for Metric Units: ");
                unitType = Console.ReadLine();
            }//end while
            while ((unitType != "I") && (unitType != "M"))
            {
                Console.WriteLine("Unsupported input!");
                Console.WriteLine("Type I for Imperial Units or M for Metric Units: ");
                unitType = Console.ReadLine();
            }//end while
            
            //The following block of code gets the speed limit from the user, and validates the inputted data
            Console.WriteLine("Enter speed Limit: ");
            string speedLimitString = Console.ReadLine();
            double speedLimit = 0;
            bool inValidNumber = true;
            while (inValidNumber) {
                double convertedSpeedLimit;
                bool isNumeric = double.TryParse(speedLimitString, out convertedSpeedLimit);
                if (isNumeric)
                {
                    inValidNumber = false;
                    speedLimit = convertedSpeedLimit;
                }
                else {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Enter speed Limit: ");
                    speedLimitString = Console.ReadLine();
                }
            }
            if (unitType == "I")
            {
                gui = new ImperialGUI();
                foreach (Vehicle v in vehicles) {
                    gui.SetSpeedLimit(v, speedLimit);
                }
                for (int i = 0; i < 11; i++)
                {
                    foreach (Vehicle v in vehicles)
                    {
                        v.UpdateSpeed(1);
                        string s = v.GetType().ToString();
                        Console.WriteLine("{0} speed: {1:F}", s, gui.GetSpeed(v));
                    }
                }
            }
            else if (unitType == "M")
            {
                gui = new MetricGUI();
                foreach (Vehicle v in vehicles)
                {
                    gui.SetSpeedLimit(v, speedLimit);
                }
                for (int i = 0; i < 11; i++)
                {
                    foreach (Vehicle v in vehicles)
                    {
                        v.UpdateSpeed(1);
                        string s = v.GetType().ToString();
                        Console.WriteLine("{0} speed: {1:F}", s, gui.GetSpeed(v));
                    }
                }
            }//end if-else
            
        }
    }
}
