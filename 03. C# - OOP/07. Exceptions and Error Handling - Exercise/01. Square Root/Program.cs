try
{
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine(Sqrt(n));
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Invalid number");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Invalid number");
}
catch (FormatException)
{
    Console.WriteLine("Invalid number");
}
finally
{
    Console.WriteLine("Goodbye.");
}

static double Sqrt(int value)
{
    if (value < 0)
    {
        throw new ArgumentOutOfRangeException();
    }

    return Math.Sqrt(value);
}