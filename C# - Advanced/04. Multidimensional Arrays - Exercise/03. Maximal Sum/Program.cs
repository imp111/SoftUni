int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[,] array = new int[dimensions[0], dimensions[1]];
int[,] outputMatrix = new int[3, 3];

for (int i = 0; i < dimensions[0]; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int j = 0; j < dimensions[1]; j++)
    {
        array[i, j] = input[j];
    }
}

Console.WriteLine(MatrixSum(array, dimensions[0], dimensions[1]));

foreach (var item in outputMatrix)
{
    Console.WriteLine(item);
}

int MatrixSum(int[,] array, int rows, int columns)
{
    int sum = 0;
    int maxSum = 0;

    for (int i = 0; i < rows - 2; i++)
    {
        for (int j = 0; j < columns - 2; j++)
        {
            sum += array[i, j] + array[i, j + 1] + array[i, j + 2] + array[i + 1, j] + array[i + 1, j + 1] + array[i + 1, j + 2] + array[i + 2, j] + array[i + 2, j + 1] + array[i + 2, j + 2];
            
            if (sum > maxSum)
            {
                maxSum = sum;
                sum = 0;
            }
            else
            {
                sum = 0;
            }
        }
    }

    return maxSum;
}

int Matrix(int[,] outputMatrix, int inputMatrix, int rows, int columns)
{
    for (int i = 0; i < rows - 2; i++)
    {
        for (int j = 0; j < columns - 2; j++)
        {
           // sum += array[i, j] + array[i, j + 1] + array[i, j + 2] + array[i + 1, j] + array[i + 1, j + 1] + array[i + 1, j + 2] + array[i + 2, j] + array[i + 2, j + 1] + array[i + 2, j + 2];
        }
    }

    return 0;
}