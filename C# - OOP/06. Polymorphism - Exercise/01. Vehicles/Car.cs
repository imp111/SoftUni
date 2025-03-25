using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Vehicles
{
    internal class Car : Vehicle
    {
        public const double airConditioner = 0.9;
        public Car(double fuel, double consumption) : base(fuel, consumption)
        {
        }

        public override void Drive(double distance)
        {
            double fuelNeeded = distance * (this.Consumption + airConditioner);

            if (fuelNeeded < this.Fuel)
            {
                Console.WriteLine($"Car traveled {distance} km.");
                this.Fuel -= fuelNeeded;
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }
    }
}
