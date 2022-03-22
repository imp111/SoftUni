using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Stack<int> stack = new Stack<int>();
            foreach (var i in intInput)
            {
                stack.Push(i);
            }

            string command = "";
            int sum = 0;
            while (command != "end")
            {
                string[] instructions = Console.ReadLine().Split().ToArray();
                command = instructions[0].ToLower();

                switch (command)
                {
                    case "add":
                        stack.Push(int.Parse(instructions[1]));
                        stack.Push(int.Parse(instructions[2]));
                        break;
                    case "remove":
                        if (stack.Count() < int.Parse(instructions[1]))
                        {
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(instructions[1]); i++)
                            {
                                stack.Pop();
                            }
                            break;
                        }
                    default:
                        break;
                }

                if (command == "end")
                {
                    foreach (var item in stack)
                    {
                        sum += item;
                    }

                    Console.WriteLine($"Sum: {sum}");
                }
            }
        }
    }
}
