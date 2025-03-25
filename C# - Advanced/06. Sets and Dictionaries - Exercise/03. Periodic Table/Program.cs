int numberOfInputLines = int.Parse(Console.ReadLine());
SortedSet<string> uniqueElements = new SortedSet<string>();

for (int i = 0; i < numberOfInputLines; i++)
{
    string[] input = Console.ReadLine().Split(" ").ToArray();

    for (int j = 0; j < input.Length; j++)
    {
        uniqueElements.Add(input[j]);
    }
}

foreach (string uniqueElement in uniqueElements)
{
    Console.Write(uniqueElement + " ");
}