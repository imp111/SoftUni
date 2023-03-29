using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Raiding
{
    internal class Rouge : BaseHero
    {
        public Rouge(string name, int power) : base(name, power)
        {
            this.Power = 80;
        }

        public override string CastAbility()
        {
            return $"Rouge - {this.Name} hits for {this.Power} damage";
        }
    }
}
