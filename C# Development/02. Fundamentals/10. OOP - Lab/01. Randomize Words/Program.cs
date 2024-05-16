using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Randomize_Words
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            int index; string buffer;

            Random random = new Random();

            for (int i = 0; i < array.Length - 1; i++)
            {
                index = random.Next(0, array.Length);
                buffer = array[i];
                array[i] = array[index];
                array[index] = buffer;
            }

            Console.WriteLine(string.Join("\n", array));
        }
    }
}