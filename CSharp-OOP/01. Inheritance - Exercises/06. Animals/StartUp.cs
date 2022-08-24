using _06._Animals;

string animal = Console.ReadLine();
string[] info = new string[3];
List<string> animalTypes = new List<string>();
Queue<string> animalQueue = new Queue<string>();

while (animal.ToLower() != "beast!")
{
    animalTypes.Add(animal);
    info = Console.ReadLine().Split().ToArray();

    for (int i = 0; i < info.Length; i++)
    {
        animalQueue.Enqueue(info[i]);
    }
    
    animal = Console.ReadLine();
}

foreach (var item in animalTypes)
{
    switch (item.ToLower())
    {
        case "dog":
            Dog dog = new Dog(animalQueue.Dequeue(), int.Parse(animalQueue.Dequeue()), animalQueue.Dequeue());

            if (dog.Age >= 0)
            {
                dog.PrintInfo();
                dog.ProduceSound();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            break;

        case "cat":
            Cat cat = new Cat(animalQueue.Dequeue(), int.Parse(animalQueue.Dequeue()), animalQueue.Dequeue());

            if (cat.Age >= 0)
            {
                cat.PrintInfo();
                cat.ProduceSound();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            break;

        case "frog":
            Frog frog = new Frog(animalQueue.Dequeue(), int.Parse(animalQueue.Dequeue()), animalQueue.Dequeue());

            if (frog.Age >= 0)
            {
                frog.PrintInfo();
                frog.ProduceSound();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            break;

        case "kitten":
            Kitten kitten = new Kitten(animalQueue.Dequeue(), int.Parse(animalQueue.Dequeue()), animalQueue.Dequeue());

            if (kitten.Age >= 0)
            {
                kitten.PrintInfo();
                kitten.ProduceSound();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            break;

        case "tomcat":
            Tomcat tomcat = new Tomcat(animalQueue.Dequeue(), int.Parse(animalQueue.Dequeue()), animalQueue.Dequeue());

            if (tomcat.Age >= 0)
            {
                tomcat.PrintInfo();
                tomcat.ProduceSound();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            break;

        default:
            break;
    }
}