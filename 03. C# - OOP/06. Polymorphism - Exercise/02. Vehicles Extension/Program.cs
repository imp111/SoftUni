using _02._Vehicles_Extension;

string[] input = Console.ReadLine().Split().ToArray();

double fuel = 0.0;
double consumption = 0.0;
double capacity = 0.0;

if (input.Length == 4)
{
    fuel = double.Parse(input[1]);
    consumption = double.Parse(input[2]);
    capacity = double.Parse(input[3]);
}

Vehicle car = new Car(fuel, consumption, capacity);

input = Console.ReadLine().Split().ToArray();

if (input.Length == 4)
{
    fuel = double.Parse(input[1]);
    consumption = double.Parse(input[2]);
    capacity = double.Parse(input[3]);
}

Vehicle truck = new Truck(fuel, consumption, capacity);

input = Console.ReadLine().Split().ToArray();

if (input.Length == 4)
{
    fuel = double.Parse(input[1]);
    consumption = double.Parse(input[2]);
    capacity = double.Parse(input[3]);
}

Vehicle bus = new Bus(fuel, consumption, capacity);

int n = int.Parse(Console.ReadLine());

string action;
double distance;
string type;

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
            case "bus":
                bus.Drive(distance);
                break;
            default:
                break;
        }
    }

    if (action.ToLower() == "driveempty")
    {
        if (type.ToLower() == "bus")
        {
            bus.DriveEmpty(distance);
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
            case "bus":
                bus.Refuel(distance);
                break;
            default:
                break;
        }
    }
}

Console.WriteLine($"Car: {car.Fuel:F2}");
Console.WriteLine($"Truck: {truck.Fuel:F2}");
Console.WriteLine($"Bus: {bus.Fuel:F2}");