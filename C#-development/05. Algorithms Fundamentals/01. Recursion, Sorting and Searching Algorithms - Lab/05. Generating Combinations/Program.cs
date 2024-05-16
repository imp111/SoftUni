using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.Generating_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Program.countingValleys(steps, path);

            Console.WriteLine(result);

        }

        public static int countingValleys(int steps, string path)
        {
            return 0;
        }

    }
}