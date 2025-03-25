using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            bool isNotTrue = false;
            for (int current = 0; current < array.Length; current++)
            {
                int sumRight = 0;
                for (int i = current + 1; i < array.Length; i++)
                {
                    sumRight += array[i];
                }

                int sumLeft = 0;
                for (int i = current - 1; i >= 0; i--)
                {
                    sumLeft += array[i];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(current);
                }
            }

            if (!isNotTrue)
            {
                Console.WriteLine("no");
            }

           
        }
    }
}
