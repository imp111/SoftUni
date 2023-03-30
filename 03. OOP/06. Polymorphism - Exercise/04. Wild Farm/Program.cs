using _04._Wild_Farm;
using _04._Wild_Farm.Birds;

string command = Console.ReadLine();
List<Animal> list = new List<Animal>();
while (command.ToLower() != "end")
{
    string[] animalInput = command.Split().ToArray();
    string type, name, livingRegion, breed, foodType;
    double weight, wingSize;
    int quantity;

    string[] food = Console.ReadLine().Split().ToArray();

    type = animalInput[0];

    name = animalInput[1];
    weight = double.Parse(animalInput[2]);
    livingRegion = animalInput[3];
    breed = animalInput[4];
    
    quantity = int.Parse(food[1]);
    wingSize = 0.0;
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
                list.Add(cat);
                cat.MakeSound();
                break;
            case "tiger":
                Mammal tiger = new Tiger(name, weight, quantity, livingRegion, breed);
                list.Add(tiger);
                tiger.MakeSound();
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
                list.Add(hen);
                hen.MakeSound();
                break;
            case "owl":
                Bird owl = new Owl(name, weight, quantity, wingSize);
                list.Add(owl);
                owl.MakeSound();
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
                list.Add(mouse);
                mouse.MakeSound();
                break;
            case "dog":
                Mammal dog = new Dog(name, weight, quantity, livingRegion);
                list.Add(dog);
                dog.MakeSound();
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