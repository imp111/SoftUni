using _04._Wild_Farm;
using _04._Wild_Farm.Birds;

string command = Console.ReadLine();
List<Animal> list = new List<Animal>();
while (command.ToLower() != "end")
{
    string[] animalInput = command.Split().ToArray();

    if (animalInput.Length > 5 || animalInput.Length < 4 || animalInput.Length == 1)
    {
        break;
    }

    string type, name, livingRegion, breed, foodType;
    double weight, wingSize;
    int quantity;

    string[] food = Console.ReadLine().Split().ToArray();

    if (food.Length > 2 || food.Length <= 0)
    {
        continue;
    }

    type = animalInput[0];
    quantity = int.Parse(food[1]);
    foodType = food[0];

    if (type.ToLower() == "cat" || type.ToLower() == "tiger")
    {
        name = animalInput[1];
        weight = double.Parse(animalInput[2]);
        quantity = int.Parse(food[1]);
        livingRegion = animalInput[3];
        breed = animalInput[4];

        switch (type.ToLower())
        {
            case "cat":
                Mammal cat = new Cat(name, weight, quantity, livingRegion, breed);
                cat.MakeSound();
                cat.Eat(foodType);
                list.Add(cat);
                break;
            case "tiger":
                Mammal tiger = new Tiger(name, weight, quantity, livingRegion, breed);
                tiger.MakeSound();
                tiger.Eat(foodType);
                list.Add(tiger);
                break;
            default:
                break;
        }
        
    }
    else if (type.ToLower() == "hen" || type.ToLower() == "owl")
    {
        name = animalInput[1];
        weight = double.Parse(animalInput[2]);
        wingSize = double.Parse(animalInput[3]);

        switch (type.ToLower())
        {
            case "hen":
                Bird hen = new Hen(name, weight, quantity, wingSize);
                hen.MakeSound();
                hen.Eat(foodType);
                list.Add(hen);
                break;
            case "owl":
                Bird owl = new Owl(name, weight, quantity, wingSize);
                owl.MakeSound();
                owl.Eat(foodType);
                list.Add(owl);
                break;
            default:
                break;
        }
    }
    else if (type.ToLower() == "mouse" || type.ToLower() == "dog")
    {
        name = animalInput[1];
        weight = double.Parse(animalInput[2]);
        livingRegion = animalInput[3];

        switch (type.ToLower())
        {
            case "mouse":
                Mammal mouse = new Mouse(name, weight, quantity, livingRegion);
                mouse.MakeSound();
                mouse.Eat(foodType);
                list.Add(mouse);
                break;
            case "dog":
                Mammal dog = new Dog(name, weight, quantity, livingRegion);
                dog.MakeSound();
                dog.Eat(foodType);
                list.Add(dog);
                break;
            default:
                break;
        }
    }

    command = Console.ReadLine();
}

foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}