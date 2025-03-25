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
        private List<Product> bag;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            this.bag = new List<Product>();
        }

        public void AddToBag(Product product)
        {
            this.bag.Add(product);
        }

        public List<Product> SeeBag()
        {
            return bag;
        }

        public bool PurchaseProduct(Product product)
        {
            if (money >= product.Cost)
            {
                money -= product.Cost;
                Console.WriteLine($"{name} bought {product.ProductName}");
                return true;
            }
            else
            {
                Console.WriteLine($"{name} can't afford {product.ProductName}");
                return false;
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
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
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
