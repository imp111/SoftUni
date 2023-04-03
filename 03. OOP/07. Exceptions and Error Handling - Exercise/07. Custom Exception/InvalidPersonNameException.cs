using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Custom_Exception
{
    internal class InvalidPersonNameException : Exception
    {
        public InvalidPersonNameException() { }
        public InvalidPersonNameException(string msg) : base(msg)
        {
            throw new ArgumentException(msg);
        }
    }
}
