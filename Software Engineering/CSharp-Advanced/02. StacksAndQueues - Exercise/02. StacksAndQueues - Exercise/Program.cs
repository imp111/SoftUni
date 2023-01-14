using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StacksAndQueues___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = parameters[0]; // number of elements to push into the stack
            int s = parameters[1]; // number of elements to pop from the stack
            int x = parameters[2]; // number to look for in the stack

            int[] input = new int[n];
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            bool boolOutput = false;
            int numOutput = 0;

            for (int i = 0; i < n; i++) 
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.Contains(x))
                {
                    boolOutput = true;
                }
                else if (stack.Count == 0)
                {
                    numOutput = 0;
                }
                else
                {
                    numOutput = stack.Min();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(stack.Count);
            }
            else if (boolOutput == true)
            {
                Console.WriteLine("true");
            }
            else if (boolOutput == false)
            {
                Console.WriteLine(numOutput);
            }
        }
    }
}
