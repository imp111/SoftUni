using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.s
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            string input = "";
            int numberOfTries = 0;

            int lenghtUsername = username.Length;

            for (int i = lenghtUsername - 1; i >= 0; i--)
            {
                password += (username[i]);
            }

            while (password != input)
            {
                numberOfTries += 1;
                input = Console.ReadLine();

                if (password == input)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (numberOfTries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}
