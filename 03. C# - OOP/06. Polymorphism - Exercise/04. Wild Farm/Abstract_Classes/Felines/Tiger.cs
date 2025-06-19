using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm
{
    internal class Tiger : Feline
    {
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override string ToString()
        {
            return $"Tiger [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Eat(string foodType)
        {
            if (foodType.ToLower() == "meat")
            {
                this.Weight += this.FoodEaten * 1.00;
            }
            else
            {
                this.FoodEaten = 0;
                Console.WriteLine($"Tiger does not eat {foodType}!");
            }
        }
    }
}
