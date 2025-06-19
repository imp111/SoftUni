using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Unit_Testing_Basics.Interfaces
{
    public interface ITarget
    {
        int Health { get; }
        bool IsDead();

        int GiveExperience();

        void TakeAttack(int attackPoints);
    }
}
