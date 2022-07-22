using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Track_Tour
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numPetrolPumps = int.Parse(Console.ReadLine());
            Queue<string[]> queue = new Queue<string[]>();
            int counterTrueCircle = 0;
            bool isCircle = false;
            int sumPetrol = 0;
            int sumKmToPomp = 0;
            int index = 0;

            for (int i = 0; i < numPetrolPumps; i++)
            {
                string[] infoForPetrol = Console.ReadLine().Split();
                queue.Enqueue((string.Join(" ", infoForPetrol) + ' ' + i.ToString()).Split());
            }

            while (queue.Count != 0)
            {
                foreach (var item in queue)
                {
                    if (int.Parse(item[0]) >= int.Parse(item[1]) || sumPetrol > sumKmToPomp)
                    {
                        sumPetrol += int.Parse(item[0]);
                        sumKmToPomp += int.Parse(item[1]);
                        if (sumPetrol >= sumKmToPomp)
                        {
                            counterTrueCircle++;
                            if (counterTrueCircle == 1)
                            {
                                index = int.Parse(item[2]);
                            }

                            if (counterTrueCircle == numPetrolPumps)
                            {
                                isCircle = true;
                                Console.WriteLine(index);
                                break;
                            }
                        }
                        else
                        {
                            counterTrueCircle = 0;
                            sumPetrol = 0;
                            sumKmToPomp = 0;
                            for (int i = 0; i < 1; i++)
                            {
                                queue.Enqueue(queue.Peek());
                                queue.Dequeue();
                            }
                            break;
                        }
                    }
                    else
                    {
                        counterTrueCircle = 0;
                        sumPetrol = 0;
                        sumKmToPomp = 0;
                        for (int i = 0; i < 1; i++)
                        {
                            queue.Enqueue(queue.Peek());
                            queue.Dequeue();
                        }
                        break;
                    }
                }

                if (isCircle == true)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}