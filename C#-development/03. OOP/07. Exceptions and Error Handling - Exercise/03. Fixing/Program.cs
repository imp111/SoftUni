try
{
    string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };

    for (int i = 0; i < weekdays.Length; i++)
    {
        Console.WriteLine(weekdays[i].ToString());
    }
    Console.ReadLine();
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
