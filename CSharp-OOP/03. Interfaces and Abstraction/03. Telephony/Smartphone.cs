using _03._Telephony.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Telephony
{
    internal class Smartphone : ISmart
    {
        private string number;
        private string url;

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value.Length != 10 || value.All(char.IsLetter))
                {
                    throw new Exception("Invalid number!");
                }

                number = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                if (value.All(char.IsDigit))
                {
                    throw new Exception("Invalid url!");
                }

                url = value;
            }
        }

        public Smartphone(string number)
        {
            Number = number;
        }

        public void Calling(string number)
        {
            Console.WriteLine($"Calling... {Number}");
        }

        public void Browse(string url)
        {
            Console.WriteLine($"Browsing: {Url}!");
        }
    }
}
