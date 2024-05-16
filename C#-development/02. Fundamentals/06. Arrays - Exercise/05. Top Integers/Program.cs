using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
             string result = "";

             for (int i = 0; i < array.Length; i++)
             {
                 int current = array[i];
                 bool top = true;

                 for (int j = i+1; j < array.Length; j++)
                 {
                     if (current <= array[j])
                     {
                         top = false;
                         break;
                     }
                 }
                 if (top)
                 {
                     result += current + " ";
                 }          
             }
             Console.WriteLine(result);
        }
    }
}
