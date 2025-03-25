string input = Console.ReadLine();

HashSet<string> parkingLot = new HashSet<string>();
while (input != "end")
{
    string[] car = input.Split(", ").ToArray();
    string command = " ";
    string number = " ";

    if (car.Length < 2)
    {
        break;
    }
    else
    {
        command = car[0];
        number = car[1];
    }

    if (command.ToLower() == "in")
    {
        parkingLot.Add(number);
    }
    else if (command.ToLower() == "out")
    {
        parkingLot.Remove(number);
    }

    input = Console.ReadLine();
}

if (parkingLot.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    Console.WriteLine(string.Join("\n", parkingLot));
}

