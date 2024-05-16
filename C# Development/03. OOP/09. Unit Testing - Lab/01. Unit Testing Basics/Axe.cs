using _01._Unit_Testing_Basics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Unit_Testing_Basics
{
    public class Axe : IWeapon
    {
        private int attackPoints;
        private int durabilityPoints;

        public Axe(int attack, int durability)
        {
            this.attackPoints = attack;
            this.durabilityPoints = durability;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DurabilityPoints
        {
            get { return this.durabilityPoints; }
        }

        public void Attack(ITarget target)
        {
            if (this.durabilityPoints <= 0)
            {
                throw new InvalidOperationException("Axe is broken.");
            }

            target.TakeAttack(this.attackPoints);
            this.durabilityPoints -= 5;
        }
    }
}
