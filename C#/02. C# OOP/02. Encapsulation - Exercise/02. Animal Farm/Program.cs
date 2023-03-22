﻿using _02._Animal_Farm;

try
{
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    Chicken chicken = new Chicken(name, age);
    Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
