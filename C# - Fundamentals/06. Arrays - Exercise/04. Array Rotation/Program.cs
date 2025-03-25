using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int j = 0; j < rotations; j++)
            {
                string a = array[0];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                array[array.Length - 1] = a;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
