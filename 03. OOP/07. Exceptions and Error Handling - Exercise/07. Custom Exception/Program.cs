﻿using _07._Custom_Exception;

try
{
    string[] input = Console.ReadLine().Split().ToArray();

    if (input.Length != 3)
    {
        throw new ArgumentOutOfRangeException(nameof(input), "There should be 3 parameters");
    }

    string firstName = input[0];
    string lastName = input[1];
    int age = int.Parse(input[2]);

    Person person = new Person(firstName, lastName, age);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
