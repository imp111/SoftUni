using _01._Vehicles;

string[] input = Console.ReadLine().Split().ToArray();

string type = "";
double fuel = 0.0;
double consumption = 0.0;

if (input.Length == 3)
{
    type = input[0];
    fuel = double.Parse(input[1]);
    consumption = double.Parse(input[2]);
}

Vehicle car = new Car(fuel, consumption);

input = Console.ReadLine().Split().ToArray();

if (input.Length == 3)
{
    type = input[0];
    fuel = double.Parse(input[1]);
    consumption = double.Parse(input[2]);
}

Vehicle truck = new Truck(fuel, consumption);

int n = int.Parse(Console.ReadLine());

string action;
double distance;
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine().Split().ToArray();

    action = input[0];
    type = input[1];
    distance = double.Parse(input[2]);

    if (action.ToLower() == "drive")
    {
        switch (type.ToLower())
        {
            case "car":
                car.Drive(distance);
                break;
            case "truck":
                truck.Drive(distance);
                break;
            default:
                break;
        }
    }

    if (action.ToLower() == "refuel")
    {
        switch (type.ToLower())
        {
            case "car":
                car.Refuel(distance);
                break;
            case "truck":
                truck.Refuel(distance);
                break;
            default:
                break;
        }
    }
}

Console.WriteLine($"Car: {car.Fuel:F2}");
Console.WriteLine($"Truck: {truck.Fuel:F2}");