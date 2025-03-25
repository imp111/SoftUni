using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Raiding
{
    internal class Warrior : BaseHero
    {
        public Warrior(string namе, int power) : base(namе, power) // power = 100
        {
            this.Power = 100;
        }

        public override string CastAbility()
        {
            return $"Warrior - {this.Name} hits for {this.Power} damage";
        }

    }
}
