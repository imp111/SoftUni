using _04._Wild_Farm;

string command = Console.ReadLine();

while (command.ToLower() != "end")
{
    string[] animalInput = command.Split().ToArray();
    string type, name, livingRegion, breed, wingSize, foodType;
    double weight;
    int quantity;

    string[] food = Console.ReadLine().Split().ToArray();

    
    type = animalInput[0];

    name = animalInput[1];
    weight = double.Parse(animalInput[2]);
    livingRegion = animalInput[3];
    breed = animalInput[4];
    foodType = food[0];
    quantity = int.Parse(food[1]);

    switch (type.ToLower())
    {
        case "cat":
            Mammal cat = new Cat(type, weight, quantity, livingRegion, breed);
            break;
        case "tiger":
            Mammal tiger = new Tiger(type, weight, quantity, livingRegion, breed);
            break;
        case "hen":
            break;
        case "owl":
            break;
        case "mouse":
            break;
        case "dog":
            break;
        default:
            break;
    }
    if (type.ToLower() == "cat" || type.ToLower() == "tiger")
    { 
    }
    else if (type.ToLower() == "hen" || type.ToLower() == "owl")
    {
        name = animalInput[1];
        weight = animalInput[2];
        wingSize = animalInput[3];
    }
    else if (type.ToLower() == "mouse" || type.ToLower() == "dog")
    {
        name = animalInput[1];
        weight = animalInput[2];
        livingRegion = animalInput[3];
    }
    
    command = Console.ReadLine();
}


/*
    •	Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}"
    •	Birds - "{Type} {Name} {Weight} {WingSize}"
    •	Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}"
 */