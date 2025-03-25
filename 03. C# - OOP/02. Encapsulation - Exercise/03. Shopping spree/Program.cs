using _03._Shopping_spree;

List<Person> listOfPeople = new List<Person>();
List<Product> listOfProducts = new List<Product>();

string[] input = Console.ReadLine().Split(';').ToArray();

foreach (var item in input)
{
    string[] element = item.Split("=");
    string name = element[0].Trim();
    double money = double.Parse(element[1]);

    try
    {
        listOfPeople.Add(new Person(name, money));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }

}

input = Console.ReadLine().Split(';').ToArray();

foreach (var item in input)
{
    string[] element = item.Split("=");
    string product = element[0].Trim();
    double cost = double.Parse(element[1]);

    try
    {
        listOfProducts.Add(new Product(product, cost));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }

}

string command = Console.ReadLine();

while (command.ToLower() != "end")
{
    input = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
    string personName = input[0];
    string productName = input[1];

    Person person = listOfPeople.Where(p => p.Name == personName).First();
    Product product = listOfProducts.Where(p => p.ProductName == productName).First();

    if (person.PurchaseProduct(product))
    {
        person.AddToBag(product);
    }

    command = Console.ReadLine();
}

foreach (Person person in listOfPeople)
{
    if (person.SeeBag().Count > 0)
    {
        Console.WriteLine("{0} - {1}", person.Name, String.Join(", ", person.SeeBag().Select(p => p.ProductName)));
    }
    else
    {
        Console.WriteLine("{0} - Nothing bought", person.Name);
    }
}