﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Wild_Farm.Birds
{
    internal class Owl : Bird
    {
        public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override string ToString()
        {
            return $"Owl [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

        public override void Eat(string foodType)
        {
            if (foodType.ToLower() == "meat")
            {
                this.Weight += this.FoodEaten * 0.25;
            }
            else
            {   
                this.FoodEaten = 0;
                Console.WriteLine($"Owl does not eat {foodType}!");
            }
        }
    }
}
