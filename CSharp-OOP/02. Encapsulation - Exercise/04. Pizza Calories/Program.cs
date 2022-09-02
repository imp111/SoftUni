using _04._Pizza_Calories;

try
{
    string[] input = Console.ReadLine().Split().ToArray();

    while (input[0] != "end")
    {
        switch (input[0].ToLower())
        {
            case "pizza":
                break;
            case "dough":
                Dough dough = new Dough(input[0], input[1], input[2], double.Parse(input[3]));
                dough.CalorieCount();
                break;
            case "topping":
                Topping topping = new Topping(input[0], input[1], double.Parse(input[2]));
                topping.CountCalories();
                break;
            default:
                Console.WriteLine("Incorrect command");
                break;
        }

        input = Console.ReadLine().Split().ToArray();
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    return;
}

