using _03._Raiding;

int n = int.Parse(Console.ReadLine());
List<BaseHero> raidGroup = new List<BaseHero>();

for (int i = 0; i < n; i++)
{
    string heroName = Console.ReadLine();
    string heroType = Console.ReadLine();

    switch (heroType.ToLower())
	{
		case "paladin":
			raidGroup.Add(new Paladin(heroName, 0));
			break;
		case "druid":
            raidGroup.Add(new Druid(heroName, 0));
            break;
		case "rogue":
            raidGroup.Add(new Rogue(heroName, 0));
            break;
		case "warrior":
            raidGroup.Add(new Warrior(heroName, 0));
            break;
		default:
            Console.WriteLine("Invalid hero!");
            break;
	}
}

int bossHealth = int.Parse(Console.ReadLine());
int sum = 0;

foreach (var item in raidGroup)
{
    Console.WriteLine(item.CastAbility());
    sum += item.Power;
}

string message = "";
if (sum >= bossHealth)
{
    message = "Victory!";
}
else
{
    message = "Defeat...";
}
Console.WriteLine(message);