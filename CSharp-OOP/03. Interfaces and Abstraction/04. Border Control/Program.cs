using _04._Border_Control;
using _04._Border_Control.Interfaces;

List<IDentity> list = new List<IDentity>();
string command;

while ((command = Console.ReadLine().ToLower()) != "end")
{
    var tokens = command.Split();

    if (tokens.Length == 3)
    {
        list.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));
    }
    else if (tokens.Length == 2)
    {
        list.Add(new Robot(tokens[0], tokens[1]));
    }
}

string fakeIdNum =Console.ReadLine();

list.Where(c => c.Id.EndsWith(fakeIdNum))
            .Select(c => c.Id)
            .ToList()
            .ForEach(Console.WriteLine);