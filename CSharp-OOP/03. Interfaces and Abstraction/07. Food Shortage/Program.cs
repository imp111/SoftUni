using _07._Food_Shortage;
using _07._Food_Shortage.Interfaces;

List<IBuyer> list = new List<IBuyer>();
int numberOfPeople = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfPeople; i++)
{
    var tokens = Console.ReadLine().Split();

    if (tokens.Length == 4)
    {
        list.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3], 0));
    }
    else if (tokens.Length == 3)
    {
        list.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2], 0));
    }
}

string command;

while ((command = Console.ReadLine().ToLower()) != "end")
{
    var buyer = list.SingleOrDefault(b => b.Name.ToLower() == command.ToLower());
    
    if (buyer != null)
    {
        buyer.BuyFood();
    }
}

Console.WriteLine(list.Sum(p => p.Food));
