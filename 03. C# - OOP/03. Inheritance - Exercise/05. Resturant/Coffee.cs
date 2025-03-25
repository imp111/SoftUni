using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Resturant
{
    internal class Coffee : HotBeverage
    {
        public double CoffeeMilliliters { get; set; }
        public decimal CoffeePrice { get; set; }
        public double Caffeine { get; set; }

        public Coffee(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
            CoffeeMilliliters = 50;
            CoffeePrice = 3.50M;
        }
    }
}
