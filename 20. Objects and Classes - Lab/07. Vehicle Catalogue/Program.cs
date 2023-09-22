string input = Console.ReadLine();

Catalog catalog = new Catalog();

while (input != "end")
{
    string[] vehicleInfo = input.Split("/").ToArray();

    string type = vehicleInfo[0];
    string make = vehicleInfo[1];
    string model = vehicleInfo[2];
    int value = int.Parse(vehicleInfo[3]);

    if (type == "Car")
    {
        Car car = new Car();
        car.Brand = make;
        car.Model = model;
        car.HorsePower = value;

        catalog.Cars.Add(car);
    }
    else
    {
        Truck truck = new Truck();
        truck.Brand = make;
        truck.Model = model;
        truck.Weight = value;

        catalog.Trucks.Add(truck);
    }

    input = Console.ReadLine();
}

Console.WriteLine("Cars:");
foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
{
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
}

Console.WriteLine("Trucks:");
foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
{
    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
}

class Catalog
{
    public Catalog()
    {
        Trucks = new List<Truck>();

        Cars = new List<Car>();
    }

    public List<Truck> Trucks { get; set; }

    public List<Car> Cars { get; set; }
}
class Car
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public int HorsePower { get; set; }

}
class Truck
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public int Weight { get; set; }
}