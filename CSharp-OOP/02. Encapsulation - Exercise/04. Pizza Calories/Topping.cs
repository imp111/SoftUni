using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Pizza_Calories
{
    internal class Topping
    {
        private string type;
        private string toppingName;
        private double weight;
        private double modifier;
        private double toppinCalories;

        public Topping(string type, string toppingName, double weight)
        {
            Type = type;
            ToppingName = toppingName;
            Weight = weight;
        }
        public double CountCalories()
        {
            switch (toppingName.ToLower())
            {
                case "meat":
                    modifier = 1.2;
                    break;
                case "veggies":
                    modifier = 0.8;
                    break;
                case "cheese":
                    modifier = 1.1;
                    break;
                case "sauce":
                    modifier = 0.9;
                    break;
                default:
                    break;
            }

            toppinCalories = 2 * (Weight * modifier);
            return toppinCalories;
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value.ToLower() != "topping")
                {
                    throw new Exception($"Invalid type");
                }

                type = value;
            }
        }

        public string ToppingName
        {
            get
            {
                return toppingName;
            }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }

                toppingName = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 50 && value < 1)
                {
                    throw new Exception($"{Type} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }
    }
}
