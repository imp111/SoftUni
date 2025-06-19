using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Vehicles
{
    internal class Vehicle
    {
        private double fuel;
        private double consumption; // consumption per kilometer

        public double Fuel { get { return fuel; } set { fuel = value; } }
        public double Consumption { get { return consumption; } set { consumption = value; } }
        
        public Vehicle(double fuel, double consumption)
        {
            this.Fuel = fuel;
            this.Consumption = consumption;
        }

        public virtual void Drive(double distance)
        {
            double fuelNeeded = distance * (this.Consumption);

            if (fuelNeeded < this.Fuel)
            {
                Console.WriteLine($"Vehicle traveled {distance} km.");
                this.Fuel -= fuelNeeded;
            }
            else
            {
                Console.WriteLine($"Vehicle needs refueling");
            }
        }

        public virtual void Refuel(double amount)
        {
            this.Fuel += amount;
        }
    }
}
