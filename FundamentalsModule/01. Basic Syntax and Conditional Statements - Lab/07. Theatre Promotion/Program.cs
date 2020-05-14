using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekday = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticket = 0;

            if (age >= 0 && age <= 18)
            {
                if (weekday == "Weekday")
                {
                    ticket = 12;
                }
                else if (weekday == "Weekend")
                {
                    ticket = 15;
                }
                else if (weekday == "Holiday")
                {
                    ticket = 5;
                }

                Console.WriteLine($"{ticket}$");
            }
            else if (age > 18 && age <= 64)
            {
                if (weekday == "Weekday")
                {
                    ticket = 18;
                }
                else if (weekday == "Weekend")
                {
                    ticket = 20;
                }
                else if (weekday == "Holiday")
                {
                    ticket = 12;
                }

                Console.WriteLine($"{ticket}$");
            }
            else if (age > 64 && age <= 122)
            {
                if (weekday == "Weekday")
                {
                    ticket = 12;
                }
                else if (weekday == "Weekend")
                {
                    ticket = 15;
                }
                else if (weekday == "Holiday")
                {
                    ticket = 10;
                }

                Console.WriteLine($"{ticket}$");

            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
