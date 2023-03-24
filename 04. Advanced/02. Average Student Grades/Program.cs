int n = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> dictionary = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split().ToArray();

    if (input.Length > 2)
    {
        continue;
    }
    else
    {
        if (dictionary.ContainsKey(input[0]))
        {
            dictionary[input[0]].Add(decimal.Parse(input[1]));
        }
        else
        {
            dictionary.Add(input[0], new List<decimal>());
            dictionary[input[0]].Add(decimal.Parse(input[1]));
        }
    }
}

foreach (var item in dictionary)
{
    Console.Write($"{item.Key} -> ");

    for (int i = 0; i < item.Value.Count; i++)
    {
        Console.Write($"{item.Value[i]:F2} ");

    }
    decimal average = item.Value.Average(); ;
    Console.Write($"(avg: {average:F2})");
    Console.WriteLine();
}

