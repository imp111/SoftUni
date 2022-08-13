using _01._Inheritance___Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine()!;
            int age = int.Parse(Console.ReadLine()!);
            
            if (age > 15 || age < 0)
            {
                Console.WriteLine("Incorrect age!");
            }
            else
            {
                Child child = new Child(name!, age);
                Console.WriteLine(child);
            }
        }
    }
}