using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.s
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.0;
            double sum = 0.0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price += 8.45;
                }
                else if (day == "Saturday")
                {
                    price += 9.80;
                }
                else if (day == "Sunday")
                {
                    price += 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price += 10.90;
                }
                else if (day == "Saturday")
                {
                    price += 15.60;
                }
                else if (day == "Sunday")
                {
                    price += 16;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price += 15;
                }
                else if (day == "Saturday")
                {
                    price += 20;
                }
                else if (day == "Sunday")
                {
                    price += 22.50;
                }
            }

            if (num >= 100 && type == "Business")
            {
                num -= 10;
                sum = price * num;
            }

            sum = price * num;

            if (num >= 30 && type == "Students")
            {
                sum = sum - (sum * 0.15);
            }
            else if (num >= 10 && num <= 20 && type == "Regular")
            {
                sum = sum - (0.05 * sum);
            }
            else
            {
                sum = price * num;
            }

            Console.WriteLine($"Total price: {sum:F2}");
        }
    }
}
