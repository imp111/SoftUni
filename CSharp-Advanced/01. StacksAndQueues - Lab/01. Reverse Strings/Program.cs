using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> test = new Stack<char>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                test.Push(input[i]);
            }

            while (test.Count > 0)
            {
                Console.Write(test.Pop());
            }

            Console.WriteLine();
        }
    }
}
