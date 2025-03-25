using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Mu_Online
{
    internal class CharacterStat
    {
        public double Health { get; set; }
        public double Bitcoin { get; set; }

        public CharacterStat(double health, double bitcoin)
        {
            this.Health = health;
            this.Bitcoin = bitcoin;
        }

        public void Heal(double amount)
        {
            if (this.Health < 100)
            {
                double buff = 100 - this.Health;
                this.Health += amount;

                if (this.Health > 100)
                {
                    amount = buff;
                    this.Health = 100;

                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {this.Health} hp.");
                }
                else
                {
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {this.Health} hp.");
                }
            }
            else
            {
                Console.WriteLine($"You healed for 0 hp.");
                Console.WriteLine($"Current health: {this.Health} hp.");
            }
        }

        public void BitCoinsFound(double amount)
        {
            this.Bitcoin += amount;
            Console.WriteLine($"You found {amount} bitcoins.");
        }

        public void Fight(string monsterName, double monsterAttack, double roomNumber)
        {
            this.Health -= monsterAttack;

            if (this.Health > 0)
            {
                Console.WriteLine($"You slayed {monsterName}.");
            }
            else
            {
                Console.WriteLine($"You died! Killed by {monsterName}.");
                Console.WriteLine($"Best room: {(Math.Floor(roomNumber) / 2) + 1}");
                System.Environment.Exit(0);
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputCommands = Console.ReadLine().Split('|', ' ').ToArray();
            CharacterStat char1 = new CharacterStat(100, 0);

            for (int i = 0; i < inputCommands.Length; i++)
            {
                if (inputCommands[i] == "potion")
                {
                    char1.Heal(Convert.ToDouble(inputCommands[i + 1]));
                }
                else if (inputCommands[i] == "chest")
                {
                    char1.BitCoinsFound(Convert.ToDouble(inputCommands[i + 1]));
                }
                else if (inputCommands[i].Any(char.IsDigit) == false)
                {
                    char1.Fight(inputCommands[i], Convert.ToDouble(inputCommands[i + 1]), Convert.ToDouble(i));
                }
                else
                {
                    continue;
                }
            }

            if (char1.Health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {char1.Bitcoin}");
                Console.WriteLine($"Health: {char1.Health}");
            }
        }
    }
}