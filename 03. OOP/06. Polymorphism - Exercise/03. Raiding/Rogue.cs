using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Raiding
{
    internal class Rogue : BaseHero
    {
        public Rogue(string name, int power) : base(name, power)
        {
            this.Power = 80;
        }

        public override string CastAbility()
        {
            return $"Rogue - {this.Name} hits for {this.Power} damage";
        }
    }
}
