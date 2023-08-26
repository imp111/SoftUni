int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = input[0];
int number = 0;
List<int> firstList = new List<int>();
for (int i = 0; i < input[0]; i++)
{
    number = int.Parse(Console.ReadLine());
    firstList.Add(number);
}

int m = input[1];
List<int> secondList = new List<int>();
for (int i = 0;i < m; i++)
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