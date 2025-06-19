using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zoo
{
    internal class Gorilla : Mammal
    {
        public string Name;

        public Gorilla(string name) : base(name)
        {
            Name = name;
        }
    }
}