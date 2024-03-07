int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int firstListLength = input[0];
int number = 0;
List<int> firstList = new List<int>();
for (int i = 0; i < firstListLength; i++)
{
    number = int.Parse(Console.ReadLine());
    firstList.Add(number);
}

int secondListLength = input[1];
List<int> secondList = new List<int>();
for (int i = 0;i < secondListLength; i++)
{
    number = int.Parse(Console.ReadLine());
    secondList.Add(number);
}

List<int> intersectList = new List<int>();
foreach (var item in firstList)
{
    if (secondList.Contains(item))
    {
        intersectList.Add(item);
    }
}

for (int i = 0; i < intersectList.Count; i++)
{
    Console.Write(intersectList[i] + " ");

    if (i == intersectList.Count - 1)
    {
        break;
    }
}