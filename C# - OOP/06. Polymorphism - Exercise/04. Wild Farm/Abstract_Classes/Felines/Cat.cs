using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal class Cat : Feline
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return $"Cat [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Eat(string foodType)
        {
            if (foodType.ToLower() == "meat" || foodType.ToLower() == "vegetable")
            {
                this.Weight += this.FoodEaten * 0.30;
            }
            else
            {
                this.FoodEaten = 0;
                Console.WriteLine($"Cat does not eat {foodType}!");
            }
        }
    }
}
