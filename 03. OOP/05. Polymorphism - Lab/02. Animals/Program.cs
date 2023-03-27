using _02._Animals;

Animal noAnimal = new Animal("nameless", "noFood");
Animal cat = new Cat("George", "Cat Food");
Animal dog = new Dog("Gosho", "Dog Food");

Console.WriteLine(noAnimal.ExplainSelf());
Console.WriteLine(cat.ExplainSelf());
Console.WriteLine(dog.ExplainSelf());
