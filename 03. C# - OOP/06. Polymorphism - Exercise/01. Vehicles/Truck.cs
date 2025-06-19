using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _01._Vehicles
{
    internal class Truck : Vehicle
    {
        public const double airConditioner = 1.6;
        public Truck(double fuel, double consumption) : base(fuel, consumption)
        {
        }

        public override void Drive(double distance)
        {
            double fuelNeeded = distance * (this.Consumption + airConditioner);

            if (fuelNeeded < this.Fuel)
            {
                Console.WriteLine($"Truck traveled {distance} km.");
                this.Fuel -= fuelNeeded;
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override void Refuel(double amount)
        {
            double holeInTheCap = (5 * amount) / 100;
            this.Fuel += amount - holeInTheCap;
        }
    }
}
