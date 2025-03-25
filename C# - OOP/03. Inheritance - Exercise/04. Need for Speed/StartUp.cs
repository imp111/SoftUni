using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Need_for_Speed
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            SportCar ferarri = new SportCar(600, 100);
            RaceMotorcycle yamaha = new RaceMotorcycle(600, 100);
            ferarri.Drive(360);
            yamaha.Drive(360);
        }
    }
}
