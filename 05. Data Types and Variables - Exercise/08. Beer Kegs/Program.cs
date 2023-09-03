int n = int.Parse(Console.ReadLine());

double volumeBiggestKeg = 0;
string biggestKeg = string.Empty;

for (int i = 1; i <= n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());

    double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

    if (kegVolume > volumeBiggestKeg)
    {
        volumeBiggestKeg = kegVolume;
        biggestKeg = model;
    }
}

Console.WriteLine(biggestKeg);