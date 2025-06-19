using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zoo
{
    internal class Snake : Lizard
    {
        public string Name;

        public Snake(string name) : base(name)
        {
            Name = name;
        }
    }
}