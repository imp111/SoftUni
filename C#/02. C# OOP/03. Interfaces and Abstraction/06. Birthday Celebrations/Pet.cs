using _06._Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Birthday_Celebrations
{
    internal class Pet : IDate
    {
        public Pet(string name, string date)
        {
            Name = name;
            Date = date;
        }

        public string Name { get; set; }
        public string Date { get; private set; }
    }
}
