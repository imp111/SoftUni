static int GetSum(int[] array, int index)
{
    if (index >= array.Length)
    {
        return 0;
    }

    return array[index] + GetSum(array, index + 1);
}

int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
Console.WriteLine(GetSum(input, 0));
