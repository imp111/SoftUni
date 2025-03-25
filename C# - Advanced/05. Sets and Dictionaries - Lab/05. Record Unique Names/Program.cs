int n = int.Parse(Console.ReadLine());

HashSet<string> set = new HashSet<string>(n);

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    set.Add(name);
}

Console.WriteLine(string.Join("\n", set));
