int numberOfIntegers = int.Parse(Console.ReadLine());

Dictionary<int, int> numbers = new Dictionary<int, int>();
for (int i = 0; i < numberOfIntegers; i++)
{
    var number = int.Parse(Console.ReadLine());
    if (numbers.ContainsKey(number))
    {
        numbers[number]++;
    }
    else
    {
        numbers.Add(number, 1);
    }
}

int evenTimesNumber = numbers.First(kvp => kvp.Value % 2 == 0).Key;
Console.WriteLine(evenTimesNumber);