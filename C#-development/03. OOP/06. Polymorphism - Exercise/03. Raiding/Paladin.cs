using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Raiding
{
    internal class Paladin : BaseHero
    {
        public Paladin(string name, int power) : base(name, power)
        {
            this.Power = 100;
        }

        public override string CastAbility()
        {
            return $"Paladin - {this.Name} healed for {this.Power}";
        }
    }
}
