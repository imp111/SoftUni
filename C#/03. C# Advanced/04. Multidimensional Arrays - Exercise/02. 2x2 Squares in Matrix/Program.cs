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

Console.WriteLine(SquareOfEquals(array, n[0], n[1]));

int SquareOfEquals(string[,] array, int rows, int columns)
{
    int count = 0;

    for (int i = 0; i < rows - 1; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            if (array[i, j] == array[i, j + 1] && array[i, j] == array[i + 1, j] && array[i, j] == array[i + 1, j + 1])
            {
                count++;
            }
        }
    }

    return count;
}