using _03._Raiding;

BaseHero paladin = new Paladin("PGosho", 0);
BaseHero warrior = new Warrior("WGosho", 0);
BaseHero druid = new Druid("Dgosho", 0);
BaseHero rouge = new Rouge("Rgosho", 0);

Console.WriteLine(paladin.CastAbility());
Console.WriteLine(warrior.CastAbility());
Console.WriteLine(druid.CastAbility());
Console.WriteLine(rouge.CastAbility());

