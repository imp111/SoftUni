using _03._Interfaces_and_Abstraction;

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

IPerson person = new Citizen(name, age);

Console.WriteLine(person.Name);
Console.WriteLine(person.Age);
