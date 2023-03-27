using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Food_Shortage.Interfaces
{
    internal interface IBuyer
    {
        string Name { get; }
        int Food { get; }
        void BuyFood();
    }
}
