string command = Console.ReadLine();

HashSet<string> vipGuests = new HashSet<string>();
HashSet<string> normalGuests = new HashSet<string>();

while (command.ToLower() != "party")
{
    if (command.Count() == 8)
    {
        if (Char.IsDigit(command[0]))
        {
            vipGuests.Add(command);
        }
        else
        {
            normalGuests.Add(command);
        }
    }

    command = Console.ReadLine();
}

command = Console.ReadLine();
while (command.ToLower() != "end")
{
    if (vipGuests.Contains(command))
    {
        vipGuests.Remove(command);
    }
    else if (normalGuests.Contains(command))
    {
        normalGuests.Remove(command);
    }
    else
    {
        continue;
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{vipGuests.Count + normalGuests.Count}");

if (vipGuests.Count <= 0)
{
    Console.WriteLine(string.Join("\n", normalGuests));
}
else if (normalGuests.Count <= 0)
{
    Console.WriteLine(string.Join("\n", vipGuests));
}
else
{
    Console.WriteLine(string.Join("\n", vipGuests));
    Console.WriteLine(string.Join("\n", normalGuests));
}
