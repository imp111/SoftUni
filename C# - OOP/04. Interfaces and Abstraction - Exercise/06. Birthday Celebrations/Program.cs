using _06._Birthday_Celebrations;
using _06._Birthday_Celebrations.Interfaces;

List<IDate> list = new List<IDate>();
string command;

while ((command = Console.ReadLine().ToLower()) != "end")
{
    var tokens = command.Split();

    if (tokens[0].ToLower() == "citizen")
    {
        list.Add(new Person(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
    }
    else if (tokens[0].ToLower() == "pet")
    {
        list.Add(new Pet(tokens[1], tokens[2]));
    }
}

string fakeIdNum = Console.ReadLine();

list.Where(c => c.Date.EndsWith(fakeIdNum))
            .Select(c => c.Date)
            .ToList()
            .ForEach(Console.WriteLine);