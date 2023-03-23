SortedDictionary<string, Dictionary<string, decimal>> dictionary = new SortedDictionary<string, Dictionary<string, decimal>>();

string[] input = Console.ReadLine().Split(',').ToArray(); // 0 - shop, 1 - product, 2 - price
while (input[0].ToLower() != "revision")
{
    if (input.Length == 3)
    {
        if (dictionary.ContainsKey(input[0]))
        {
            dictionary[input[0]].Add(input[1], decimal.Parse(input[2]));
        }
        else
        {
            dictionary.Add(input[0], new Dictionary<string, decimal>());
            dictionary[input[0]].Add(input[1], decimal.Parse(input[2]));
        }
    }

    input = Console.ReadLine().Split(',').ToArray();
}

foreach (var shop in dictionary)
{
    Console.WriteLine($"{shop.Key}->");

    foreach (var item in shop.Value)
    {
        Console.WriteLine($"Product:{item.Key}, Price: {item.Value:F1}");
    }
}