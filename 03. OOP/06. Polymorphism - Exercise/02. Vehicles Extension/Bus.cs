using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Vehicles_Extension
{
    internal class Bus : Vehicle
    {
        private double capacity;

        public double Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value > this.Fuel)
                {
                    capacity = value;
                }
                else
                {
                    capacity = 0;
                }
            }
        }

        public Bus(double fuel, double consumption, double capacity) : base(fuel, consumption)
        {
            this.Capacity = capacity;
        }

        public override void Refuel(double amount)
        {
            if (amount + this.Fuel > this.Capacity)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Fuel must be a positive amount");
            }
            else
            {
                this.Fuel += amount;
            }
        }
    }
}
