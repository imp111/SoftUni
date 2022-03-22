using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Back_in_40_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hh = int.Parse(Console.ReadLine());
            int mm = int.Parse(Console.ReadLine()) + 30;

            if (mm > 59)
            {
                hh += 1;
                mm -= 60;

                if (hh > 23)
                {
                    if (mm < 10)
                    {
                        Console.WriteLine($"0:0{mm}");
                    }
                    else
                    {
                        Console.WriteLine($"0:{mm}");
                    }
                }
                else
                {
                    if (mm < 10)
                    {
                        Console.WriteLine($"{hh}:0{mm}");
                    }
                    else
                    {
                        Console.WriteLine($"{hh}:{mm}");
                    }
                }
            }
            else if (mm < 10)
            {
                if (hh > 23)
                {
                    Console.WriteLine($"0:0{mm}");
                }
                else
                {
                    Console.WriteLine($"{hh}:0{mm}");
                }
            }
            else
            {
                Console.WriteLine($"{hh}:{mm}");
            }
        }
    }
}
