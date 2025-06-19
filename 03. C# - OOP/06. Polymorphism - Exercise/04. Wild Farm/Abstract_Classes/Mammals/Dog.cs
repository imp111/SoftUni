using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal class Dog : Mammal
    {
        public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"Dog [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Eat(string foodType)
        {
            if (foodType.ToLower() == "meat")
            {
                this.Weight += this.FoodEaten * 0.40;
            }
            else
            {
                this.FoodEaten = 0;
                Console.WriteLine($"Dog does not eat {foodType}!");
            }
        }
    }
}
