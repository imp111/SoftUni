using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meh
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfClients = int.Parse(Console.ReadLine());
            string[] name = new string[numberOfClients];
            string[] registrationDate = new string[numberOfClients];
            int[] numberOfPurchases = new int[numberOfClients];
            double priceOfPurchases;
            int[] rating = new int[numberOfClients];

            for (int i = 0; i < numberOfClients; i++)
            {
                name[i] = Console.ReadLine();
                registrationDate[i] = Console.ReadLine();
                numberOfPurchases[i] = int.Parse(Console.ReadLine());
                priceOfPurchases = double.Parse(Console.ReadLine());

                if (numberOfPurchases[i] >= 1 && numberOfPurchases[i] < 100)
                {
                    rating[i] = 1;
                }
                else if (numberOfPurchases[i] >= 100 && numberOfPurchases[i] < 300)
                {
                    rating[i] = 1;
                }
                else if (numberOfPurchases[i] >= 300 && numberOfPurchases[i] < 500)
                {
                    rating[i] = 3;
                }
                else if (numberOfPurchases[i] >= 500 && numberOfPurchases[i] < 1000)
                {
                    rating[i] = 4;
                }
                else if (numberOfPurchases[i] >= 1000 && numberOfPurchases[i] < 10000)
                {
                    rating[i] = 5;
                }


            }

            Array.Sort(name);
            
        }
    }
}
