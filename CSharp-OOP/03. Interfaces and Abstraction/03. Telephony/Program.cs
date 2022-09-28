
using _03._Telephony;
using _03._Telephony.Interfaces;

string[] numbers = Console.ReadLine().Split().ToArray();
string[] urls = Console.ReadLine().Split().ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i].Length == 7)
    {
        IStationary homePhone = new Stationaryphone(numbers[i]);
        homePhone.Calling(numbers[i]);
    }
    else
    {
        ISmart smartPhone = new Smartphone(numbers[i]);
        smartPhone.Calling(numbers[i]);
    }
}

for (int i = 0; i < urls.Length; i++)
{

}