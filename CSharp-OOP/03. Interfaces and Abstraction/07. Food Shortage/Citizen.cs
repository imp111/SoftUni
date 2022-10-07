using _07._Food_Shortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Food_Shortage
{
    internal class Citizen : IBuyer
    {
        public Citizen(string name, int age, string id, string date, int food)
        {
            Name = name;
            Age = age; 
            Id = id;
            Date = date;
            Food = food;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Date { get; set; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
