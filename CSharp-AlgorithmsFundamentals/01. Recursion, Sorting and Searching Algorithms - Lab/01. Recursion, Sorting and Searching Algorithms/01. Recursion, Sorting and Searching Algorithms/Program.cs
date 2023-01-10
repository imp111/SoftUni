int[] array = new int[] { 1, 2, 3, 4, 5 };
int sum = Sum(array, 0);
Console.WriteLine(sum);

static int Sum(int[] array, int index)
{
    if (index == array.Length)
    {
        return 0;
    }

    return array[index] + Sum(array, index + 1);
}