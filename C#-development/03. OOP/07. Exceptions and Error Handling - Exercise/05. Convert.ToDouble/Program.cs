try
{
    string input = Console.ReadLine();

    Console.WriteLine(Convert.ToDouble(input));
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}