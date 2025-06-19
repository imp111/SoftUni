using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zoo
{
    internal class Lizard : Reptile
    {
        public string Name;

        public Lizard(string name) : base(name)
        {
            Name = name;
        }
    }
}