using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shopping_spree
{
    internal class Person
    {
        private string name;
        private double money;
        private List<Product> bag = new List<Product>();

        public Person(string name, double money, List<Product> bag)
        {
            Name = name;
            Money = money;
            Bag = bag;
        }

        public void PurchaseProduct(string product, double cost)
        {
            if (money >= cost)
            {
                money -= cost;
                Console.WriteLine($"{name} bought {product}");
            }
            else
            {
                Console.WriteLine($"{name} can't afford {product}");
            }
        }

        public List<Product> Bag
        {
            get
            {
                return bag;
            }
            set
            {
                bag = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Name cannot be empty");
                }

                name = value;
            }
        }

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                money = value;
            }
        }

    }
}
