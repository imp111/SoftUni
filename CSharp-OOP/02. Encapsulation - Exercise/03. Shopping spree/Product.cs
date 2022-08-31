using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shopping_spree
{
    internal class Product
    {
        private string product;
        private double cost;

        public Product(string productName, double cost)
        {
            ProductName = productName;
            Cost = cost;
        }

        public string ProductName
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
            }
        }

        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
    }
}
