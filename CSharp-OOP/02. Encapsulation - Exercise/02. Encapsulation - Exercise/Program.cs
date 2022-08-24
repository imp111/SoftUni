using _02._Encapsulation___Exercise;

double length = 0, width = 0, height = 0;

try
{
    length = double.Parse(Console.ReadLine());
    width = double.Parse(Console.ReadLine());
    height = double.Parse(Console.ReadLine());
    Box box = new Box(length, width, height);
    box.SurfaceArea();
    box.LateralSurfaceArea();
    box.Volume();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}    