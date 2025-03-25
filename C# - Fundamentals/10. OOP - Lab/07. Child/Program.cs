using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Child
{
    internal class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public Truck(string brand, string model, double weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }

    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public Car(string brand, string model, double horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    }

    internal class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Car newCar;
            Truck newTruck;
            Catalog storage = new Catalog();

            while (input != "end")
            {
                string[] values = input.Split('/');

                if (values.Length != 4)
                {
                    Console.WriteLine("Wrong number of arguments");
                    continue;
                }

                string type = values[0];
                string brand = values[1];
                string model = values[2];
                double powerWeight = double.Parse(values[3]);

                if (type == "Car")
                {
                    newCar = new Car(brand, model, powerWeight);
                    storage.Cars.Add(newCar);
                }
                else if (type == "Truck")
                {
                    newTruck = new Truck(brand, model, powerWeight);
                    storage.Trucks.Add(newTruck);
                }
                else
                {
                    Console.WriteLine("Wrong type of vehicle");
                }

                input = Console.ReadLine();
            }

            var orderedCar = storage.Cars.OrderBy(x => x.Brand);
            var orderedTruck = storage.Trucks.OrderBy(x => x.Brand);

            Console.WriteLine("Cars:");
            foreach (Car var in orderedCar)
            {
                Console.WriteLine($"{var.Brand}: {var.Model} - {var.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (Truck var in orderedTruck)
            {
                Console.WriteLine($"{var.Brand}: {var.Model} - {var.Weight}kg");
            }
        }
    }
}