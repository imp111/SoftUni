using _07._Food_Shortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Food_Shortage
{
    internal class Rebel : IBuyer
    {
        public Rebel(string name, int age, string gang, int food)
        {
            Name = name;
            Age = age;
            Gang = gang;
            Food = food;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gang { get; set; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
