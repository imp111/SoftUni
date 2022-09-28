using _03._Telephony.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Telephony
{
    internal class Stationaryphone : IStationary
    {
        private string number;

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value.Length != 7 || value.All(char.IsLetter))
                {
                    throw new Exception("Invalid number!");
                }

                number = value;
            }
        }

        public Stationaryphone(string number)
        {
            Number = number;
        }

        public void Calling(string number)
        {
            Console.WriteLine($"Calling... {Number}");
        }
    }
}
