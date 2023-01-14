int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
string snake = Console.ReadLine().Trim();

if (input[0] < 0 || input[1] < 0 || input[0] > 12 || input[1] > 12 || snake.Length < 1 || snake.Length > 12)
{
    Console.WriteLine("Wrong dimensions mate");
    Environment.Exit(0);
}

Queue<char> queue = new Queue<char>();
char[,] array = new char[input[0], input[1]];

AssignQueue(snake, queue, input[0]);
AssignMatrix(array, input[0], input[1], snake, queue);
PrintMatrix(array, input[0], input[1]);

static void AssignQueue(string snake, Queue<char> queue, int input)
{
    for (int j = 0; j < input; j++)
    {
        for (int i = 0; i < snake.Length; i++)
        {
            queue.Enqueue(snake[i]);
        }
    }
}

static void AssignMatrix(char[,] matrix, int rows, int columns, string snake, Queue<char> queue)
{
    for (int i = 0; i < rows; i++)
    {
        if (i % 2 == 1)
        {
            for (int j = columns - 1; j >= 0; j--)
            {
                matrix[i, j] = queue.Dequeue();
            }
        }
        else
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = queue.Dequeue();
            }
        }
        
    }
}

static void PrintMatrix(char[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }
}