using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];
                int currentCount = 1;

                for (int j = i+1; j < array.Length; j++)
                {
                    if (currentElement == array[j])
                    {
                        currentCount += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(array[bestIndex] + " ");
            }

            Console.WriteLine();
        }
    }
}
