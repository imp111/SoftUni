Dictionary<double, int> dictionary = new Dictionary<double, int>();

double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

for (int i = 0; i < array.Length; i++)
{
    if (dictionary.ContainsKey(array[i]))
    {
        dictionary[array[i]] += 1;
    }
    else
    {
        dictionary.Add(array[i], 1);
    }
}

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}