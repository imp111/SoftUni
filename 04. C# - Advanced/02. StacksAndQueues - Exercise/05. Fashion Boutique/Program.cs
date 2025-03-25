using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fashion_Boutique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityRack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < clothesInBox.Length; i++)
            {
                stack.Push(clothesInBox[i]);
            }

            int sum = 0;
            int numberOfRacks = 0;
            while (stack.Count != 0)
            {
                int checkValue = sum + stack.Peek();
                if (capacityRack >= checkValue)
                {
                    sum += stack.Pop();
                }
                else
                {
                    numberOfRacks++;
                    sum = 0;
                }

                if (stack.Count == 0 && sum != 0)
                {
                    numberOfRacks++;
                }
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}