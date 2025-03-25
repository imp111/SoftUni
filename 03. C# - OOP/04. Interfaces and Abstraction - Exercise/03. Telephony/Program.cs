using _03._Telephony;
using _03._Telephony.Interfaces;

string[] numbers = Console.ReadLine().Split().ToArray();
string[] urls = Console.ReadLine().Split().ToArray();

foreach (var item in numbers)
{
    switch (item.Length)
    {
        case 7:
            ISmart homePhone = new Smartphone();
            Console.WriteLine(homePhone.Dialling(item));
            break;
        case 10:
            ISmart smartPhone = new Smartphone();
            Console.WriteLine(smartPhone.Calling(item));
            break;
        default:
            break;
    }
}

foreach (var item in urls)
{
    ISmart smartPhone = new Smartphone();
    Console.WriteLine(smartPhone.Browse(item));
}