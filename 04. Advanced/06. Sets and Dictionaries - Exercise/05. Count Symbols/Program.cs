string input = Console.ReadLine();
SortedDictionary<char, int> occurances = new SortedDictionary<char, int>();

foreach (var item in input)
{
    if (occurances.ContainsKey(item))
    {
        occurances[item]++;
    }
    else
    {
        occurances.Add(item, 1);
    }
}

foreach (var item in occurances)
{
    Console.WriteLine($"{item.Key} : {item.Value} time/s");
}