int boardSize = int.Parse(Console.ReadLine());
char[,] matrix = new char[boardSize, boardSize];

AssignMatrtix(matrix, boardSize);
PrintMatrix(matrix, boardSize);

static void AssignMatrtix(char[,] matrix, int boardSize)
{
    for (int i = 0; i < boardSize; i++)
    {
        char[] charArray = Console.ReadLine().ToCharArray();

        if (charArray.Length == boardSize)
        {
            for (int j = 0; j < boardSize; j++)
            {
                matrix[i, j] = charArray[j];
            }
        }   
    }
}

static void PrintMatrix(char[,] matrix, int boardSize)
{
    Console.WriteLine();
    for (int i = 0; i < boardSize; i++)
    {
        for (int j = 0; j < boardSize; j++)
        {
            Console.Write($"{matrix[i, j]}"); 
        }

        Console.WriteLine();
    }
}
