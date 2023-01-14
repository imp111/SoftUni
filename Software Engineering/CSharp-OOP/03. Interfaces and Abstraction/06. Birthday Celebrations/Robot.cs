using _06._Birthday_Celebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Birthday_Celebrations
{
    internal class Robot : IDate
    {
        public Robot(string model, string id, string date)
        {
            Model = model;
            Id = id;
            Date = date;
        }

        public string Model { get; set; }
        public string Id { get; set; }
        public string Date { get; private set; }
    }
}
