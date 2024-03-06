
using CarTask;
Console.WriteLine("Brands");
string brands = Console.ReadLine();
Console.WriteLine("Models");
int models = int.Parse(Console.ReadLine());
Console.WriteLine("Colour");
string colour = Console.ReadLine();
Console.WriteLine("Production Year");
long productionYear = long.Parse(Console.ReadLine());
Console.WriteLine("Generation Type");
string generationType = Console.ReadLine();
List<CarProperty> Car = new List<CarProperty>()
{
new CarProperty(){ Brands=brands, Models=models, Colour=colour, ProductionYear=productionYear, GenerationType=generationType },
  
};
foreach (var CarProperty in Car)
{
    Console.WriteLine($"Car Proporties=>Brands:{CarProperty.Brands} Models:{CarProperty.Models} Colour:{CarProperty.Colour} Production Year:{CarProperty.ProductionYear} Generation Type:{CarProperty}");
}


