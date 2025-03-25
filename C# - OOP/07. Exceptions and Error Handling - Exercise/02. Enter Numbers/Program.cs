try
{
    int start = int.Parse(Console.ReadLine());
    int end = int.Parse(Console.ReadLine());

    if (start < 0 || end < 0)
    {
        throw new Exception("Start or end cannot be negative numbers");
    }

    ReadNumber(start, end);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


static void ReadNumber(int start, int end)
{
	for (int i = start; i < end; i++)
	{
        Console.WriteLine(i);
    }
}