using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.s
{
    class Program
    {
        static void Main(string[] args)
        {
            // INITIALIZE NUMBER
            var n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                var factoriel = 1;
                var number = n % 10;
                n /= 10;

                for (int i = 2; i <= number; i++)
                {
                    factoriel *= i;
                }

                sum += factoriel;
            }

            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
