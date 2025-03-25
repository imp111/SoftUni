using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Pizza_Calories
{
    internal class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private string dough;

        public Pizza(string name, string dough)
        {
            Name = name;
            Dough = dough;
        }
        public void PrintCalories(double toppingCalories, double doughCalories)
        {
            Console.WriteLine($"{name} - {toppingCalories + doughCalories:F2}");
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == string.Empty || value.Length > 15 && value.Length > 0)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public List<Topping> Toppings
        {
            get
            {
                return toppings;
            }
            set
            {
                if (toppings.Count > 10 || toppings.Count < 0)
                {
                    throw new Exception("Number of toppings should be in range [0..10].");
                }

                toppings = value;
            }
        }

        public string Dough
        {
            get
            {
                return dough;
            }
            set
            {
                dough = value;
            }
        }
    }
}
