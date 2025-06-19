using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Telephony.Interfaces
{
    internal interface ISmart
    {
        string Calling(string number);
        string Browse(string url);
        string Dialling(string number);
    }
}
