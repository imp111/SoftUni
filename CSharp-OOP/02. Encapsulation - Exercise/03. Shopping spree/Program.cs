using _03._Shopping_spree;

string[] names = Console.ReadLine().Split(';', '=').ToArray();
string[] products = Console.ReadLine().Split(';', '=').ToArray();
List<Person> listOfPeople = new List<Person>();
List<Product> listOfProducts = new List<Product>();

//int higher = Math.Max(names.Length, products.Length);

for (int i = 0; i < products.Length; i++)
{
    if (i % 2 == 0)
    {
        listOfProducts.Add(new Product(products[i], double.Parse(products[i + 1])));
        //listOfPeople.Add(new Person(names[i], double.Parse(names[i + 1]), listOfProducts));
    }
}

string[] commands = Console.ReadLine().Split().ToArray();

while (commands[0].ToLower() != "end")
{
    commands = Console.ReadLine().Split().ToArray();

}

foreach (var item in listOfPeople)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Money);
    Console.WriteLine(item.Bag);
}
