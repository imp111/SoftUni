using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Military_Elite.Interfaces
{
    internal interface ISoldier
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
    }
}
