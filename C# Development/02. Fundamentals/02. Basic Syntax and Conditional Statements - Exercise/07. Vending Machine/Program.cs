using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.@as
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string output = "";
            double coinsInserted = 0.0;
            double coins = 0.0;


            input = Console.ReadLine();
            while (input != "Start")
            {
                double coin = double.Parse(input);
                coins = coin;

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    coinsInserted += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }



            output = Console.ReadLine();
            while (output != "End")
            {
                switch (output)
                {
                    case "Nuts":

                        if (coinsInserted - 2.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinsInserted -= 2.0;
                            Console.WriteLine("Purchased nuts");
                        }
                        break;

                    case "Water":

                        if (coinsInserted - 0.7 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinsInserted -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        break;

                    case "Crisps":

                        if (coinsInserted - 1.5 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinsInserted -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        break;

                    case "Soda":

                        if (coinsInserted - 0.8 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinsInserted -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        break;

                    case "Coke":

                        if (coinsInserted - 1.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            coinsInserted -= 1.0;
                            Console.WriteLine("Purchased coke");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                output = Console.ReadLine();
            }

            Console.WriteLine($"Change: {coinsInserted:F2}");
        }
    }
}
