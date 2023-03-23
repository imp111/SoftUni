int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split().ToArray();

    string continent = input[0];
    string country = input[1];
    string town = input[2];

    if (input.Length == 3)
    {
        if (dictionary.ContainsKey(continent))
        {
            if (dictionary[continent].ContainsKey(country))
            {
                dictionary[continent][country].Add(town);
            }
            else
            {
                dictionary[continent].Add(country, new List<string>());
                dictionary[continent][country].Add(town);
            }
        }
        else
        {
            dictionary.Add(continent, new Dictionary<string, List<string>>());
            dictionary[continent].Add(country, new List<string>());
            dictionary[continent][country].Add(town);
        }
    }
}

foreach (var continent in dictionary)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var country in continent.Value)
    {
        Console.Write($"    {country.Key} -> ");

        for (int i = 0; i < country.Value.Count; i++)
        {

            if (i == country.Value.Count - 1)
            {
                Console.Write($"{country.Value[i]}");
            }
            else
            {
                Console.Write($"{country.Value[i]}, ");
            }
        }
        Console.WriteLine();
    }
}