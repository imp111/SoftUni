using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_and_Minimum_Element
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int[] input = new int[n];
            // 1 - push
            // 2 - delete (pop)
            // 3 - max()
            // 4 - min()
            // print in the follwing format n1, n2, n3, ..., nn

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int first = input[0];
                int? second = null;

                if (input.Length > 1)
                {
                    second = input[1];
                }

                switch (first)
                {
                    case 1:
                        stack.Push(Convert.ToInt32(second));
                        break;

                    case 2:
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            stack.Pop();
                        }
                        break;

                    case 3:
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;

                    case 4:
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;

                    default:
                        break;
                }
            }

            int stackCount = stack.Count;
            for (int i = 0; i < stackCount; i++)
            {
                Console.Write($"{stack.Pop()}");

                if (i == stackCount - 1)
                {
                    continue;
                }
                else
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}