int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int j = 0; j < n; j++)
    {
        array[i, j] = input[j];
    }
}

Console.WriteLine($"{Math.Abs(PrimaryDiagonal(array, n) - SecondaryDiagonal(array, n))}");


int PrimaryDiagonal(int[,] array, int n)
{
    int primarySum = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                primarySum += array[i, j];
            }
        }
    }

    return primarySum;
}

int SecondaryDiagonal(int[,] array, int n)
{
    int secondarySum = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i + j) == (n - 1))
            {
                secondarySum += array[i, j];
            }
        }
    }

    return secondarySum;
}

