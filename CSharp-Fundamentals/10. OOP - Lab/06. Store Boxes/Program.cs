using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Store_Boxes
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    internal class Box
    {
        public int SerialNum { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceBox { get; set; }

        public Box(int serialNumber, int itemQuantity, double priceBox, string name, double price)
        {
            SerialNum = serialNumber;
            ItemQuantity = itemQuantity;
            PriceBox = priceBox;
            Item = new Item(name, price);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine(); // SerialNumber ItemName ItemQuantity ItemPrice
            List<Box> storage = new List<Box>();

            while (input != "end")
            {
                string[] values = input.Split(' ');

                int serialNumber = int.Parse(values[0]);
                string itemName = values[1];
                int itemQuantity = int.Parse(values[2]);
                double itemPrice = double.Parse(values[3]);

                Item newItem = new Item(itemName, itemPrice);
                double pricePerBox = newItem.Price * itemQuantity;
                Box newBox = new Box(serialNumber, itemQuantity, pricePerBox, newItem.Name, newItem.Price);
                storage.Add(newBox);

                input = Console.ReadLine();
            }

            storage.Sort((p, q) => q.PriceBox.CompareTo(p.PriceBox));

            foreach (Box var in storage)
            {
                Console.WriteLine(var.SerialNum);
                Console.WriteLine($"-- {var.Item.Name} - ${var.Item.Price:F2}: {var.ItemQuantity}");
                Console.WriteLine($"-- ${var.PriceBox:F2}");
            }
        }
    }
}
