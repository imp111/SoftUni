using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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
                weight = value;
            }
        }

        public int FoodEaten
        {
            get
            {
                return foodEaten;
            }
            set
            {
                foodEaten = value;
            }
        }

        public Animal(string name, double weight, int foodEaten)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }
    }
}
