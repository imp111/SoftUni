using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zoo
{
    internal class Mammal : Animal
    {
        public string Name;

        public Mammal(string name) : base(name)
        {
            Name = name;
        }
    }
}