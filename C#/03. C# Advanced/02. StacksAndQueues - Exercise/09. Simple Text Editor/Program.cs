using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Simple_Text_Editor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            string[] commands = new string[2];
            Stack<string> stack = new Stack<string>();
            // 1 - append string to the end of the text
            // 2 - count - erases the last count elements from the text
            // 3 - index - returns the element at position index from the text
            // 4 - undoes - undoes the last command of type 1 / 2 and returns the text to the state before that operation

            while (numberOfOperations != 0)
            {
                commands = Console.ReadLine().Split().ToArray();

                if (commands[1] == "")
                {
                    break;
                }

                switch (int.Parse(commands[0]))
                {
                    case 1:
                        stack.Push(commands[1]);
                        break;

                    case 2:
                        for (int i = 0; i < int.Parse(commands[1]); i++)
                        {
                            stack.Pop();
                        }
                        break;

                    case 3:

                        break;

                    case 4:
                        break;

                    default:
                        break;
                }

                numberOfOperations--;
            }
        }
    }
}