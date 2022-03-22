using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Matching_Brakets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> index = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    index.Push(i);
                }
                else if (expression[i] == ')')
                {
                    var lastOpeningBraketIndex = index.Pop();
                    var lastClosingBraketIndex = i;
                    Console.WriteLine(expression.Substring(lastOpeningBraketIndex, 
                        (lastClosingBraketIndex - lastOpeningBraketIndex) + 1));
                }
            }
        }
    }
}
