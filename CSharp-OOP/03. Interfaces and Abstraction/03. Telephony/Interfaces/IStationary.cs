using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Telephony.Interfaces
{
    internal interface IStationary
    {
        string Number { get; }
        void Calling(string number);
    }
}
