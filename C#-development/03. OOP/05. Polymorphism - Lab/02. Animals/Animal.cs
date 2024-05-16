using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Animals
{
    internal class Animal
    {
        public string? Name { get; set; }
        public string? FavoriteFood { get; set; }

        public Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favorite food is {this.FavoriteFood}";
        }
    }
}
