using _04._Wild_Farm.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal class Mouse : Mammal
    {
        public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eat(string foodType)
        {
            if (foodType.ToLower() == "fruit" ||  foodType.ToLower() == "vegetable")
            {
                this.Weight += this.FoodEaten * 0.10;
            }
            else
            {
                this.FoodEaten = 0;
                Console.WriteLine($"Mouse does not eat {foodType}!");
            }
        }

        public override string ToString()
        {
            return $"Mouse [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
