int n = int.Parse(Console.ReadLine());

string[] command; 
int[][] matrix = new int[n][];

PopulateMatrix(matrix, n);
AnalyzeMatrix(matrix);
AddCommandsToMatrix(matrix);
PrintMatrix(matrix);

static void PopulateMatrix(int[][] matrix, int n)
{
    for (int i = 0; i < n; i++)
    {
        int[] sequence = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        
        for (int j = 0; j < sequence.Length; j++)
        {
            matrix[i] = sequence;
        }
    }
}

static void PrintMatrix(int[][] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            Console.Write("{0} ", matrix[i][j]);
        }
        Console.WriteLine();
    }
}

static void AddCommandsToMatrix(int[][] matrix)
{
    string command = Console.ReadLine();

    while (command.ToLower() != "end")
    {
        string[] commandArray = command.Split(" ").ToArray();
        if (commandArray.Length == 4)
        {
            string operation = commandArray[0];
            int row = int.Parse(commandArray[1]);
            int column = int.Parse(commandArray[2]);
            int value = int.Parse(commandArray[3]);

            switch (operation.ToLower())
            {
                case "add":
                    if (row >= 0 && row < matrix.Length && column >= 0 && column < matrix[row].Length)
                    {
                        matrix[row][column] += value;
                    }

                    break;
                case "subtract":
                    if (row >= 0 && row < matrix.Length && column >= 0 && column < matrix[row].Length)
                    {
                        matrix[row][column] -= value;
                    }

                    break;
                default:
                    break;
            }
        }

        command = Console.ReadLine();
    }
}

static void AnalyzeMatrix(int[][] matrix)
{
    for (int i = 0; i < matrix.Length - 1; i++)
    {
        if (matrix[i].Length == matrix[i + 1].Length)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] *= 2;
                matrix[i + 1][j] *= 2;
            }
        }
        else
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] /= 2;
                
            }

            for (int j = 0; j < matrix[i + 1].Length; j++)
            {
                matrix[i + 1][j] /= 2;
            }
        }
    }
}