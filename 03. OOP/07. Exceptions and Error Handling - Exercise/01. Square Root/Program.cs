
try
{
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine(Sqrt(n));
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Invalid number");
    throw;
}
finally
{
    Console.WriteLine("Goodbye");
}

static double Sqrt(double value)
{
    if (value < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(value), "Sqrt for negative numbers is undefined!");
    }

    return Math.Sqrt(value);
}