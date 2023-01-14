using _04._Pizza_Calories;

string command = Console.ReadLine();

while (command.ToLower() != "end")
{
    string[] tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

    try
    {
        switch (tokens[0].ToLower())
        {
            case "dough":
                Dough dough = new Dough(tokens[0], tokens[1], tokens[2], int.Parse(tokens[3]));
                Console.WriteLine("{0:F2}", dough.CalorieCount());
                break;

            case "topping":
                Topping topping = new Topping(tokens[0], tokens[1], int.Parse(tokens[2]));
                Console.WriteLine("{0:F2}", topping.CountCalories());
                break;

            case "pizza":
                string name = tokens[1];
                int numberOfToppings = 0;
                numberOfToppings = int.Parse(tokens[2]);
                
                command = Console.ReadLine();
                tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                Pizza pizza;

                Dough dough1 = new Dough(tokens[0], tokens[1], tokens[2], int.Parse(tokens[3]));
                pizza = new Pizza(name, dough);

                for (int i = 0; i < numberOfToppings; i++)
                {
                    command = Console.ReadLine();
                    tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                    Topping topping1 = new Topping(tokens[0], tokens[1], int.Parse(tokens[2]));
                    pizza.AddTopping(topping);
                }

                pizza.PrintCalories(dough1.CalorieCount, topping1.CountCalories);
                break;

            default:
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
    
    command = Console.ReadLine();
}