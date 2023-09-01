Console.Write("Length: "); double length = double.Parse(Console.ReadLine());

Console.Write("Width: "); double width = double.Parse(Console.ReadLine());

Console.Write("Height: "); double height = double.Parse(Console.ReadLine());

double baseArea = length * width;

double volume = ((baseArea * height) / 3.0);

Console.WriteLine($"Pyramid Volume: {volume:f2}");