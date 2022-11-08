int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

string[,] array = new string[n[0], n[1]];

for (int i = 0; i < n[0]; i++)
{
    string[] input = Console.ReadLine().Split().ToArray();

    for (int j = 0; j < n[1]; j++)
    {
        array[i, j] = input[j];
    }
}
