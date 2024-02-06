using System;
using System.Collections.Generic;

namespace TrafficSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); car.SetDesiredSpeed(65.0);
            Truck truck1 = new Truck(4); truck1.SetDesiredSpeed(55.0);
            Truck truck2 = new Truck(8); truck2.SetDesiredSpeed(50.0);
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(car); vehicles.Add(truck1); vehicles.Add(truck2);
            for (int i = 0; i < 11; i++)
            {
                foreach (Vehicle v in vehicles)
                {
                    v.UpdateSpeed(1);
                    string s = v.GetType().ToString();
                    Console.WriteLine("{0} speed: {1:F} mph", s, v.GetCurrentSpeed());
                }
            }
        }
    }
}
