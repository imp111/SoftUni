using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Legendary_Farming
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, List<double>> storage = new Dictionary<string, List<double>>();
            string breakCondition = String.Empty;
            double price, quantity;

            while (breakCondition != "buy")
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int i = 0; i < 1; i++)
                {
                    breakCondition = input[0];

                    if (breakCondition.ToLower() == "buy")
                    {
                        break;
                    }

                    price = double.Parse(input[i + 1]);
                    quantity = int.Parse(input[i + 2]);

                    if (storage.ContainsKey(breakCondition))
                    {
                        storage[breakCondition][0] = price;
                        storage[breakCondition][1] += quantity;
                    }
                    else
                    {
                        storage.Add(breakCondition, new List<double>() { price, quantity });
                    }
                }
            }

            foreach (var item in storage)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):F2}");
            }
        }
    }
}