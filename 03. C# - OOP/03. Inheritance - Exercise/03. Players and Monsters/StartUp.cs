using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Players_and_Monsters
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            DarkKnight knight1 = new DarkKnight(username, level);
            Console.WriteLine(knight1);
        }
    }
}
