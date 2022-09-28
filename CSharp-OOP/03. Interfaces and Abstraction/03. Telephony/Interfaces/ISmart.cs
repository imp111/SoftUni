using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Telephony.Interfaces
{
    internal interface ISmart
    {
        string Number { get; }
        string Url { get; }
        void Calling(string number);
        void Browse(string url);
    }
}
