using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Unit_Testing_Basics.Interfaces
{
    public interface IWeapon
    {
        void Attack(ITarget target);
    }
}