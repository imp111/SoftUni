int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = dimensions[0], columns = dimensions[1];
string[,] matrix = new string[rows, columns];

for (int i = 0; i < rows; i++)
{
    string[] input = Console.ReadLine().Split().ToArray();

    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = input[j];
    }
}

string command = Console.ReadLine();

while (command.ToLower() != "end")
{
    string[] input = command.Split().ToArray();

    if (input[0].ToLower() != "swap" && input.Length != 5)
    {
        Console.WriteLine("Invalid input!");
    }
    else
    {
        if (int.Parse(input[1]) >= rows || int.Parse(input[3]) >= rows || int.Parse(input[2]) >= columns || int.Parse(input[4]) >= columns)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            string buffer1 = " ";
            buffer1 = matrix[int.Parse(input[1]), int.Parse(input[2])];
            matrix[int.Parse(input[1]), int.Parse(input[2])] = matrix[int.Parse(input[3]), int.Parse(input[4])];
            matrix[int.Parse(input[3]), int.Parse(input[4])] = buffer1;

            PrintMatrix(matrix, rows, columns);
        }
    }

    command = Console.ReadLine();
}
        
static void PrintMatrix(string[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");

            if (j == columns - 1)
            {
                Console.WriteLine();
            }
        }
    }
}