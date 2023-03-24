﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
