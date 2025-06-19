using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Raiding
{
    internal abstract class BaseHero
    {
        private string name;
        private int power;

        protected BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        public virtual string CastAbility()
        {
            return "";
        }
    }
}
