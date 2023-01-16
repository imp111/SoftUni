using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_Mid_Exam
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            int[] attendances = new int[studentsCount];
            double totalBonus = 0; double outputAttendances = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                attendances[i] = int.Parse(Console.ReadLine());

                if (outputAttendances <= attendances[i])
                {
                    outputAttendances = attendances[i];
                }
            }

            if (lecturesCount == 0)
            {
                //throw new DivideByZeroException("cannot divide by 0");
            }
            else
            {
                totalBonus = Convert.ToDouble((outputAttendances / lecturesCount) * (5 + additionalBonus));
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(totalBonus)}.");
            Console.WriteLine($"The student has attended {outputAttendances} lectures.");
        }
    }
}