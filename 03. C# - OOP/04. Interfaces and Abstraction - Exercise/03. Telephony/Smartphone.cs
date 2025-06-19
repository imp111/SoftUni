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
        public Smartphone()
        {
            
        }

        public string Calling(string number)
        {
            if (!number.All(Char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}";
        }

        public string Dialling(string number)
        {
            if (!number.All(Char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Dialling: {number}!";
        }
    }
}
