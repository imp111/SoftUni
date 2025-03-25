int numberOfColors = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < numberOfColors; i++)
{
	string[] input = Console.ReadLine().Split("->").ToArray();
	
	string color = input[0].Trim();
    string[] clothes = input[1].Trim().Split(",").ToArray();

    for (int j = 0; j < clothes.Length; j++)
	{
		if (dictionary.ContainsKey(color))
		{
			if (dictionary[color].ContainsKey(clothes[j]))
			{
				dictionary[color][clothes[j]]++;
			}
			else
			{
				dictionary[color].Add(clothes[j], 1);
			}
		}
		else
		{
			dictionary.Add(color, new Dictionary<string, int>());
			dictionary[color].Add(clothes[j], 1);
		}
	}
}

string[] searchingFor = Console.ReadLine().Split().ToArray();
string clothColorToFind = searchingFor[0];
string clothToFind = searchingFor[1];

foreach (var color in dictionary)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var cloth in color.Value)
    {
		if (color.Key == clothColorToFind && cloth.Key == clothToFind)
		{
            Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
        }
		else
		{
            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
        }
    }
}